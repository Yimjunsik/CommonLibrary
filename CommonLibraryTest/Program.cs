using System;
using CommonLibrary.Tools;

namespace CommonLibraryTest
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //LogManager log = new LogManager();
            LogManager log = new LogManager(null, "_CommonLibraryTest");

            log.WriteLine("[Begin Processing]-----");

            for (int index = 0; index < 10; index++)
            {
                log.WriteLine("Processing : " + index);

                System.Threading.Thread.Sleep(500);

                log.WriteLine("Done : " + index);
            }

            log.WriteLine("[End Processing]-----");

            //Console.WriteLine(CommonLibrary.Tools.Application.Root);
            //Console.ReadLine();

        }
    }
}
