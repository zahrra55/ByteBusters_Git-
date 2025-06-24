namespace string_mainpulation_husain
{
    internal class Program
    {



        //  1. Write C# Sharp program to demonstrate that the Compare(String, String, Boolean)
        //  method is equivalent to using ToUpper or ToLower when comparing strings. Expected Output :

        //  to solve this problem we use math.max methode to find the bigger number between first and second number
        //  then find the bigger between the third and the previos bigger 




        static void Main(string[] args)
        {
            //  identifying the three numbers 
            int num1 = 1;
            int num2 = 2;
            int num3 = 3;



            //  biggest of first and second number 
            var biggernumber_Between_1and2 = Math.Max(num1, num2);

            //  the biggest third and prev biggest (the bigger number of all three)
            var biggernumber = Math.Max(biggernumber_Between_1and2, num3);

            //output
            Console.WriteLine(biggernumber);



        }
    }
}
