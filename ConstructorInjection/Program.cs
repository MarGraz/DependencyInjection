using System;
using static ConstructorInjection.EsempioDue;

namespace ConstructorInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ora per richiamare il metodo PrintData delle classi SavingAccount e CurrentAccount, è sufficiente inizializzare una delle due classi come oggetto "IAccount", e passarlo come parametro all'oggetto Account. A sua volta, l'oggetto Account esporrà il metodo PrintAccount che stamperà il risultato
            IAccount SavingAccount = new SavingAccount();
            Account Account = new Account(SavingAccount);
            Account.PrintAccount();

            IAccount CurrentAccount = new CurrentAccount();
            Account = new Account(CurrentAccount);
            Account.PrintAccount();

            Console.ReadLine();         
        }
    }
}
