using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat_Bot //определение пространства имен Chat_bot
{
    internal class Class_Bot // внутренний класс
    {
        string response; // Переменная хранящая ответы от бота

        public string RespondToMessage(string message) // Метод возращающий ответы от бота
        {

            if (message == "Привет" || message == "Здравствуйте")
            {
                response = Greeting_Request();
            }

            else if (message == "Который час" || message == "Время" || message == "Сколько время")
            {
                response = Time_Request();
            }

            else if (message == "Дата" || message == "Какое число" || message == "Число")
            {
                response = Date_Request();
            }

            else if (message == "Как дела?" || message == "Как ты" || message == "Настроение")
            {
                response = HowAreYou_Request();
            }

            else if (message == "Спасибо")
            {
                response = ThankYou_Request();
            }

            else if (message.StartsWith("Умножь"))
            {
                response = Multiplication_Request(message);
            }

            else if (message.StartsWith("Подели"))
            {
                response = Division_Request(message);
            }

            else if (message.StartsWith("Сумма"))
            {
                response = Plus_Request(message);
            }

            else if (message.StartsWith("Вычти"))
            {
                response = Sub_Request(message);
            }

            else
            {
                response = Unknown_Message();
            }

            return response;

        }

        public string Greeting_Request() // Метод возращения привествия от бота
        {
            return "Здравствуйте! ";
        }

        public string Time_Request() // Метод возращения времени от бота
        {
            return "Сейчас: " + DateTime.Now.ToString("HH:mm");
        }

        public string Date_Request() // Метод возращения даты от бота
        {
            return "Сегодня: " + DateTime.Now.ToString("dd.MM.yy");
        }

        public string HowAreYou_Request() // Метод возращения как дела от бота
        {
            Random rnd = new Random(); // Создание экземпляра генератора случайных чисел
            int value = rnd.Next(); // Генерация случайного числа
            if (value % 2 == 0)  // Если число чётное
                return "В полном порядке.";
            else
            {
                return "Лучше некуда!";
            }
        }

        public string ThankYou_Request() // Метод возращения на слово спасибо от бота
        {
            return "Обращайся)";
        }


        public string Multiplication_Request(string message) // Метод возращения умножения от бота
        {
            string[] parts = message.Split(' '); // Разбиваем строку на массив подстрок пробелами
            if (parts.Length == 4 && double.TryParse(parts[1], out double x) && double.TryParse(parts[3], out double y))
            {
                double result = x * y;
                return "Результат умножения равен " + result.ToString(); ;
            }
            else
            {
                return "Неправильный формат команды. Используйте команду Умножь X на Y";
            }
        }

        public string Division_Request(string message) // Метод возращения деления от бота
        {
            string[] parts = message.Split(' ');
            if (parts.Length == 4 && double.TryParse(parts[1], out double x) && double.TryParse(parts[3], out double y))
            {
                double result = x / y;
                return "Результат деления равен " + result.ToString(); ;
            }
            else
            {
                return "Неправильный формат команды. Используйте команду: Подели X на Y";
            }
        }

        public string Plus_Request(string message) // Метод возращения суммы от бота
        {
            string[] parts = message.Split(' ');
            if (parts.Length == 4 && double.TryParse(parts[1], out double x) && double.TryParse(parts[3], out double y))
            {
                double result = x + y;
                return "Результат суммы равен " + result.ToString(); ;
            }
            else
            {
                return "Неправильный формат команды. Используйте команду: Сумма X и Y";
            }
        }

        public string Sub_Request(string message) // Метод возращения вычитения от бота
        {
            string[] parts = message.Split(' ');
            if (parts.Length == 4 && double.TryParse(parts[1], out double x) && double.TryParse(parts[3], out double y))
            {
                double result = y - x;
                return "Результат вычитания равен " + result.ToString(); ;
            }
            else
            {
                return "Неправильный формат команды. Используйте команду: Вычти X из Y";
            }
        }

        public string Unknown_Message() // Метод если не шаблонная фраза для бота
        {
            return "Извините, я не понял ваш запрос";
        }

    }
}
