using System;
using System.Collections.Generic;

namespace database
{
    class Program
    {
        static void FIO()
        {
            Console.WriteLine("Введите ФИО");
            string fio = Console.ReadLine();
            if (fio == null)
            {
                Console.WriteLine("Н/Д");
            }
        }

        static void POL()
        {
            Console.WriteLine("Введите ваш пол");
            string pol = Console.ReadLine();
            if (pol == null)
            {
                Console.WriteLine("Н/Д");
            }
        }

        static void FEAM()
        {
            List<string> feam = new List<string>
            {
                "1: в браке",
                "2: холост",
            };
            for (int i = 0; i < feam.Count; i++)
            {
                Console.WriteLine(feam[i]);
            }
            int sp = int.Parse(Console.ReadLine());
            string vivodfeam;
            while (sp != 1 && sp != 2)
            {
                switch (sp)
                {
                    case 1:
                        vivodfeam = "женат";
                        Console.WriteLine(vivodfeam);
                        break;
                    case 2:
                        vivodfeam = "холост";
                        Console.WriteLine(vivodfeam);
                        break;
                }
            }
        }

        static void DETI()
        {
            Console.WriteLine("Введите кол-во детей");
            int deti = int.Parse(Console.ReadLine());
            Console.WriteLine(deti);
        }

        static void CalculateAge()
        {
            bool isValidDate = false;
            DateTime birthDate = DateTime.MinValue;

            while (!isValidDate)
            {
                Console.Write("Введите дату рождения (гггг-мм-дд): ");
                string input = Console.ReadLine();

                // Парсим введенную строку в объект DateTime
                if (DateTime.TryParse(input, out birthDate))
                {
                    isValidDate = true;
                }
                else
                {
                    Console.WriteLine("Некорректный формат даты. Пожалуйста, введите дату в формате 'гггг-мм-дд'.");
                }
            }

            // Вычисляем разницу между текущей датой и датой рождения
            TimeSpan ageDifference = DateTime.Now - birthDate;

            // Получаем возраст в годах, округленный вниз
            int age = (int)(ageDifference.TotalDays / 365.25);

            // Выводим возраст
            Console.WriteLine($"Ваш возраст: {age} лет");
        }

        static void Obrazovanie()
        {
            List<string> obrlist = new List<string>
            {
                "1:Высшее",
                "2:Среднее специальное",
                "3:Среднеее полное",
                "4:Среднее",
                "5:Другое, введите свой вариант",
            };
            for (int i = 0; i < obrlist.Count; i++)
            {
                Console.WriteLine(obrlist[i]);
            }
            int obrazovanie = int.Parse(Console.ReadLine());
            string vivodobrazovanie;
            switch (obrazovanie)
            {
                case 1:
                    vivodobrazovanie = "Высшее";
                    break;
                case 2:
                    vivodobrazovanie = "Среднее специальное";
                    break;
                case 3:
                    vivodobrazovanie = "Среднеее полное";
                    break;
                case 4:
                    vivodobrazovanie = "Среднее";
                    break;
                case 5:
                    vivodobrazovanie = Console.ReadLine();
                    break;
            }
        }

        static void Adres()
        {
            Console.WriteLine("введите адрес проживания");
            string adres = Console.ReadLine();
            if (adres == null)
            {
                Console.WriteLine("Н/Д");
            }
        }
        static void Rabota()
        {
            Console.WriteLine("Место работы/обучение,адрес");
            string rabota = Console.ReadLine();
            if (rabota == null)
            {
                Console.WriteLine("Н/Д");
            }
        }

