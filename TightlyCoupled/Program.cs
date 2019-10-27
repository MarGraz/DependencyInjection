using System;
using static TightlyCoupled.EsempioUno;

namespace TightlyCoupled
{
    class Program
    {

        static void Main(string[] args)
        {
            Account Account = new Account();
            Account.PrintAccounts();
            Console.ReadLine();
        }
    }
}
