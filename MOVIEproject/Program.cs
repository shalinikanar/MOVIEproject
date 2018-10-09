using System;
using System.Collections.Generic;
using System.IO;

namespace MOVIEproject
{
    class Moflix
    {
        static void Main(string[] args)
        {
            Moflix moflix = new Moflix();
            
        }

        public Moflix()
        {
            string line;
            string[] values;
            string mprop = "";
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader("C:\\Users\\User\\source\\repos\\MOVIEproject\\MOVIEproject\\MovieDB.txt");

                //Read the first line of text
                line = sr.ReadLine();
                //Continue to read until you reach end of file
                while (line != null)
                {
                    //write the line to console window
                    values = line.Split(';');
                    for (int i = 0; i < values.Length; i++)
                    {
                        if (i == 0)
                            mprop = "Name:";
                        else if (i == 1)
                            mprop = "Actor:";
                        else if (i == 2)
                            mprop = "Genre:";
                        else if (i == 3)
                            mprop = "Director:";

                        Console.WriteLine(mprop + values[i]);
                    }

                    Console.WriteLine("================================");
                    line = sr.ReadLine();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");

            }




            //C:\Users\User\source\repos\MOVIEproject\MOVIEproject
        }


    }
}
