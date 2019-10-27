using System;

namespace TightlyCoupled
{
    internal class EsempioUno
    {
        public class SavingAccount
        {
            public void PrintData()
            {
                Console.WriteLine("Salvataggio dei dati dell'account");
            }
        }

        public class CurrentAccount
        {
            public void PrintData()
            {
                Console.WriteLine("Il tuo attuale account"); 
            }
        }

        //Questa classe Account è tightly couple, ossia fortemente legata alle altre. E' necessario creare sempre l'istanza di SavingAccount e CurrentAccount per poter chiamare il metodo PrintData() che hanno in comune le due classi. Questo è fortemente sconsigliato, perché in progetti più grandi e complessi comporterà che una singola modifica su una classe print, si ripercuote su tutte le altre classi, e sarà necessario maggiore lavoro
        public class Account
        {
            //Per chiamare il metodo PrintData() è necessario istanziare SavingAccount
            SavingAccount SavingAccount = new SavingAccount();

            //Per chiamare il metodo PrintData() è necessario istanziare CurrentAccount
            CurrentAccount CurrentAccount = new CurrentAccount();

            public void PrintAccounts()
            {
                SavingAccount.PrintData();
                CurrentAccount.PrintData();
            }
        }
    }
}
