﻿//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Test_Max
//{
//    internal class MaxFloat
//    {
//        public static void Main()
//        {
//            MaxFloat f = new MaxFloat();
//            Console.WriteLine(f.maximumValue(10f, 20f, 30f));
//        }
//        public float maximumValue(float firstvalue, float secondvalue, float thirdvalue)
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
//                return 0; ;
//            }

//        }
//    }
//}
