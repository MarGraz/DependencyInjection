using System;
using System.Collections.Generic;
using System.Text;

namespace MethodInjection
{
    internal class EsempioQuattro
    {
        //Non cambia nulla rispetto al secondo e terzo esempio
        public interface IAccount
        {
            void PrintData();
        }

        //Non cambia nulla rispetto al secondo e terzo esempio
        public class SavingAccount : IAccount
        {
            public void PrintData()
            {
                Console.WriteLine("Salvataggio dei dati dell'account");
            }
        }

        //Non cambia nulla rispetto al secondo e terzo esempio
        public class CurrentAccount : IAccount
        {
            public void PrintData()
            {
                Console.WriteLine("Il tuo attuale account");
            }
        }

        public class Account
        {
            //Rispetto al terzo esempio di PropertyInjection, qui non viene usata una proprietà per iniettare IAccount, ma IAccount è passato come argomento ad un metodo. L'oggetto MyAccount che sarà valorizzato come SavingAccount o CurrentAccount, potrà richiamare il metodo PrintData()
            public void PrintAccount(IAccount MyAccount)
            {
                MyAccount.PrintData();
            }
        }
    }

}
