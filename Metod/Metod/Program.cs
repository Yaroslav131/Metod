using System;
using System.Linq.Expressions;

namespace Metod
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = "";
            object obj = "";
            string arg = Console.ReadLine();
            GetType(arg, obj, type);
        }
        static void GetType(string arg, object obj, string type)
        {
            sbyte sbuteArg;
            byte buteArg;
            short shortArg;
            ushort ushortArg;
            uint uintArg;
            int intArg;
            long longArg;
            ulong ulongArg;
            double doubleArg;
            float floatArg;
            char charArg;

            bool SButeType = sbyte.TryParse(arg, out sbuteArg);
            bool ButeType = byte.TryParse(arg, out buteArg);
            bool ShortType = short.TryParse(arg, out shortArg);
            bool UShortType = ushort.TryParse(arg, out ushortArg);
            bool UIntType = uint.TryParse(arg, out uintArg);
            bool IntType = int.TryParse(arg, out intArg);
            bool ULongType = ulong.TryParse(arg, out ulongArg);
            bool LongType = long.TryParse(arg, out longArg);
            bool FloatType = float.TryParse(arg, out floatArg);
            bool DoubleType = double.TryParse(arg, out doubleArg);
            bool CharType = char.TryParse(arg, out charArg);

            switch (true)
            {
                case true when SButeType:
                    obj = sbuteArg.GetType();
                    break;
                case true when ButeType:
                    obj = buteArg.GetType();
                    break;
                case true when UShortType:
                    obj = shortArg.GetType();
                    break;
                case true when ShortType:
                    obj = shortArg.GetType();
                    break;
                case true when UIntType:
                    obj = uintArg.GetType();
                    break;
                case true when IntType:
                    obj = intArg.GetType();
                    break;
                case true when ULongType:
                    obj = ulongArg.GetType();
                    break;
                case true when LongType:
                    obj = longArg.GetType();
                    break;
                case true when FloatType:
                    obj = floatArg.GetType();
                    break;
                case true when DoubleType:
                    obj = doubleArg.GetType();
                    break;
                case true when CharType:
                    obj = charArg.GetType();
                    break;
                default:
                    obj = arg.GetType();
                    break;
            }
            type = obj.ToString();
            Console.WriteLine($"{arg} is {type}");
        }
    }
}
