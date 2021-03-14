using System;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {

            #region int  byte double float decimal

            //int intMinVal, a, b;
            ////int intMinVal = int.MinValue;
            //intMinVal = int.MinValue;
            //Console.WriteLine("min val :{0}",intMinVal);

            //int intMaxVal = int.MaxValue;
            //Console.WriteLine(intMaxVal);



            //int x1 = 10;

            //string user_name_surname = "Parviz";

            //char choise = 'A';


            //// tuple
            //(int a, int b) c= (5, 10);
            //Console.WriteLine(c.a);
            //Console.WriteLine(c.b);

            //// c# 7.o literals
            //ulong num1= 18_446_744_073_709_551_615;

            #endregion

            #region string

            string groupName = "CSharp-02";
            string courseName = "Pragmatech";
            string email = "kanan@pragmatech.az";

            Console.WriteLine(groupName.ToLower());
            Console.WriteLine(groupName.ToUpper());
            Console.WriteLine(groupName.Substring(0,6));



            #endregion

            #region object




            #region boxing
            //int number1 = 100;
            //object number2 = number1;
            #endregion

            #region unBoxing

            //string name = "Zaur";
            //object _name = "Zaur";

            //object age = 28;

            //int _age = (int) age;




            #endregion

            #endregion

            #region var , dynamic

            //var name = "Kamran";

            //object _name = "Kamran";
            ////_name.
            //    name.

            dynamic age = 20;

            #endregion
        }


    }
}
