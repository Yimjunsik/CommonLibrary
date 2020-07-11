using System;
using CommonLibrary.Tools;
using CommonLibrary.Extensions;

namespace CommonLibraryTest
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            #region 1.

            ////LogManager log = new LogManager();
            //LogManager log = new LogManager(null, "_CommonLibraryTest");

            //log.WriteLine("[Begin Processing]-----");

            //for (int index = 0; index < 10; index++)
            //{
            //    log.WriteLine("Processing : " + index);

            //    System.Threading.Thread.Sleep(500);

            //    log.WriteLine("Done : " + index);
            //}

            //log.WriteLine("[End Processing]-----");

            ////Console.WriteLine(CommonLibrary.Tools.Application.Root);
            ////Console.ReadLine();

            #endregion


            #region 2. 확장 메서드

            //LogManager log = new LogManager();
            //log.WriteConsole("Test");

            #endregion


            #region 3. String 확장 메서드 테스트

            //string temp = "test";
            //string temp = "123123";
            string temp = "12/08/2015 10:10";

            Console.WriteLine("IsNumeric? : " + temp.IsNumeric());
            Console.WriteLine("IsDateTime? : " + temp.IsDateTime());

            #endregion
        }
    }

    public static class ExtensionTest
    {
        // 확장 메서드
        public static void WriteConsole(this LogManager log, string data)
        {
            log.Write(data);
            Console.Write(data);
        }
    }
}
