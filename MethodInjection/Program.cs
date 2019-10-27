using System;
using static MethodInjection.EsempioQuattro;

namespace MethodInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            Account Account = new Account();

            //E' sufficiete richiamare il metodo PrintAccount e passargli come argomento un nuovo oggetto che implementa IAccount per ottenere la stampa dell'account
            Account.PrintAccount(new SavingAccount());
            Account.PrintAccount(new CurrentAccount());

            Console.ReadLine();
        }
    }
}
