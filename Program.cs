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

        static int Main(string[] args)
        {
            /* The way the arguments are going to work in this
             * The first one is going to be the directory
             * The second one is the file extension
             * The third one is going to be what the name should be
             */


            //Checking the Directory
            try
            {
                fileDirectory = args[0];
                if ( !Directory.Exists(fileDirectory) )
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


            //TODO: Check the third parameter.
            //Iterate through the folder
                //Change the name if it matches.

            Console.WriteLine(fileExtension);
            Console.ReadLine();
            return 0;
        }
    }
}
