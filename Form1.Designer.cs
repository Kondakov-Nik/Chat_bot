﻿namespace Chat_Bot
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        /// 

        private System.Windows.Forms.TextBox ChatText;
        private System.Windows.Forms.TextBox InputText;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.Button ClearDialogButton;
        private void InitializeComponent()
        {
            this.ChatText = new System.Windows.Forms.TextBox();
            this.InputText = new System.Windows.Forms.TextBox();
            this.SendButton = new System.Windows.Forms.Button();
            this.ClearDialogButton = new System.Windows.Forms.Button();
            this.button_commands = new System.Windows.Forms.Button();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обАвтореToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ChatText
            // 
            this.ChatText.BackColor = System.Drawing.SystemColors.Window;
            this.ChatText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ChatText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChatText.ForeColor = System.Drawing.Color.DarkCyan;
            this.ChatText.Location = new System.Drawing.Point(21, 24);
            this.ChatText.Multiline = true;
            this.ChatText.Name = "ChatText";
            this.ChatText.ReadOnly = true;
            this.ChatText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ChatText.Size = new System.Drawing.Size(409, 231);
            this.ChatText.TabIndex = 0;
            // 
            // InputText
            // 
            this.InputText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputText.Location = new System.Drawing.Point(21, 271);
            this.InputText.Multiline = true;
            this.InputText.Name = "InputText";
            this.InputText.Size = new System.Drawing.Size(409, 49);
            this.InputText.TabIndex = 1;
            // 
            // SendButton
            // 
            this.SendButton.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.SendButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SendButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SendButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.SendButton.Location = new System.Drawing.Point(436, 271);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(136, 49);
            this.SendButton.TabIndex = 2;
            this.SendButton.Text = "Отправить";
            this.SendButton.UseVisualStyleBackColor = false;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // ClearDialogButton
            // 
            this.ClearDialogButton.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClearDialogButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClearDialogButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearDialogButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClearDialogButton.Location = new System.Drawing.Point(436, 206);
            this.ClearDialogButton.Name = "ClearDialogButton";
            this.ClearDialogButton.Size = new System.Drawing.Size(136, 49);
            this.ClearDialogButton.TabIndex = 3;
            this.ClearDialogButton.Text = "Очистить";
            this.ClearDialogButton.UseVisualStyleBackColor = false;
            this.ClearDialogButton.Click += new System.EventHandler(this.ClearDialogButton_Click);
            // 
            // button_commands
            // 
            this.button_commands.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.button_commands.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_commands.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_commands.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button_commands.Location = new System.Drawing.Point(436, 142);
            this.button_commands.Name = "button_commands";
            this.button_commands.Size = new System.Drawing.Size(136, 49);
            this.button_commands.TabIndex = 5;
            this.button_commands.Text = "Доступные команды\r\n";
            this.button_commands.UseVisualStyleBackColor = false;
            this.button_commands.Click += new System.EventHandler(this.button_commands_Click);
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.обАвтореToolStripMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // обАвтореToolStripMenuItem
            // 
            this.обАвтореToolStripMenuItem.Name = "обАвтореToolStripMenuItem";
            this.обАвтореToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.обАвтореToolStripMenuItem.Text = "Об авторе";
            this.обАвтореToolStripMenuItem.Click += new System.EventHandler(this.обАвтореToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Form1
            // 
            this.AcceptButton = this.SendButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(584, 341);
            this.Controls.Add(this.button_commands);
            this.Controls.Add(this.ClearDialogButton);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.InputText);
            this.Controls.Add(this.ChatText);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 380);
            this.MinimumSize = new System.Drawing.Size(600, 380);
            this.Name = "Form1";
            this.Text = "Чат Бот";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.Button button_commands;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обАвтореToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}

