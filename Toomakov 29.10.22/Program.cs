using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Toomakov_29._10._22
{
    public enum BankCurrent
    {
        дебетовый,
        депозитный,
        кредитный

    }
    class Bank
    {
        
        private int id;
        private int balance;
        private BankCurrent name;

        public void Name()
        {
            Console.WriteLine("Выберите какой счет вы бы хотели открыть : " + '\n' + "1) дебетовый" + '\n' + "2) депозитный " + '\n' + "3) кредитный");
            string name1 = Console.ReadLine();
            if (name1 == "дебетовый")
            {
                Console.WriteLine("Вам одобрен " + BankCurrent.дебетовый + " счёт");
            }
            else if(name1 == "епозитный")
            {
                Console.WriteLine("Вам одобрен " + BankCurrent.депозитный + " счёт");
            }
            else if (name1 == "кредитный")
            {
                Console.WriteLine("Вам одобрен " + BankCurrent.кредитный + " счёт");
            }
            else
            {
                Console.WriteLine("Вам не одобрили заявку, так как были введены неверне данные");
            }
        }

        public void ID()
        {
            Console.WriteLine("Введите ID  своего будущего счета : ");
            id = int.Parse(Console.ReadLine());
            Console.WriteLine("Вашему счету присвоен уникальный ID : " + id);
        }
        public void Balance()
        {
            Console.WriteLine("Выберите пункт меню: " + '\n' + "1) Узнать баланс" + '\n' + "2) Пополнить баланс");
            string operation = Console.ReadLine();
            if (operation == "Узнать баланс" || operation == "узнать баланс" || operation == "УЗНАТЬ БАЛАНС")
            {
                Console.WriteLine("Ваш баланс : " + balance);

            }

             if (operation == "Пополнить баланс" || operation == "пополнить баланс" || operation == "ПОПОЛНИТЬ БЛАНАС")
            {
                Console.WriteLine("Введите сумму ,которую хотели бы внести на счет");
                int summ = int.Parse(Console.ReadLine());
                balance = summ;
                Console.WriteLine("Вы внесли " + summ + " на счет");
            }


        }
    }
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Bank bank = new Bank();
            bank.Name();
            bank.ID();
            bank.Balance();
            


        }
    }
}
