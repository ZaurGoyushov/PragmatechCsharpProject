using System;

namespace Week4.Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            #region tasks

            #region 1.
            /*
             * asagida verilen arrayin elementlerini artan sira ile
             * ekrana cap edin
             *
             * qeyd : manual edilecek/ hazir methodlarsiz
             */
            //int[] intArray = { 2, 9, 4, 3, 5, 1, 7 };

         

            #endregion

            #region 2.
            /*
             * asagida verilen arrayin elementlerini azalan sira ile
             * ekrana cap edin
             *
             * qeyd : manual edilecek/ hazir methodlarsiz
             */
            //int[] intArray = { 2, 9, 4, 3, 5, 1, 7 };



            #endregion

            #region 3. geriden geriden
            /*
             * asagida verilen arrayin elementlerini tersine duzerek
             * ekrana cap edin
             *
             * qeyd : manual edilecek/ hazir methodlarsiz
             */
            //int[] arr = { 5, 6, 9, 12, 15, 7, 3, 20, 14, 36, 24 };

            #endregion

            #region 4. para pul el cirki
            /*
             * istifadeci bankomatdan cixarmaq istediyi meblegi daxil edir(sonsuz sayda, emeliyyati dayandirmagida nezere alin).
             * daxil edilen meblege uygun console-a eskinaslari sayi ile cap edirik.
             *
             * eskinaslar : 200, 100, 50, 20, 10, 5, 1
             *
             * meselen daxil edilen pul miqdari 45 dir:
             * 2 eded 20 azn
             * 1 eded 5 azn
             *
             */
            //-------------------------- Solution
            /*
             while (true)
            {
                int[] Valyuta = new int[7] { 200, 100, 50, 20, 10, 5, 1 }; //Array kimi teyin edende error verir
                Console.Write(" Meblegi daxil edin : ");
                string Reader = Console.ReadLine();
                if (Reader == "" || Reader==" "){
                
                        Console.WriteLine("mebleği düzgün daxil edin"); 
                }
                               
                else
                {       int Pul=int.Parse(Reader);
                        for (int i = 0; i < Valyuta.Length; i++)
                        {
                            if (Pul >= Valyuta[i])
                            {
                                int bankNotesCount = Pul / Valyuta[i];
                                Pul -= bankNotesCount * Valyuta[i];
                                Console.WriteLine(bankNotesCount + " - " + Valyuta[i]);
                            }
                        }
                }
            }
            */

            #endregion

            #region 5. tek ededlerin kublari cemi
            /*
             * 1-10 qeder tek ededlerin kublarinin cemini yazin.
             */


            #endregion

            #region 6. yas hesablanmasi
            /*
             * dogum tarixini daxil eden istifedecinin
             * yasini hesablayib ekrana cap edin
             */


            #endregion

            #region 7.
            /*
             * istifadeci terefinden daxil edilen iki musbet ededin hasilini vurma emeliyyati ile
             * deyil toplama emeliyyati ile ekrana cap edin.
             */


            #endregion
            #endregion
        }
    }
}
