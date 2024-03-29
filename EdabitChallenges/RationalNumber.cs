﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edabit
{
    /// <summary>
    /// https://edabit.com/challenge/A4XwAhZbYRkSqyrbw
    /// </summary>
    public struct RationalNumber
    {
        public int[] control = { 2, 3, 5, 7, 11, 13};
        public int Numerator { get; set; }
        public int Denominator { get; set; }
        public RationalNumber(int Numerator,int Denominator)
        {
            this.Numerator = Numerator;
            this.Denominator = Denominator;
        }

        public override string ToString()
        {
            int[] data = Calc(this.Numerator, this.Denominator);
            if (this.Denominator == 0) throw new ArgumentException("hata");
            if (data[0] > data[1] && data[0] % data[1] == 0) return(data[0] / data[1]).ToString();
            return data[0] + "/" + data[1];
        }

        public int[] Calc(int numerator, int denominator)
        {
            
            bool controls=false;
            int num = numerator;
            int den = denominator;
            for (int i = 0; i < control.Length; i++)
            {
                if(num % control[i]==0 && den % control[i]==0)
                {
                    den = den / control[i];
                    num = num / control[i];
                    controls = true;
                }
            }
            return controls ? Calc(num, den) : new int[]{ num, den };
        }

       
    }

     
}
