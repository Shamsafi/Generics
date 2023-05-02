//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Test_Max
//{
//    internal class MaxString
//    {
//        public static void Main()
//        {
//            MaxString S = new MaxString();
//            Console.WriteLine(S.maximumValue("ABC", "Abv", "Abcdef"));

//        }
//        public string maximumValue(string firstvalue, string secondvalue, string thirdvalue)
//        {
//            if (firstvalue.CompareTo(secondvalue) > 0 && (firstvalue.CompareTo(thirdvalue) > 0))
//            {
//                return firstvalue;
//            }
//            else if (secondvalue.CompareTo(firstvalue) > 0 && (secondvalue.CompareTo(thirdvalue) > 0))
//            {
//                return secondvalue;
//            }
//            else if (thirdvalue.CompareTo(firstvalue) > 0 && (thirdvalue.CompareTo(secondvalue) > 0))
//            {
//                return thirdvalue;
//            }
//            else
//            {
//                return " ";
//            }

//        }
//    }
//}
