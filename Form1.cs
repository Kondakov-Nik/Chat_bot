using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chat_Bot //определение пространства имен Chat_bot
{
    public partial class Form1 : Form       // Определение класса Form1, который наследуется от класса Form
                                            // и принадлежит пространству имен Chat_bot
    {
        private Class_Bot bot = new Class_Bot();    // Создание экземпляра класса ChatBot и присваивание его переменной bot

        public Form1() // Конструктор класса Form1
        {
            InitializeComponent();
        }

        private void SendButton_Click(object sender, EventArgs e) // Обработчик события нажатия на кнопку отправить
        {
            var input = InputText.Text; // В переменную input данные из поля InputText
            var response = bot.RespondToMessage(input); // В переменную response ответ от бота
            ChatText.Text += "[" + DateTime.Now.ToString("HH:mm") + "] " + "Вы: " + input + "\r\n";
            ChatText.Text += "Бот: " + response + "\r\n";
            // Очищаем текстовое поле ввода
            InputText.Text = "";

        }

        private void ClearDialogButton_Click(object sender, EventArgs e) // Обработчик события нажатия на кнопку очистить 
        {
            ChatText.Clear();
        }

        private void обАвтореToolStripMenuItem_Click(object sender, EventArgs e) // Обработчик события нажатия на кнопку меню
        {
            MessageBox.Show("Автор: Кондаков Никита Сергеевич");
        }

        private void button_commands_Click(object sender, EventArgs e) // Обработчик события при нажатии на кнопку Доступных команд
        {
            // Создаем экземпляр формы с командами
            help_form frm = new help_form();

            // Открываем форму с командами
            frm.Show();
        }
    }
}
