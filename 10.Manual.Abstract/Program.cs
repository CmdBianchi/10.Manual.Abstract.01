using System;
using System.Collections.Generic;
using Entitites;

namespace _10.Manual.Abstract {
    class Program {
        static void Main(string[] args) {
            List<Account> list = new List<Account>();
            /* Metodo Abstrato não pode ser instaciado, deve - se estaciar direto os submetodos. 
             Assim devese usar as subclasses diretamente, o METODO ABSTRAT não permite. */

            list.Add(new SavingsAccount(1001, "Alex", 500.00, 0.01)); /
            list.Add(new BusinessAccount(1002, "Maria", 500.0, 400.0));
            list.Add(new SavingsAccount(1004, "Bob", 500.0, 0.01));
            list.Add(new BusinessAccount(1005, "Anna", 500.0, 500.0));

            double sum = 0.0;
            foreach (Account acc in list) {
                sum += acc.Balance;
            }

            Console.WriteLine("Total balance: " + sum.ToString("F2"));

            foreach (Account acc in list) {
                acc.Withdraw(10.0);
            }
            foreach (Account acc in list) {
                Console.WriteLine("Updated balance for account "
                    + acc.Number
                    + ": "
                    + acc.Balance.ToString("F2"));
            }
        }
    }
}
