using System;

namespace AngryMonkeyTestMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            AngryMonkey.AccessTest.AccessRight[] enums = new AngryMonkey.AccessTest.AccessRight[] { AngryMonkey.AccessTest.AccessRight.Read, AngryMonkey.AccessTest.AccessRight.Update };
            Console.WriteLine(AngryMonkey.AccessTest.HasAccess(enums, AngryMonkey.AccessTest.AccessRight.Full));
            Console.ReadKey();
        }
    }
}