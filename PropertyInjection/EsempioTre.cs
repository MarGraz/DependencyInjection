using System;
using System.Collections.Generic;
using System.Text;

namespace PropertyInjection
{
    internal class EsempioTre
    {
        //Non cambia nulla rispetto il secondo esempio di Constructor Injection
        public interface IAccount
        {
            void PrintData();
        }

        //Non cambia nulla rispetto il secondo esempio di Constructor Injection
        public class SavingAccount : IAccount
        {
            public void PrintData()
            {
                Console.WriteLine("Salvataggio dei dati dell'account");
            }
        }

        //Non cambia nulla rispetto il secondo esempio di Constructor Injection
        public class CurrentAccount : IAccount
        {
            public void PrintData()
            {
                Console.WriteLine("Il tuo attuale account");
            }
        }

        public class Account
        {
            //IAccount non viene più passata come parametro al costruttore, ma è una proprietà. IAccount una volta inizializzata rappresenterà una delle classi "SavingAccount" o "CurrentAccount"
            public IAccount MyAccount { get; set; }

            public void PrintAccounts()
            {
                MyAccount.PrintData();
            }
        }
    }
}
