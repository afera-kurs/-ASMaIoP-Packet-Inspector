using System.Net;
using System.Net.Sockets;

namespace LowLevelClientPacket
{
    public static class Program
    {
        public delegate void AddMessage(string msg);

        public static class ClientApplication
        {
            static TcpClient m_TCPClient;
            static  NetworkStream m_Stream;

            static string sIP;
            static int nPort;

            static public event AddMessage? messageHandler;

            static public bool SetupAddress(string sAddr)
            {
                try
                {
                    // �� ��������� ��� ������ ����� ��������� �������� IP � ����
                    // ������: 127.0.0.1:653
                    string[] sAddr2 = sAddr.Split(':');
                    // �������� �������� �� ������ �������
                    sIP = sAddr2[0];
                    // ������ ������� ����� ������ � ����
                    nPort = int.Parse(sAddr2[1]);
                    messageHandler?.Invoke($"������ ������� ��: {sAddr}");
                }
                catch
                {
                    return false;
                }
                return true;
            }

            static public bool Connect()
            {
                try
                {
                    // ���������� �����������
                    m_TCPClient = new TcpClient(sIP, nPort);
                    // �������� �����
                    m_Stream = m_TCPClient.GetStream();
                    messageHandler?.Invoke($"���������� ����������� �: {sIP}:{nPort}");
                }
                catch
                {
                    return false;
                }

                return true;
            }

            static public void Close()
            {
                // ��������� �����
                m_Stream.Close();
                // ��������� ����������
                m_TCPClient.Close();

                messageHandler?.Invoke($"���������� ������� �: {sIP}:{nPort}");
            }

            // ������ ����� ��������� ���������� int ����������
            static public void Write(int nData)
            {
                // ������������ int � �����
                byte[] bytes = BitConverter.GetBytes(nData);
                // ���������� ���������� ����� �������
                m_Stream.Write(bytes, 0, sizeof(int));
            }

            static public int ReadInt()
            {
                // ����������� ����� ��� �������� ������
                byte[] data = new byte[sizeof(int)];
                // ��������� ����� � �������
                m_Stream.Read(data, 0, sizeof(int));
                // ������������ ���������� ������ � int
                return BitConverter.ToInt32(data, 0);
            }

            static public byte[] ReadBytes()
            {
                int nSize = ReadInt();
                byte[] data = new byte[nSize];
                m_Stream.Read(data, 0, nSize);
                return data;
            }

            static public void Write(byte[] data)
            {
                // �������� ���������� ����
                int nSize = data.Length;
                // ���������� ������ ������ �������
                Write(nSize);
                // ���������� ����� ������ �������
                m_Stream.Write(data, 0, nSize);
            }
        }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}