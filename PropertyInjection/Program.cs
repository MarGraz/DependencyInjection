using System;
using static PropertyInjection.EsempioTre;

namespace PropertyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            Account SavingAccount = new Account();
            //Inizializzo all'interno della proprietà MyAccount, la classe SavingAccount, in questo modo avrò disponibile il metodo PrintAccounts()
            SavingAccount.MyAccount = new SavingAccount();
            SavingAccount.PrintAccounts();

            Account CurrentAccount = new Account();
            CurrentAccount.MyAccount = new CurrentAccount();
            CurrentAccount.PrintAccounts();

            Console.ReadLine();
        }
    }
}
