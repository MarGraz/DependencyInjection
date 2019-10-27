using System;
using System.Collections.Generic;
using System.Text;

namespace ConstructorInjection
{
    internal class EsempioDue
    {
        //Rispetto all'esempio uno tightly coupled viene aggiunta l'interfaccia IAccount per rendere le classi meno legate/interdipendenti tra loro. Il metodo PrintData() è ora proprio dell'interfaccia
        public interface IAccount
        {
            void PrintData();
        }

        //SavingAccount ora implementa l'interfaccia IAccount, ed è obbligata ad implementare il metodo PrintData()
        public class SavingAccount : IAccount
        {
            public void PrintData()
            {
                Console.WriteLine("Salvataggio dei dati dell'account");
            }
        }

        //CurrentAccount ora implementa l'interfaccia IAccount, ed è obbligata ad implementare il metodo PrintData()
        public class CurrentAccount : IAccount
        {
            public void PrintData()
            {
                Console.WriteLine("Il tuo attuale account");
            }
        }

        //La classe Account ora non dipende più dalle altre classi, non è costretta ad inizializzare SavingAccount e CurrentAccount
        public class Account
        {
            //Questo campo viene valorizzato dal costruttore di Account
            readonly private IAccount account;

            //Al costruttore viene passata l'interfaccia IAccount che rappresenterà o un oggetto SavingAccount o CurrentAccount
            public Account(IAccount Account)
            {
                this.account = Account;
            }

            public void PrintAccount()
            {
                //PrintData è il metodo implementato nell'interfaccia IAccount
                account.PrintData();
            }
        }
            
    }
}
