using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace lab2
{
    internal class CipherAlg
    {
        private const int REGISTER_LENGTH = 31;
        public const int BYTE_LENGTH = 8;
        public const int SIGN = 2;
        private BitArray plain;
        private BitArray result;
        private BitArray key;
        private BitArray register;
        public byte[] data;

        public CipherAlg(BitArray plain, string key)
        {
            this.plain = plain;
            this.key = GetKeyBits(key);
            this.key = GenerateKey();
        }

        public static int GetRegLength() { return REGISTER_LENGTH; }

        private BitArray GetKeyBits(string registerBits)
        {
            register = new BitArray(REGISTER_LENGTH);
            for (int i = 0; i < registerBits.Length; i++)
                register[i] = registerBits[i] == '1';
            return register;
        }

        private BitArray GetNextArray(BitArray register)
        {
            bool bit1 = register[0];
            bool bit2 = register[register.Length - SIGN - 1];
            for (int i = 0; i < register.Length; i++)
            {
                if (i == register.Length - 1)
                    register[register.Length - 1] = bit1 ^ bit2;
                else
                    register[i] = register[i + 1];
            }
            return register;
        }

        private BitArray GenerateKey()
        {
            BitArray key = new BitArray(plain.Length);
            for(int i = 0; i < key.Length; i++)
            {
                key [i] = register[0];
                register = GetNextArray(register);
            }
            return key;
        }

        private BitArray GetCipherTextBits()
        {
            BitArray cipherText = new BitArray(plain.Length);
            for (int i = 0; i < plain.Length; i++)
                cipherText[i] = plain[i] ^ key[i];
            return cipherText;
        }



        public byte[] GetCipherText()
        {
            result = GetCipherTextBits();
            int byteLength = (result.Length + 7) / 8;
            byte[] ciphertext = new byte[byteLength];

            for (int i = 0; i < result.Length; i++)
            {
                if (result[i])
                {
                    int byteIndex = i / 8;      
                    int bitIndex = i % 8;       

                    ciphertext[byteIndex] |= (byte)(1 << (7 - bitIndex));
                }
            }
            data = ciphertext;
            return ciphertext;
        }

        public string GetKey()  
        {
            string keyStr = "";
            for (int i = 0; i < key.Length; i++)
            {
                if (key[i])
                    keyStr += "1";
                else
                    keyStr += "0";
            }
            return keyStr;
        }
    }
}
