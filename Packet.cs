using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowLevelClientPacket
{
    internal enum PacketType : byte
    {
        NONE = 0,
        AUTH = 1
    }

    internal class Packet
    {
        private List<byte> lBytes = new List<byte>();

        public Packet()
        {
            lBytes.Add((byte)PacketType.NONE);
        }

        public Packet(byte[] bytes)
        {
            lBytes.AddRange(bytes);
        }

        public void SetPacketType(PacketType type)
        {
            lBytes[0] = (byte)type;
        }

        public void SetPacketType(byte type)
        {
            lBytes[0] = type;
        }

        public void ReWrite(byte[] bytes)
        {
            lBytes.Clear();
            lBytes.AddRange(bytes);
        }

        public void AddByte(byte value) => lBytes.Add(value);
        public byte GetByte(int inx) => lBytes[inx];

        public byte[] GetBytes(int nStart, int nEnd)
        {
            byte[] bytes = new byte[nEnd - nStart];

            int byteCounter = 0;
            for (int i = nStart; i < nEnd; i++)
            {
                bytes[byteCounter] = lBytes[i];

                byteCounter++;
            }

            return bytes;
        }

        public byte[] GetBytes() => lBytes.ToArray();

        public void AddBytes(byte[] bytes)
        {
            foreach (byte b in bytes)
            {
                lBytes.Add(b);
            }
        }

        public int GetInt(int nStart) => BitConverter.ToInt32(lBytes.ToArray(), nStart);

        public void AddInt(int value)
        {
            byte[] bytes = BitConverter.GetBytes(value);
            foreach (byte b in bytes)
            {
                lBytes.Add(b);
            }
        }

        public void AddString(string value)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(value);
            foreach (byte b in bytes)
            {
                lBytes.Add(b);
            }
        }

        public string GetString(int nStart, int nCount)
        {
            return Encoding.ASCII.GetString(lBytes.ToArray(), nStart, nCount);
        }

        public void EncryptSE(string key)
        {
            PacketType nTmp = (PacketType)lBytes[0];
            byte[] KeyBytes = Encoding.ASCII.GetBytes(key);
            int nKeyLen = KeyBytes.Length;
            int nKeyCounter = 0;

            for (int i = 0; i < lBytes.Count; i++)
            {
                if (nKeyCounter >= nKeyLen)
                {
                    nKeyCounter = 0;
                }

                byte cKey = KeyBytes[nKeyCounter];

                lBytes[i] ^= cKey;

                nKeyCounter++;
            }
        }
    }
}