        static void Document()
        {
            Console.WriteLine("Серия паспорта");
            int pasportseria = int.Parse(Console.ReadLine());
            string pasportseriacheck = Convert.ToString(pasportseria);
            while (pasportseriacheck.Length != 4)
            {
                Console.WriteLine("Ошибка, повторите ввод");
                pasportseria = int.Parse(Console.ReadLine());
                pasportseriacheck = Convert.ToString(pasportseria);
            }

            Console.WriteLine("Номер паспорта");
            int pasportnomer = int.Parse(Console.ReadLine());
            string pasportnomercheck = Convert.ToString(pasportnomer);
            while (pasportnomercheck.Length != 6)
            {
                Console.WriteLine("Ошибка, повторите ввод");
                pasportnomer = int.Parse(Console.ReadLine());
                pasportnomercheck = Convert.ToString(pasportnomer);
            }

            bool isValidRegistrationDate = false;
            DateTime registrationDate = DateTime.MinValue;

            while (!isValidRegistrationDate)
            {
                Console.Write("Введите дату прописки (гггг-мм-дд): ");
                string input = Console.ReadLine();

                // Парсим введенную строку в объект DateTime
                if (DateTime.TryParse(input, out registrationDate))
                {
                    isValidRegistrationDate = true;
                }
                else
                {
                    Console.WriteLine("Некорректный формат даты. Пожалуйста, введите дату в формате 'гггг-мм-дд'.");
                }
            }

            Console.WriteLine("СНИЛС");
            long snils = long.Parse(Console.ReadLine());
            string snilscheck = Convert.ToString(snils);
            while (snilscheck.Length != 11)
            {
                Console.WriteLine("Ошибка, повторите ввод");
                snils = long.Parse(Console.ReadLine());
                snilscheck = Convert.ToString(snils);
            }

            Console.WriteLine("ИИН");
            long inn = long.Parse(Console.ReadLine());
            string inncheck = Convert.ToString(inn);
            while (inncheck.Length != 12)
            {
                Console.WriteLine("Ошибка, повторите ввод");
                inn = long.Parse(Console.ReadLine());
                inncheck = Convert.ToString(inn);
            }
        }

        static void Doxod()
        {
            Console.WriteLine("Введите ваш доход");
            int doxod = int.Parse(Console.ReadLine());
            string statys;
            if (doxod == 0)
            {
                statys = "иждевенец";
                Console.WriteLine(statys);
            }
            if (doxod < 13500)
            {
                statys = "нуждающийся";
                Console.WriteLine(statys);
            }
        }

        static void Vivod()
        {
            Console.WriteLine("");
        }

        static void Proverka()
        {
            Console.WriteLine("Проверьте корректность введеных данных");
            List<string> proverkalist = new List<string>
            {
                "1:Отредактировать ФИО",
                "2:Отредактировать пол",
                "3:Отредактировать семейное положение",
                "4:Отредактировать кол-во детей",
                "5:Отредактировать дату рождения",
                "6:Отредактировать образование",
                "7:Отредактировать адрес проживания",
                "8:Отредактировать место работы/обучения ","9:Отредактировать документы",
                "10:Отредактировать доход",
                "Нажмите любую клавишу, чтобы продолжить",
            };
            for (int i = 0; i < proverkalist.Count; i++)
            {
                Console.WriteLine(proverkalist[i]);
            }
            int proverka = int.Parse(Console.ReadLine());

            do
            {
                switch (proverka)
                {
                    case 1:
                        FIO();
                        proverka = int.Parse(Console.ReadLine());
                        break;
                    case 2:
                        POL();
                        proverka = int.Parse(Console.ReadLine());
                        break;
                    case 3:
                        FEAM();
                        proverka = int.Parse(Console.ReadLine());
                        break;
                    case 4:
                        DETI();
                        proverka = int.Parse(Console.ReadLine());
                        break;
                    case 5:
                        CalculateAge();
                        proverka = int.Parse(Console.ReadLine());
                        break;
                    case 6:
                        Obrazovanie();
                        proverka = int.Parse(Console.ReadLine());
                        break;
                    case 7:
                        Adres();
                        proverka = int.Parse(Console.ReadLine());
                        break;
                    case 8:
                        Rabota();
                        proverka = int.Parse(Console.ReadLine());
                        break;
                    case 9:
                        Document();
                        proverka = int.Parse(Console.ReadLine());
                        break;
                    case 10:
                        Doxod();
                        proverka = int.Parse(Console.ReadLine());
                        break;
                    default:
                        Vivod();
                        proverka = int.Parse(Console.ReadLine());
                        break;
                }
            }
            while (proverka >= 1 && proverka <= 10);
        }

        static void Main(string[] args)
        {
            FIO();
            POL();
            FEAM();
            DETI();
            CalculateAge();
            Obrazovanie();
            Adres();
            Rabota();
            Document();
            Doxod();
            Vivod();

            Proverka();

            Console.ReadLine();
        }
    }
}