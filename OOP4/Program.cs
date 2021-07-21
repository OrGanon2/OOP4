using System;

namespace OOP4
{
    class Program
    {
        static void Main(string[] args)
        {
            #region ref and out

            #region second
            ////nt a = 5;
            //int b = 2;
            //calculation(ref a, ref b);
            //Console.WriteLine($"a:{a} b: {b}");
            #endregion


            #region third
            //int a;
            //int b;
            //out2(out a, out b);


            #endregion
            #endregion
            #region fourth
            bool ifokey;
            string errorMessage;
            ValidateValues("or", "ganon", "054987656", "203356478", 25,out ifokey,out errorMessage);
            Console.WriteLine(ifokey);
            Console.WriteLine(errorMessage);

            #endregion

        }
        #region second
        //public static void calculation(ref int a ,ref int b)
        //{
        //    a++;
        //    b *= 2;
        //}
        #endregion

        #region third
        //public static void out2(out int a, out int b)
        //{
        //    a = 2;
        //    b = 3;
        //}





        #endregion

        #region fourth
        public static void ValidateValues(string first_name,string last_name ,string phone_number, string ID , int age, out bool ifokey, out string errorMessage)
        {
            ifokey = true;
            errorMessage = "system functional";

            if (string.IsNullOrEmpty(first_name) || string.IsNullOrEmpty(last_name))
            {
                errorMessage = "first name or last name is empty please insert your name and family name ";
                ifokey = false;
            }
            if (phone_number.Length < 9 ||! phone_number.StartsWith("0"))
            {
                errorMessage = "wrong number";
                ifokey = false;

            }
            if (ID.Length < 9 || ID.Length > 9)
            {
                errorMessage = "wrong id";
                ifokey = false;

            }
            if (age > 100 || age < 0)
            {
                errorMessage = "not a vaild age";
                ifokey = false;

            }

        }


        #endregion
    }
}
