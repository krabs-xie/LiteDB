﻿using LiteDB;
using LiteDB.Engine;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static LiteDB.Constants;

namespace LiteDB.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            for (var i = 1; i <= 50; i++)
            {
                var sw = new Stopwatch();

                //TestMemoryFile.Run(sw);
                //TestAesEncryption.CreateEncryptedFile(sw);
                //TestAesEncryption.ReadEncryptedFile(sw);
                //TestDataPage.Run(sw);
                TestEngine.Run(sw);

                Console.WriteLine($">>> ({i}) - Elapsed: [[[ {sw.ElapsedMilliseconds} ]]]");

            }

            Console.WriteLine("===========================================================");
            Console.WriteLine("End");
            Console.ReadKey();

        }
    }

}
