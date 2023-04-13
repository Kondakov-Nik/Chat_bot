using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Chat_Bot //определение пространства имен Chat_Bot
{
    public partial class login_form : Form  // Form - определение класса login_form, который наследуется от класса Form.

    {

        public login_form() //конструктор класса login_form.
        {
            InitializeComponent(); // метод, который инициализирует компоненты
        }

        private void LoginButton1_Click(object sender, EventArgs e)  // Обработчик события кнопки закрытия формы
        {
            // Закрыть форму
            this.Close();
        }

        private void LoginButton2_Click(object sender, EventArgs e)
        { // Если поле ввода имени пользователя пустое, вывести сообщение об ошибке

            if (UserName.Text == "")
            {
                MessageBox.Show("Не удалось войти. Введите своё имя.");
            }
            else
            {
                // Создание экземпляра класса Form1 и присваивание его переменной form
                Form1 form = new Form1();
                // Открытие формы ЧатБот
                form.Show();  
                // Закрытие формы авторизации
                this.Hide();
            }
        }
    }
}
