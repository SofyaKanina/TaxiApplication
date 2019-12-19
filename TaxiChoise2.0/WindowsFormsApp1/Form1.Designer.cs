namespace WindowsFormsApp1
{
    using System.Drawing;
    partial class MainScreen
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
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.StartButton = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.HelpButton = new System.Windows.Forms.Button();
            this.ServiseChooser = new System.Windows.Forms.CheckedListBox();
            this.HighestratingButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.DataLabel = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.Coord1Box = new System.Windows.Forms.TextBox();
            this.Coord2Box = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Dest1Box = new System.Windows.Forms.TextBox();
            this.Dest2Box = new System.Windows.Forms.TextBox();
            this.PlacesToGo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ClassChooser = new System.Windows.Forms.CheckedListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.PlacesToGo2 = new System.Windows.Forms.ComboBox();
            this.FinalButton = new System.Windows.Forms.Button();
            this.ServiseLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.AllServisesButton = new System.Windows.Forms.Button();
            this.AllClassesButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StartButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.StartButton.BackColor = System.Drawing.Color.White;
            this.StartButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.StartButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.Location = new System.Drawing.Point(417, 488);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(174, 38);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Выбрать такси";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // HelpButton
            // 
            this.HelpButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.HelpButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.HelpButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpButton.Location = new System.Drawing.Point(1018, 788);
            this.HelpButton.Name = "HelpButton";
            this.HelpButton.Size = new System.Drawing.Size(29, 30);
            this.HelpButton.TabIndex = 1;
            this.HelpButton.Text = "?";
            this.HelpButton.UseVisualStyleBackColor = true;
            this.HelpButton.Click += new System.EventHandler(this.HelpButton_Click);
            // 
            // ServiseChooser
            // 
            this.ServiseChooser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ServiseChooser.BackColor = System.Drawing.Color.White;
            this.ServiseChooser.CheckOnClick = true;
            this.ServiseChooser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ServiseChooser.FormattingEnabled = true;
            this.ServiseChooser.Location = new System.Drawing.Point(12, 187);
            this.ServiseChooser.Name = "ServiseChooser";
            this.ServiseChooser.Size = new System.Drawing.Size(256, 180);
            this.ServiseChooser.Sorted = true;
            this.ServiseChooser.TabIndex = 2;
            this.ServiseChooser.Visible = false;
            this.ServiseChooser.SelectedIndexChanged += new System.EventHandler(this.ServiseChooser_SelectedIndexChanged);
            // 
            // HighestratingButton
            // 
            this.HighestratingButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.HighestratingButton.BackColor = System.Drawing.Color.White;
            this.HighestratingButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HighestratingButton.Location = new System.Drawing.Point(12, 373);
            this.HighestratingButton.Name = "HighestratingButton";
            this.HighestratingButton.Size = new System.Drawing.Size(253, 30);
            this.HighestratingButton.TabIndex = 3;
            this.HighestratingButton.Text = "Наивысший рейтинг";
            this.HighestratingButton.UseVisualStyleBackColor = false;
            this.HighestratingButton.Visible = false;
            this.HighestratingButton.Click += new System.EventHandler(this.HighestRatingButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(903, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 43);
            this.label1.TabIndex = 4;
            this.label1.Text = "Текущее время:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DataLabel
            // 
            this.DataLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DataLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.DataLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataLabel.Location = new System.Drawing.Point(904, 203);
            this.DataLabel.Name = "DataLabel";
            this.DataLabel.Size = new System.Drawing.Size(46, 17);
            this.DataLabel.TabIndex = 5;
            this.DataLabel.Text = "label2";
            this.DataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TimeLabel
            // 
            this.TimeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TimeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.TimeLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLabel.Location = new System.Drawing.Point(904, 229);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(46, 17);
            this.TimeLabel.TabIndex = 6;
            this.TimeLabel.Text = "label3";
            this.TimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Coord1Box
            // 
            this.Coord1Box.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Coord1Box.Location = new System.Drawing.Point(417, 149);
            this.Coord1Box.Name = "Coord1Box";
            this.Coord1Box.Size = new System.Drawing.Size(100, 22);
            this.Coord1Box.TabIndex = 7;
            this.Coord1Box.Visible = false;
            // 
            // Coord2Box
            // 
            this.Coord2Box.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Coord2Box.Location = new System.Drawing.Point(417, 180);
            this.Coord2Box.Name = "Coord2Box";
            this.Coord2Box.Size = new System.Drawing.Size(100, 22);
            this.Coord2Box.TabIndex = 8;
            this.Coord2Box.Visible = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabel1.Location = new System.Drawing.Point(353, 219);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(183, 18);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Узнать свои координаты";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkLabel1.Visible = false;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(343, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ваши координаты:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.Location = new System.Drawing.Point(344, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Ширина:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.Location = new System.Drawing.Point(344, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Долгота:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Visible = false;
            // 
            // Dest1Box
            // 
            this.Dest1Box.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Dest1Box.Location = new System.Drawing.Point(417, 325);
            this.Dest1Box.Name = "Dest1Box";
            this.Dest1Box.Size = new System.Drawing.Size(100, 22);
            this.Dest1Box.TabIndex = 14;
            this.Dest1Box.Visible = false;
            // 
            // Dest2Box
            // 
            this.Dest2Box.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Dest2Box.Location = new System.Drawing.Point(417, 353);
            this.Dest2Box.Name = "Dest2Box";
            this.Dest2Box.Size = new System.Drawing.Size(100, 22);
            this.Dest2Box.TabIndex = 15;
            this.Dest2Box.Visible = false;
            // 
            // PlacesToGo
            // 
            this.PlacesToGo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PlacesToGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlacesToGo.FormattingEnabled = true;
            this.PlacesToGo.Location = new System.Drawing.Point(347, 393);
            this.PlacesToGo.Name = "PlacesToGo";
            this.PlacesToGo.Size = new System.Drawing.Size(320, 24);
            this.PlacesToGo.TabIndex = 17;
            this.PlacesToGo.Text = "Выбрать пункт назначения из доступных...";
            this.PlacesToGo.Visible = false;
            this.PlacesToGo.SelectedIndexChanged += new System.EventHandler(this.PlacesToGo_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(343, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(302, 24);
            this.label5.TabIndex = 18;
            this.label5.Text = "Координаты пункта назначения:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Visible = false;
            // 
            // ClassChooser
            // 
            this.ClassChooser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ClassChooser.BackColor = System.Drawing.Color.White;
            this.ClassChooser.CheckOnClick = true;
            this.ClassChooser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClassChooser.FormattingEnabled = true;
            this.ClassChooser.Location = new System.Drawing.Point(22, 496);
            this.ClassChooser.Name = "ClassChooser";
            this.ClassChooser.Size = new System.Drawing.Size(256, 180);
            this.ClassChooser.Sorted = true;
            this.ClassChooser.TabIndex = 19;
            this.ClassChooser.Visible = false;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(23, 469);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 24);
            this.label6.TabIndex = 20;
            this.label6.Text = "Выберите классы:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(18, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(187, 24);
            this.label7.TabIndex = 21;
            this.label7.Text = "Выберите сервисы:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Visible = false;
            // 
            // PlacesToGo2
            // 
            this.PlacesToGo2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PlacesToGo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlacesToGo2.FormattingEnabled = true;
            this.PlacesToGo2.Location = new System.Drawing.Point(347, 249);
            this.PlacesToGo2.Name = "PlacesToGo2";
            this.PlacesToGo2.Size = new System.Drawing.Size(320, 24);
            this.PlacesToGo2.TabIndex = 22;
            this.PlacesToGo2.Text = "Выбрать пункт отправления из доступных...";
            this.PlacesToGo2.Visible = false;
            this.PlacesToGo2.SelectedIndexChanged += new System.EventHandler(this.PlacesToGo2_SelectedIndexChanged);
            // 
            // FinalButton
            // 
            this.FinalButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FinalButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FinalButton.BackColor = System.Drawing.Color.White;
            this.FinalButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.FinalButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinalButton.Location = new System.Drawing.Point(744, 368);
            this.FinalButton.Name = "FinalButton";
            this.FinalButton.Size = new System.Drawing.Size(190, 105);
            this.FinalButton.TabIndex = 23;
            this.FinalButton.Text = "Определить сервис и цену";
            this.FinalButton.UseVisualStyleBackColor = false;
            this.FinalButton.Visible = false;
            this.FinalButton.Click += new System.EventHandler(this.FinalButton_Click);
            // 
            // ServiseLabel
            // 
            this.ServiseLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ServiseLabel.BackColor = System.Drawing.Color.White;
            this.ServiseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ServiseLabel.Location = new System.Drawing.Point(739, 488);
            this.ServiseLabel.Name = "ServiseLabel";
            this.ServiseLabel.Size = new System.Drawing.Size(195, 50);
            this.ServiseLabel.TabIndex = 24;
            this.ServiseLabel.Text = "Сервис";
            this.ServiseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ServiseLabel.Visible = false;
            // 
            // PriceLabel
            // 
            this.PriceLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PriceLabel.BackColor = System.Drawing.Color.White;
            this.PriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PriceLabel.Location = new System.Drawing.Point(739, 556);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(195, 50);
            this.PriceLabel.TabIndex = 25;
            this.PriceLabel.Text = "Цена";
            this.PriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PriceLabel.Visible = false;
            // 
            // AllServisesButton
            // 
            this.AllServisesButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AllServisesButton.BackColor = System.Drawing.Color.White;
            this.AllServisesButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllServisesButton.Location = new System.Drawing.Point(12, 409);
            this.AllServisesButton.Name = "AllServisesButton";
            this.AllServisesButton.Size = new System.Drawing.Size(253, 30);
            this.AllServisesButton.TabIndex = 26;
            this.AllServisesButton.Text = "Выбрать все сервисы";
            this.AllServisesButton.UseVisualStyleBackColor = false;
            this.AllServisesButton.Visible = false;
            this.AllServisesButton.Click += new System.EventHandler(this.AllServisesButton_Click);
            // 
            // AllClassesButton
            // 
            this.AllClassesButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AllClassesButton.BackColor = System.Drawing.Color.White;
            this.AllClassesButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllClassesButton.Location = new System.Drawing.Point(27, 682);
            this.AllClassesButton.Name = "AllClassesButton";
            this.AllClassesButton.Size = new System.Drawing.Size(253, 30);
            this.AllClassesButton.TabIndex = 27;
            this.AllClassesButton.Text = "Выбрать все классы";
            this.AllClassesButton.UseVisualStyleBackColor = false;
            this.AllClassesButton.Visible = false;
            this.AllClassesButton.Click += new System.EventHandler(this.AllClassesButton_Click);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.Location = new System.Drawing.Point(348, 328);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 17);
            this.label8.TabIndex = 28;
            this.label8.Text = "Ширина:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label8.Visible = false;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.Location = new System.Drawing.Point(344, 356);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 17);
            this.label9.TabIndex = 29;
            this.label9.Text = "Долгота:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label9.Visible = false;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1059, 981);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.AllClassesButton);
            this.Controls.Add(this.AllServisesButton);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.ServiseLabel);
            this.Controls.Add(this.FinalButton);
            this.Controls.Add(this.PlacesToGo2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ClassChooser);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PlacesToGo);
            this.Controls.Add(this.Dest2Box);
            this.Controls.Add(this.Dest1Box);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.Coord2Box);
            this.Controls.Add(this.Coord1Box);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.DataLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HighestratingButton);
            this.Controls.Add(this.ServiseChooser);
            this.Controls.Add(this.HelpButton);
            this.Controls.Add(this.StartButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TaxiChoise";
            this.Load += new System.EventHandler(this.MainScreen_Load);
            this.SizeChanged += new System.EventHandler(this.MainScreen_SizeChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Button HelpButton;
        private System.Windows.Forms.CheckedListBox ServiseChooser;
        private System.Windows.Forms.Button HighestratingButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label DataLabel;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.TextBox Coord1Box;
        private System.Windows.Forms.TextBox Coord2Box;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Dest1Box;
        private System.Windows.Forms.TextBox Dest2Box;
        private System.Windows.Forms.ComboBox PlacesToGo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckedListBox ClassChooser;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox PlacesToGo2;
        private System.Windows.Forms.Button FinalButton;
        private System.Windows.Forms.Label ServiseLabel;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Button AllServisesButton;
        private System.Windows.Forms.Button AllClassesButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

