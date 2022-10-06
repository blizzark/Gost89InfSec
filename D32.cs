﻿using System;

namespace WinGost
{
    /// <summary>
    /// Дешефратор
    /// </summary>
    class D32 : Converter
    {
        byte[] decrByteFile;
        uint[] uintKey;
        ulong[] ulongFile;

        private D32() { }

        public D32(byte[] file, byte[] key)
        {
            uintKey = GetUIntKeyArray(key);
            ulongFile = GetULongDataArray(file);
            
            decrByteFile = ConvertToByte(DecryptFile());
        }

        public byte[] GetDecryptFile
        {
            get { return decrByteFile; }
        }

        private ulong[] DecryptFile()
        {
            BasicStep[] K = new BasicStep[8];
            ulong[] ulongDecrFile = new ulong[ulongFile.Length];
            //цикла дешифрования
            for (int k = 0; k < ulongFile.Length; k++)
            {
                ulongDecrFile[k] = ulongFile[k];

                for (int i = 0; i <= 7; i++)
                {
                    K[i] = new BasicStep(ulongDecrFile[k], uintKey[i]);
                    ulongDecrFile[k] = K[i].BasicEncrypt(false);
                }

                for (int j = 0; j < 3; j++)
                {
                    for (int i = 7; i >= 0; i--)
                    {
                        K[i] = new BasicStep(ulongDecrFile[k], uintKey[i]);

                        if ((j == 2) && (i == 0))
                            ulongDecrFile[k] = K[i].BasicEncrypt(true);
                        else
                            ulongDecrFile[k] = K[i].BasicEncrypt(false);
                    }
                }
            }

            return ulongDecrFile;
        }
    }
}