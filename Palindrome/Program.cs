using System;

namespace Palindrome
{
    public class Palindrome
    {
        public String original;
        public String reversed;



        public void test_palindrome( String input_data)
        {
            this.original = input_data.Trim();
            this.original = input_data.ToLower();
            reversed = "";

            for ( int i = original.Length - 1; i>=0  ; i--)
            {
                reversed += original[i];
            }
            test_result();
        }

        public void test_result()
        {
            if (original == reversed)
            {
                System.Console.WriteLine("This is Palindrome");
            }
            else
            {
                System.Console.WriteLine("This is NOT Palindrome");
            }
        }





        public static void Main (String [] args)
        {
            Palindrome p = new Palindrome();
            p.test_palindrome("saippuakivikauppias");
        }
    }
}