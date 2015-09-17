using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FileRenamer
{
    class Program
    {
        private static string fileDirectory;
        private static string fileExtension;
        private static string newFilePrefix;

        private static int rename(string fD, string fE, string fP)
        {
            fD += @"\";
            int i = 0;
            var filesMatched = Directory.EnumerateFiles(fD, "*" + fE);
            int preceedingZeros = filesMatched.Count<String>().ToString().Length;
            foreach (String file in filesMatched)
            {
                string oldFileName = file.Substring(fD.Length);
                string newFileName = fP + i.ToString("D"+preceedingZeros.ToString()) + fE;
                File.Move(fD + oldFileName, fD + newFileName);
                i++;
                
            }
            return filesMatched.Count<String>();
        }



        static int Main(string[] args)
        {
            /* The way the arguments are going to work in this
             * The first one is going to be the directory
             * The second one is the file extension
             * The third one is going to be what the prefix should be
             */

            //Declaring Variables
            int num = 0;

            if (args.Length == 0)
            {
                Console.WriteLine("\nWelcome to File Renamer\n\n" +
                    "To use this program, please specify the working directory, the file extension \n" +
                    "you would like to change, and the desired prefix.");
            }
            else
            {
                //Checking the Directory
                try
                {
                    fileDirectory = args[0];
                    if (!Directory.Exists(fileDirectory))
                    {
                        throw new DirectoryNotFoundException();
                    }
                }
                catch (IndexOutOfRangeException e) //To catch when the directory was not provided
                {
                    Console.WriteLine("Error: Directory was not provided, proceeding with current directory");
                    fileDirectory = Directory.GetCurrentDirectory();
                }
                catch (DirectoryNotFoundException e) //To catch the directory not existing.
                {
                    Console.WriteLine("The directory '" + fileDirectory + "' does not exist\n" +
                        "Proceeding with current directory");
                    fileDirectory = Directory.GetCurrentDirectory();
                }

                //Checking the second parameter
                try
                {
                    fileExtension = args[1];

                    //If the extension doesn't have an inital period, add it.
                    //If it does, no need to add it.
                    if (fileExtension.IndexOf('.') == -1)
                    {
                        fileExtension = fileExtension.Insert(0, ".");
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("No file extension provided.");
                    return -1; //Quits the program with error.

                }


                //Checking the third parameter
                try
                {
                    newFilePrefix = args[2];
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("No prefix specified.");
                    return -2;
                }


                try
                {
                    num = rename(fileDirectory, fileExtension, newFilePrefix);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                Console.WriteLine("{0} files renamed", num);
            }
            return 0;
        }
    }
}
