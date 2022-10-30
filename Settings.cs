using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LowLevelClientPacket
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void Connect_Button_Click(object sender, EventArgs e)
        {
            if(!Program.ClientApplication.SetupAddress(Address_TextBox.Text))
            {
                MessageBox.Show("Ошибка: формат адреса не верен", "Ошибка");
            }
            else
            {
                MessageBox.Show("Успешно", "Успешно");
            }
        }
    }
}
