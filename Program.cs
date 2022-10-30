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
                    // Мы разделяем наш аддрес чтобы оттдельно получить IP и порт
                    // Пример: 127.0.0.1:653
                    string[] sAddr2 = sAddr.Split(':');
                    // Поверяем является ли аддрес доменом
                    sIP = sAddr2[0];
                    // Парсим воторую часть строки в порт
                    nPort = int.Parse(sAddr2[1]);
                    messageHandler?.Invoke($"Адресс изменен на: {sAddr}");
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
                    // производим подключение
                    m_TCPClient = new TcpClient(sIP, nPort);
                    // получаем поток
                    m_Stream = m_TCPClient.GetStream();
                    messageHandler?.Invoke($"Соединение установлено с: {sIP}:{nPort}");
                }
                catch
                {
                    return false;
                }

                return true;
            }

            static public void Close()
            {
                // закрываем поток
                m_Stream.Close();
                // закрываем соединение
                m_TCPClient.Close();

                messageHandler?.Invoke($"Соединение Закрыто с: {sIP}:{nPort}");
            }

            // Данный метод позволяет отправлять int переменную
            static public void Write(int nData)
            {
                // конвертируем int в байты
                byte[] bytes = BitConverter.GetBytes(nData);
                // отправляем полученные байты клиенту
                m_Stream.Write(bytes, 0, sizeof(int));
            }

            static public int ReadInt()
            {
                // Резервируем байты для принятия данных
                byte[] data = new byte[sizeof(int)];
                // принимает байты с клиента
                m_Stream.Read(data, 0, sizeof(int));
                // конвертируем полуечнные данные в int
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
                // получаем количество байт
                int nSize = data.Length;
                // отправляем размер строки клиенту
                Write(nSize);
                // отправляем байты строки клиенту
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