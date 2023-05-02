namespace Test_Max
{
    internal class maximum
    {
        public static void Main()
        {
            maximum max = new maximum();
            Console.WriteLine(max.maximumValue(10, 20, 30));

        }
        public int maximumValue(int firstvalue, int secondvalue, int thirdvalue)
        {
            if (firstvalue.CompareTo(secondvalue) > 0 && (firstvalue.CompareTo(thirdvalue) > 0))
            {
                return firstvalue;
            }
            else if (secondvalue.CompareTo(firstvalue) > 0 && (secondvalue.CompareTo(thirdvalue) > 0))
            {
                return secondvalue;
            }
            else if (thirdvalue.CompareTo(firstvalue) > 0 && (thirdvalue.CompareTo(secondvalue) > 0))
            {
                return thirdvalue;
            }
            else
            {
                return 0; ;
            }

        }
    }
}