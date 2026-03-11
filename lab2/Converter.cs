using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    internal class Converter
    {

        public static byte[] GetBytes(string text)  
        {
            byte[] bytes = Encoding.UTF8.GetBytes(text);
            return bytes;
        }

        public static BitArray GetBits(string text)
        {
            BitArray bitArray = new BitArray(text.Length);
            for (int i = 0; i < text.Length; i++)
                bitArray[i] = text[i] == '1';
            return bitArray;
        }

        public static string GetExtension(string fileName)
        {
            string ext = "";
            bool extFlag = false;
            for (int i = 0; i < fileName.Length; i++)
            {
                if (fileName[i] == '.')
                    extFlag = true;
                if (extFlag)
                    ext += fileName[i]; 
            }
            return ext;
        }

        public static string GetStringByBytes(byte[] bytes)
        {
            string str = "";
            for (int i = 0; i < bytes.Length; i++)
                str += Convert.ToString(bytes[i], 2).PadLeft(8, '0');
            return str;
        }

        public static string GetCorrectString(string text)
        {
            string str = "";
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '1' || text[i] == '0')
                    str += text[i];
            }
            return str;
        }
    }
}
