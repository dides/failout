﻿namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SpamButton = new System.Windows.Forms.Button();
            this.DogPatulButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рассылкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискУдаленныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AutoLike_button = new System.Windows.Forms.Button();
            this.autoadd = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.find_groups_box = new System.Windows.Forms.TextBox();
            this.find_groups_button = new System.Windows.Forms.Button();
            this.Pirat_button = new System.Windows.Forms.Button();
            this.addFriends_button = new System.Windows.Forms.Button();
            this.gropssercbaton = new System.Windows.Forms.Button();
            this.Laikbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 28);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(27, 25);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1260, 550);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(33, 188);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 160);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // SpamButton
            // 
            this.SpamButton.Location = new System.Drawing.Point(945, 48);
            this.SpamButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SpamButton.Name = "SpamButton";
            this.SpamButton.Size = new System.Drawing.Size(245, 31);
            this.SpamButton.TabIndex = 4;
            this.SpamButton.Text = "Рассылка";
            this.SpamButton.UseVisualStyleBackColor = true;
            this.SpamButton.Click += new System.EventHandler(this.SpamButton_Click);
            // 
            // DogPatulButton
            // 
            this.DogPatulButton.Location = new System.Drawing.Point(945, 98);
            this.DogPatulButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DogPatulButton.Name = "DogPatulButton";
            this.DogPatulButton.Size = new System.Drawing.Size(245, 28);
            this.DogPatulButton.TabIndex = 5;
            this.DogPatulButton.Text = "Собачий патруль";
            this.DogPatulButton.UseVisualStyleBackColor = true;
            this.DogPatulButton.Click += new System.EventHandler(this.DogPatulButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1260, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.рассылкаToolStripMenuItem,
            this.поискУдаленныхToolStripMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // рассылкаToolStripMenuItem
            // 
            this.рассылкаToolStripMenuItem.Name = "рассылкаToolStripMenuItem";
            this.рассылкаToolStripMenuItem.Size = new System.Drawing.Size(200, 24);
            this.рассылкаToolStripMenuItem.Text = "Рассылка";
            // 
            // поискУдаленныхToolStripMenuItem
            // 
            this.поискУдаленныхToolStripMenuItem.Name = "поискУдаленныхToolStripMenuItem";
            this.поискУдаленныхToolStripMenuItem.Size = new System.Drawing.Size(200, 24);
            this.поискУдаленныхToolStripMenuItem.Text = "Поиск удаленных";
            // 
            // AutoLike_button
            // 
            this.AutoLike_button.Location = new System.Drawing.Point(945, 153);
            this.AutoLike_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AutoLike_button.Name = "AutoLike_button";
            this.AutoLike_button.Size = new System.Drawing.Size(243, 28);
            this.AutoLike_button.TabIndex = 7;
            this.AutoLike_button.Text = "Авто-лайк";
            this.AutoLike_button.UseVisualStyleBackColor = true;
            this.AutoLike_button.Click += new System.EventHandler(this.AutoLike_button_Click);
            // 
            // autoadd
            // 
            this.autoadd.AutoSize = true;
            this.autoadd.Location = new System.Drawing.Point(16, 508);
            this.autoadd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.autoadd.Name = "autoadd";
            this.autoadd.Size = new System.Drawing.Size(249, 21);
            this.autoadd.TabIndex = 8;
            this.autoadd.Text = "Принимать все запросы в друзья";
            this.autoadd.UseVisualStyleBackColor = true;
            // 
            // find_groups_box
            // 
            this.find_groups_box.Location = new System.Drawing.Point(945, 265);
            this.find_groups_box.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.find_groups_box.Name = "find_groups_box";
            this.find_groups_box.Size = new System.Drawing.Size(253, 22);
            this.find_groups_box.TabIndex = 9;
            this.find_groups_box.Text = "Введите тему";
            this.find_groups_box.TextChanged += new System.EventHandler(this.find_groups_box_TextChanged);
            // 
            // find_groups_button
            // 
            this.find_groups_button.Location = new System.Drawing.Point(948, 297);
            this.find_groups_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.find_groups_button.Name = "find_groups_button";
            this.find_groups_button.Size = new System.Drawing.Size(245, 41);
            this.find_groups_button.TabIndex = 10;
            this.find_groups_button.Text = "Найти соответствия";
            this.find_groups_button.UseVisualStyleBackColor = true;
            // 
            // Pirat_button
            // 
            this.Pirat_button.BackColor = System.Drawing.Color.SandyBrown;
            this.Pirat_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pirat_button.Location = new System.Drawing.Point(948, 345);
            this.Pirat_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Pirat_button.Name = "Pirat_button";
            this.Pirat_button.Size = new System.Drawing.Size(245, 95);
            this.Pirat_button.TabIndex = 11;
            this.Pirat_button.Text = "TORRENT-TREKKER";
            this.Pirat_button.UseVisualStyleBackColor = false;
            // 
            // addFriends_button
            // 
            this.addFriends_button.Location = new System.Drawing.Point(948, 458);
            this.addFriends_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addFriends_button.Name = "addFriends_button";
            this.addFriends_button.Size = new System.Drawing.Size(203, 59);
            this.addFriends_button.TabIndex = 13;
            this.addFriends_button.Text = "Добавление в список";
            this.addFriends_button.UseVisualStyleBackColor = true;
            this.addFriends_button.Click += new System.EventHandler(this.addFriends_Click);
            // 
            // gropssercbaton
            // 
            this.gropssercbaton.Location = new System.Drawing.Point(945, 188);
            this.gropssercbaton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gropssercbaton.Name = "gropssercbaton";
            this.gropssercbaton.Size = new System.Drawing.Size(243, 41);
            this.gropssercbaton.TabIndex = 14;
            this.gropssercbaton.Text = "поиск груп";
            this.gropssercbaton.UseVisualStyleBackColor = true;
            this.gropssercbaton.Click += new System.EventHandler(this.gropssercbaton_Click);
            // 
            // Laikbutton
            // 
            this.Laikbutton.Location = new System.Drawing.Point(593, 265);
            this.Laikbutton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Laikbutton.Name = "Laikbutton";
            this.Laikbutton.Size = new System.Drawing.Size(185, 25);
            this.Laikbutton.TabIndex = 15;
            this.Laikbutton.Text = "Автолайк групп";
            this.Laikbutton.UseVisualStyleBackColor = true;
            this.Laikbutton.Click += new System.EventHandler(this.Laikbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 578);
            this.Controls.Add(this.Laikbutton);
            this.Controls.Add(this.gropssercbaton);
            this.Controls.Add(this.addFriends_button);
            this.Controls.Add(this.Pirat_button);
            this.Controls.Add(this.find_groups_button);
            this.Controls.Add(this.find_groups_box);
            this.Controls.Add(this.autoadd);
            this.Controls.Add(this.AutoLike_button);
            this.Controls.Add(this.DogPatulButton);
            this.Controls.Add(this.SpamButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button SpamButton;
        private System.Windows.Forms.Button DogPatulButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рассылкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискУдаленныхToolStripMenuItem;
        private System.Windows.Forms.Button AutoLike_button;
        private System.Windows.Forms.CheckBox autoadd;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox find_groups_box;
        private System.Windows.Forms.Button find_groups_button;
        private System.Windows.Forms.Button Pirat_button;
        private System.Windows.Forms.Button addFriends_button;
        private System.Windows.Forms.Button gropssercbaton;
        private System.Windows.Forms.Button Laikbutton;
    }
}

