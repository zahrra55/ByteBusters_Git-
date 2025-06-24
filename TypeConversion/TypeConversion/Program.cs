using System;

namespace TypeConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte ByteNum1 = 1;
            int IntNum1 = ByteNum1;
            Console.WriteLine(IntNum1);

            Console.WriteLine("===============");
            /* int IntNum2 = 1;
            byte ByteNum2 = IntNum2; */
            // WE SHOULD DO CAST

            int IntNum2 = 2;
            byte ByteNum2 = (byte)IntNum2;
            Console.WriteLine(ByteNum2);

            Console.WriteLine("===============");

            //Look what happpen when u make it 1000
            int IntNum1000 = 2000;
            byte ByteNum1000 = (byte)IntNum1000;
            Console.WriteLine(ByteNum1000);
            // the compiler will take only last 8 bits (السفلي)

            Console.WriteLine("===============");

            /* var number = "12345"; //string
            int String2Int = (int)number; */
            // we will see error says we cant cast string to an integer

            var number = "12345"; //string
            int String2Int = Convert.ToInt32(number);
            Console.WriteLine(String2Int);
            Console.WriteLine("===============");
    

            try
            {
                byte String2Byte = Convert.ToByte(number);
                Console.WriteLine(String2Byte);
            }
            catch (Exception)
            {
                Console.WriteLine("Cannot be converted to a byte");
               //throw; i will explain it in my advanced corse nnnnn 
            }
            Console.WriteLine("===============");
            try
            {
                string str = "true";
                bool b = Convert.ToBoolean(str);
                Console.WriteLine(b);

            }
            catch (Exception)
            {
                Console.WriteLine("Cannot be converted to a byte");
            }


           

        }
    }
}
