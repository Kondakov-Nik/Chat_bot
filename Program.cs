//Чат-бот
//Автор Кондаков Никита ИВТ-21
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chat_Bot // определение пространства имен Chat_bot
{
    // статический класс Program
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new login_form()); // Метод Run запускает приложение и открывает форму входа Login_form
        }
    }
}
