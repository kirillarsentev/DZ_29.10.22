using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace DZ_29._10._22
{


    abstract class Dogs
    {
        private string name;
        public void Getname(string name)
        {
            this.name = name;
        }
       
    }

    class Dalmatian : Dogs
    {

        public Dalmatian(string name)
        {
            base.Getname(name);
            Console.WriteLine("Порода собаки : " + name);
        }
        string info = "Далматины — грациозные собаки среднего размера с гладким мускулистым телом.";
        public Dalmatian(int num)
        { 
            Console.WriteLine(info);
        }


        private int dal_count;
        private int walk_count;
        private int sleep_count;
        private int sick_count;

        public int Dal_count
        {
            get { return dal_count; }
            set { dal_count = value; }
        }
        public int Walk
        {
            get { return walk_count; }
            set { walk_count = value; }
        }
        public int Sleep_count
        {
            get { return sleep_count; }
            set { sleep_count = value; }
        }
        public int Sick_count
        {
            get { return sick_count; }
            set { sick_count = value; }
        }

        public void Dal_walk()
        {
            Console.WriteLine(walk_count + " долматинцев гуляет");
        }
        public void Dal_sleep()
        {
            Console.WriteLine(sleep_count + " долматинцев спит");
        }
        public void Dal_sick()
        {
            Console.WriteLine(sick_count + " долматинцев болеет");
        }
         
        public void Eat()
        {
            Console.WriteLine("В приюте " + dal_count + " долматинец");
            Console.WriteLine("Сколько долмантинцев вы хотите накормить?");
            int count = int.Parse(Console.ReadLine());
            Console.WriteLine(dal_count - count + " долматинцев умерло от голода");
        }
        public void Stroll()
        {
            Console.WriteLine("Сколько долматинцев вы хотите выгулять?");
            int count = int.Parse(Console.ReadLine());
            Console.WriteLine(dal_count - count + " долматинцев умерло от скуки");
        }


    }
    class Poodle : Dogs
    {

        public Poodle(string name)
        {
            base.Getname(name);
            Console.WriteLine("Порода собаки : " + name);
        }
        string info = "Пудель – одна из самых добрых и послушных собак. Обладает незаурядным умом, выдающимся обонянием, слухом и зрением.";
        public Poodle(int num)
        {
            Console.WriteLine(info);
        }




        private int pood_count ;
        private int walk_count;
        private int sleep_count;
        private int sick_count;

        public int Pood_count
        {
            get { return pood_count; }
            set { pood_count = value; }
        }
        public int Walk
        {
            get { return walk_count; }
            set { walk_count = value; }
        }
        public int Sleep_count
        {
            get { return sleep_count; }
            set { sleep_count = value; }
        }
        public int Sick_count
        {
            get { return sick_count; }
            set { sick_count = value; }
        }
        public void Pood_walk()
        {
            Console.WriteLine(walk_count + " пуделей гуляет");
        }
        public void Pood_sleep()
        {
            Console.WriteLine(sleep_count + " пуделей спит");
        }
        public void Pood_sick()
        {
            Console.WriteLine(sick_count + " пуделей болеет");
        }
        public void Weasel()
        {
            Console.WriteLine("Сколько пуделей вы хотите погладить?");
            int count = int.Parse(Console.ReadLine());
            Console.WriteLine(pood_count - count + " пуделей умерло от недостатка ласки");
        }

        public void Wash()
        {
            Console.WriteLine("Сколько пуделей вы хотите помыть?");
            int count = int.Parse(Console.ReadLine());
            Console.WriteLine(pood_count - count + " остались грязными");

        }

    }

    class Guard
    {
        private string firstname;
        private string lastname;
        private int age;
        private string job;
        public string Firstname
        {
            get { return firstname; }
            set { firstname = value; }
        }
        public string Lastname
        {
            get { return lastname; }
            set { lastname = value; }
        }
        public string Job
        {
            get { return job; }
            set { job = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public void PrintInfo()
        {
            
            Console.WriteLine("За порядок в приюте отвечает сотрудник,которого зовут " + firstname + " " + lastname);
            Console.WriteLine("Возраст: " + age);
            Console.WriteLine(firstname + " " + lastname + " работает на должности : " + job);  
        }

        public void Order()
        {
            Console.WriteLine(job + " " + firstname + " " + lastname + " внимательно следит за порядком ");
        }
        public void Сameras()
        {
            Console.WriteLine(job + " " + firstname + " проверяет камеры видеонаблюдения");
        }

        public void Criminal()
        {
            Console.WriteLine("Выберите заметит ли в камере видеонаблюдения нарушителя? да/нет");
            string a = Console.ReadLine();
            if(a == "да"  || a == "Да")
            {
                Console.WriteLine(job + " " + firstname + " заметил и прогнал нарушителя,который пытался накормить всех собак");
            }
            else if ( a == "нет" || a == "Нет")
            {
                Console.WriteLine(firstname +" не заметил нарушителя и он всё же смог пробраться в приют и накормить всех собак");
            }
        }

        public void GuardWork()
        {

            Console.WriteLine("Выберите уровень алкоголизма охранника от 0 - закодированный до 10 - алкаш");
            int level = int.Parse(Console.ReadLine());
            if (level < 5)
            {
                Console.WriteLine("Охранник " + firstname + " наелся и спит");

            }
            else
            {
                Console.WriteLine("Охранник " + firstname + " бродит в поисках выпивки");
            }
        }


    }

    internal class Program
    {


        static void Main(string[] args)
        {

            Dalmatian dalmatian = new Dalmatian("Долматинец");
            Dalmatian dalmatian1 = new Dalmatian(1);
            Console.WriteLine("Введите количество долматинцев попавших в приют : ");
            int dal_count = int.Parse(Console.ReadLine());
            dalmatian.Dal_count = dal_count;

            Random rand1 = new Random();
            int count1 = rand1.Next(0, dal_count);
            dalmatian.Walk = count1;
            dalmatian.Dal_walk();
            Thread.Sleep(500);

            Random rand2 = new Random();
            int count2 = rand2.Next(0, dal_count);
            dalmatian.Sleep_count = count2;
            dalmatian.Dal_sleep();
            Thread.Sleep(500);

            Random rand3 = new Random();
            int count3 = rand3.Next(0, dal_count);
            dalmatian.Sick_count = count3;
            dalmatian.Dal_sick();

            dalmatian.Eat();
            dalmatian.Stroll();

            Poodle poodle = new Poodle("Пудель");
            Poodle poodle1 = new Poodle(2);
            Console.WriteLine("Введите количество пуделей попавших в приют");
            int pood_count = int.Parse(Console.ReadLine());
            poodle.Pood_count = pood_count;

            Random rand4 = new Random();
            int count4 = rand4.Next(0, pood_count);
            poodle.Walk = count4;
            poodle.Pood_walk();
            Thread.Sleep(500);

            Random rand5 = new Random();
            int count5 = rand5.Next(0, pood_count);
            poodle.Sleep_count = count5;
            poodle.Pood_sleep();
            Thread.Sleep(500);

            Random rand6 = new Random();
            int count6 = rand6.Next(0, pood_count);
            poodle.Sick_count = count6;
            poodle.Pood_sick();
            Thread.Sleep(500);


            poodle.Weasel();
            poodle.Wash();




            Guard guard = new Guard();

            Console.WriteLine("Введите имя,фамилию сотрудника");
            string path = @"C:\Users\arsen\Documents\text\note1.txt";


            using (StreamWriter writer = new StreamWriter(path, false))
            {
                writer.WriteLine(Console.ReadLine());
                writer.WriteLine(Console.ReadLine());
            }

            //using (StreamWriter writer = new StreamWriter(path, true))
            //{
            //    writer.WriteLine(Console.ReadLine());
            //    writer.WriteLine(Console.ReadLine());
            //}
            //
            

            string path1 = @"C:\Users\arsen\Documents\text\note1.txt";

            using (StreamReader reader = new StreamReader(path1))
            {
                guard.Firstname = reader.ReadLine();
                guard.Lastname = reader.ReadLine();
            }
            guard.Job = "Охранник";
            guard.Age = 17;
            guard.PrintInfo();
            guard.Order();
            guard.Сameras();
            guard.Criminal();
            guard.GuardWork();


         





        }
    }
}
