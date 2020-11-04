using System;
using System.Linq.Expressions;

namespace Metod
{
    class Program
    {
        static void Main(string[] args)
        {
            string typpe="";
            object type = "";
           string arg = Console.ReadLine();
            GetType(arg,type,typpe);
        }
        static void GetType( string arg, object type, string typpe)
        {


            sbyte SButeArg;
            byte ButeArg;
            short ShortArg;
            ushort UShortArg;
            uint UIntArg;
            int IntArg;
            long LongArg;
            ulong ULongArg;
            double DoubleArg;
            float FloatArg;
            char CharArg;


            bool SButeType = sbyte.TryParse(arg, out SButeArg);
            bool ButeType = byte.TryParse(arg, out ButeArg);
            bool ShortType = short.TryParse(arg, out ShortArg);
            bool UShortType = ushort.TryParse(arg, out UShortArg);
            bool UIntType = uint.TryParse(arg, out UIntArg);
            bool IntType = int.TryParse(arg, out IntArg);
            bool ULongType = ulong.TryParse(arg, out ULongArg);
            bool LongType = long.TryParse(arg, out LongArg);
            bool FloatType = float.TryParse(arg, out FloatArg);
            bool DoubleType = double.TryParse(arg, out DoubleArg);
            bool CharType = char.TryParse(arg, out CharArg);







            switch (true)
            {

                case true when SButeType:
                    type = SButeArg.GetType();
                    break;
                case true when ButeType:
                    type = ButeArg.GetType();
                    break;

                case true when  UShortType:
                    type =  ShortArg.GetType();
                    break;
                case true when ShortType:
                    type = ShortArg.GetType();
                    break;
                case true when UIntType:
                    type = UIntArg.GetType();
                    break;
                case true when IntType:
                    type = IntArg.GetType();
                    break;

                case true when ULongType:
                    type = ULongArg.GetType();
                    break;

                case true when LongType:
                    type = LongArg.GetType();
                    break;

                case true when FloatType:
                    type = FloatArg.GetType();
                    break;

                case true when DoubleType:
                    type = DoubleArg.GetType();
                    break;

                case true when CharType:
                    type = CharArg.GetType();
                    break;

                default:
                    type = arg.GetType();
                    break;

            }

             typpe = type.ToString();

            Console.WriteLine($"{arg} is {typpe}"); 
        }
    }
}
