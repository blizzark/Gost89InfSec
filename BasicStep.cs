using System;

namespace WinGost
{
    struct BasicStep
    {
        uint N1, N2, X;

        public BasicStep(ulong dateFragment, uint keyFragment)
        {
            N1 = (uint)(dateFragment >> 32);
            N2 = (uint)((dateFragment << 32) >> 32);
            X = keyFragment;
        }

        public ulong BasicEncrypt(bool IsLastStep)
        {
            return (FourthAndFifthStep(IsLastStep, ThirdStep(SecondStep(FirstStep()))));
        }
        // Сложение с ключом. Младшая половина преобразуемого блока складывается по модулю 2^32 
        //с используемым на шаге элементом ключа, результат передается на следующий шаг
        private uint FirstStep()
        {
            return (uint)((X + N1) % (Convert.ToUInt64(Math.Pow(2, 32))));
        }
        //Поблочная замена. 32-битовое значение, полученное на предыдущем шаге, 
        //интерпретируется как массив из восьми 4-битовых блоков кода S=(S0,S1,S2,S3,S4,S5,S6,S7).
        //Производится замена по таблице
        private uint SecondStep(uint S)
        {
            uint newS, S0, S1, S2, S3, S4, S5, S6, S7;

            S0 = S >> 28;
            S1 = (S << 4) >> 28;
            S2 = (S << 8) >> 28;
            S3 = (S << 12) >> 28;
            S4 = (S << 16) >> 28;
            S5 = (S << 20) >> 28;
            S6 = (S << 24) >> 28;
            S7 = (S << 28) >> 28;

            S0 = ReplacementTable.Table0[S0];
            S1 = ReplacementTable.Table0[0xA + S1];
            S2 = ReplacementTable.Table0[0xB + S2];
            S3 = ReplacementTable.Table0[0xC + S3];
            S4 = ReplacementTable.Table0[0xD + S4];
            S5 = ReplacementTable.Table0[0xE + S5];
            S6 = ReplacementTable.Table0[0xF + S6];
            S7 = ReplacementTable.Table0[0x16 + S7];

            newS = S7 + (S6 << 4) + (S5 << 8) + (S4 << 12) + (S3 << 16) +
                    (S2 << 20) + (S1 << 24) + (S0 << 28);

            return newS;
        }
        //Циклический сдвиг на 11 бит влево.
        private uint ThirdStep(uint S)
        {
            return (uint)(S << 11) | (S >> 21);
        }
        //Побитовое сложение и Сдвиг по цепочке 
        //Полученное значение преобразуемого блока возвращается 
        //как результат выполнения ал-горитма основного шага криптопреобразования.
        private ulong FourthAndFifthStep(bool IsLastStep, uint S)
        {
            ulong N;

            S = (S ^ N2);

            if (!IsLastStep)
            {
                N2 = N1;
                N1 = S;
            }
            else
                N2 = S;

            N = ((ulong)N2) | (((ulong)N1) << 32); // Побитовое ИЛИ (or)

            return N;
        }
    }
}