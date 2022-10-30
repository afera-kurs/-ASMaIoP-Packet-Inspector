using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static LowLevelClientPacket.Program;

namespace LowLevelClientPacket
{
    public partial class PacketSend : Form
    {
        Packet packet = new Packet();
        public Program.AddMessage? handler = null;

        public PacketSend()
        {
            InitializeComponent();
        }

        private void SetupPacketType_button_Click(object sender, EventArgs e)
        {
            try
            {
                packet.SetPacketType(Convert.ToByte(PacketType_TextBox.Text));
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            DemonstratePacket();
        }

        private void AddData_button_Click(object sender, EventArgs e)
        {
            try
            {
                switch (DataTypes_ComboBox.SelectedIndex)
                {
                    case 0:
                        {
                            packet.AddString(Data_TextBox.Text);
                        }
                        break;
                    case 1:
                        {
                            packet.AddInt(Convert.ToInt32(Data_TextBox.Text));
                        }
                        break;
                    case 2:
                        {
                            packet.AddByte(Convert.ToByte(Data_TextBox.Text));
                        }
                        break;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            DemonstratePacket();
        }
        
        private void Send_button_Click(object sender, EventArgs e)
        {
            handler?.Invoke($"Отправка пакета размером {packet.GetBytes().Length}");
            if (!ClientApplication.Connect())
            {
                MessageBox.Show("Ошибка подключения к серверу");
                return;
            }

            ClientApplication.Write(packet.GetBytes());

            packet.ReWrite(ClientApplication.ReadBytes());

            ClientApplication.Close();

            handler?.Invoke($"получен пакет размером {packet.GetBytes().Length}");
            DemonstratePacket();
        }

        private void Encrypt_button_Click(object sender, EventArgs e)
        {
            packet.EncryptSE(Key_TextBox.Text);
            handler?.Invoke($"пакет зашифрован ключем {Key_TextBox.Text}");
            DemonstratePacket();
        }

        private void Clear_button_Click(object sender, EventArgs e)
        {
            byte[] bytes = { 0 };
            packet.ReWrite(bytes);
            DemonstratePacket();
        }

        private void DemonstratePacket()
        {
            byte[] bytes = packet.GetBytes();

            PacketShow_textBox.Clear();

            try
            {
                foreach (byte b in bytes)
                {
                    if(b == 0)
                    {
                        PacketShow_textBox.Text += $"{0} - ' '\r\n";
                    }
                    else
                    {
                        PacketShow_textBox.Text += $"{b} - '{Convert.ToChar(b)}'\r\n";
                    }
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        Packet Save = new Packet();
        private void SavePacket_Click(object sender, EventArgs e)
        {
            Save.ReWrite(packet.GetBytes());
        }

        private void Load_button_Click(object sender, EventArgs e)
        {
            if (Save != null)
            {
                packet.ReWrite(Save.GetBytes());
                DemonstratePacket();
            }
        }
    }
}
