using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            int D1, D2, M1 = 0, M2 = 0, monthday = 0;
            double Y1, Y2;
            string month1, month2, season = " ";

            while (true)
            {
                // input

                Console.Write("Please enter first day   : ");
                D1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Please enter first month : ");
                month1 = Console.ReadLine();
                Console.Write("Please enter first year  : ");
                Y1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Please enter last day    : ");
                D2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Please enter last month  : ");
                month2 = Console.ReadLine();
                Console.Write("Please enter last year   : ");
                Y2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();

                switch (month1)
                {
                    case "January": M1 = 1; break;
                    case "February": M1 = 2; break;
                    case "March": M1 = 3; break;
                    case "April": M1 = 4; break;
                    case "May": M1 = 5; break;
                    case "June": M1 = 6; break;
                    case "July": M1 = 7; break;
                    case "August": M1 = 8; break;
                    case "September": M1 = 9; break;
                    case "October": M1 = 10; break;
                    case "November": M1 = 11; break;
                    case "December": M1 = 12; break;
                }

                switch (month2)
                {
                    case "January": M2 = 1; break;
                    case "February": M2 = 2; break;
                    case "March": M2 = 3; break;
                    case "April": M2 = 4; break;
                    case "May": M2 = 5; break;
                    case "June": M2 = 6; break;
                    case "July": M2 = 7; break;
                    case "August": M2 = 8; break;
                    case "September": M2 = 9; break;
                    case "October": M2 = 10; break;
                    case "November": M2 = 11; break;
                    case "December": M2 = 12; break;
                }

                // controlling all possible errors

                if (Y2 < Y1)
                {
                    Console.WriteLine("The first date must be before the second date.\nPlease wait for a while ...\n");
                    Thread.Sleep(2000);
                    Console.Clear();
                }

                else if (D1 > 31 || D1 <= 0)
                {
                    Console.WriteLine("Day is wrong.\nPlease wait for a while ...\n");
                    Thread.Sleep(2000);
                    Console.Clear();
                }

                else if ((M1 == 4 || M1 == 6 || M1 == 9 || M1 == 11) && D1 > 30)
                {
                    Console.WriteLine("Day is wrong.\nPlease wait for a while ...\n");
                    Thread.Sleep(2000);
                    Console.Clear();
                }

                else if (M1 == 2 && (Y1 % 4 == 0 && D1 > 29) || (Y1 % 4 != 0 && D1 > 28))
                {
                    Console.WriteLine("Day is wrong.\nPlease wait for a while ...\n");
                    Thread.Sleep(2000);
                    Console.Clear();
                }

                else if (M1 != 1 && M1 != 2 && M1 != 3 && M1 != 4 && M1 != 5 && M1 != 6 && M1 != 7 && M1 != 8 && M1 != 9 && M1 != 10 && M1 != 11 && M1 != 12)
                {
                    Console.WriteLine("Month is wrong.\nPlease wait for a while ...\n");
                    Thread.Sleep(2000);
                    Console.Clear();
                }

                else if (D2 > 31 || D2 <= 0)
                {
                    Console.WriteLine("Day is wrong.\nPlease wait for a while ...\n");
                    Thread.Sleep(2000);
                    Console.Clear();
                }

                else if ((M2 == 4 || M2 == 6 || M2 == 9 || M2 == 11) && D2 > 30)
                {
                    Console.WriteLine("Day is wrong.\nPlease wait for a while ...\n");
                    Thread.Sleep(2000);
                    Console.Clear();
                }

                else if (M2 == 2 && (Y2 % 4 == 0 && D2 > 29) || (Y2 % 4 != 0 && D2 > 28))
                {
                    Console.WriteLine("Day is wrong.\nPlease wait for a while ...\n");
                    Thread.Sleep(2000);
                    Console.Clear();
                }

                else if (M2 != 1 && M2 != 2 && M2 != 3 && M2 != 4 && M2 != 5 && M2 != 6 && M2 != 7 && M2 != 8 && M2 != 9 && M2 != 10 && M2 != 11 && M2 != 12)
                {
                    Console.WriteLine("Month is wrong.\nPlease wait for a while ...\n");
                    Thread.Sleep(2000);
                    Console.Clear();
                }

                else
                {
                    break;
                }
                    

            }

            // determining how many months between entered dates 

            double monthnumber = 12 * (Y2 - Y1) + (M2 - M1) + 1;

            // determining season for each month

            if (M1 == 12 || M1 == 1 || M1 == 2)
                season = "Winter";
            if (M1 == 3 || M1 == 4 || M1 == 5)
                season = "Spring";
            if (M1 == 6 || M1 == 7 || M1 == 8)
                season = "Summer";
            if (M1 == 9 || M1 == 10 || M1 == 11)
                season = "Fall";

            // Schwerdtfeger's Method [ w = ( d + e + f + g + Math.Floor(g / 4) ) % 7 ]

            double w, c, g, e = 0, f = 0;

            // determining c, g, e and f to find w (determining of the day of the week)

            if (M1 >= 3)
            {
                c = Math.Floor(Y1 / 100);
                g = Y1 - 100 * c;
            }

            else
            {
                c = Math.Floor((Y1 - 1) / 100);
                g = Y1 - 1 - 100 * c;
            }

            switch (M1)
            {
                case 1: e = 0; break;
                case 2: e = 3; break;
                case 3: e = 2; break;
                case 4: e = 5; break;
                case 5: e = 0; break;
                case 6: e = 3; break;
                case 7: e = 5; break;
                case 8: e = 1; break;
                case 9: e = 4; break;
                case 10: e = 6; break;
                case 11: e = 2; break;
                case 12: e = 4; break;
            }

            switch (c % 4)
            {
                case 0: f = 0; break;
                case 1: f = 5; break;
                case 2: f = 3; break;
                case 3: f = 1; break;
            }

            w = (D1 + e + f + g + Math.Floor(g / 4)) % 7; // for example; if w = 1, first day is monday or if w = 0, first day is sunday

            // output

            for (int i = 1; i <= monthnumber; i++)
            {
                // determining how many days each month

                if (M1 == 1 || M1 == 3 || M1 == 5 || M1 == 7 || M1 == 8 || M1 == 10 || M1 == 12)
                {
                    monthday = 31;
                }

                if (M1 == 4 || M1 == 6 || M1 == 9 || M1 == 11)
                {
                    monthday = 30;
                }

                if (M1 == 2)
                {
                    if (Y1 % 4 == 0)
                    {
                        monthday = 29;
                    }
                    else
                    {
                        monthday = 28;
                    }
                }

                // at the last month, days end with user's input(D2)

                if (Y1 == Y2 && M1 == M2)
                {
                    monthday = D2;
                }

                Console.WriteLine(" \n       " + month1 + "      " + Y1 + "    -    " + season + "\n");
                Console.WriteLine("Mo\tTu\tWe\tTh\tFr\tSa\tSu\n");

                for (int j = 1; j <= (w + 6) % 7; j++)  //spaces at the beginning of months 

                    Console.Write("\t");

                for (int j = D1; j <= monthday; j++)
                {
                    if (j % 7 != ((D1 - w) % 7 + 7) % 7)
                        Console.Write(j + "\t");

                    else
                        Console.WriteLine(j + "\n");
                }
                Console.WriteLine();

                M1++;

                if (M1 % 12 == 1)
                {
                    M1 = 1; Y1++;
                }

                switch (M1)
                {
                    case 1: month1 = "January"; break;
                    case 2: month1 = "February"; break;
                    case 3: month1 = "March"; break;
                    case 4: month1 = "April"; break;
                    case 5: month1 = "May"; break;
                    case 6: month1 = "June"; break;
                    case 7: month1 = "July"; break;
                    case 8: month1 = "August"; break;
                    case 9: month1 = "September"; break;
                    case 10: month1 = "October"; break;
                    case 11: month1 = "November"; break;
                    case 12: month1 = "December"; break;
                }

                if (M1 == 12 || M1 == 1 || M1 == 2)
                    season = "Winter";
                if (M1 == 3 || M1 == 4 || M1 == 5)
                    season = "Spring";
                if (M1 == 6 || M1 == 7 || M1 == 8)
                    season = "Summer";
                if (M1 == 9 || M1 == 10 || M1 == 11)
                    season = "Fall";

                // changing spaces at the beginning of each month 
                w = (w + (monthday - D1) % 7 + 1) % 7;

                // after first month, days start from 1
                D1 = 1;
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
