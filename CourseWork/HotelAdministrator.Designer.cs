namespace CourseWork
{
    partial class HotelAdministrator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.SettleButton = new System.Windows.Forms.Button();
            this.UnSettleButton = new System.Windows.Forms.Button();
            this.RoomsList = new System.Windows.Forms.Button();
            this.VisitorsList = new System.Windows.Forms.Button();
            this.TodayDate = new System.Windows.Forms.Label();
            this.SkipDay = new System.Windows.Forms.Button();
            this.UnsettlingTodayButton = new System.Windows.Forms.Button();
            this.AddDaysButton = new System.Windows.Forms.Button();
            this.SearchVisitorsButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(27, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Управління номерами";
            // 
            // SettleButton
            // 
            this.SettleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SettleButton.Location = new System.Drawing.Point(33, 122);
            this.SettleButton.Name = "SettleButton";
            this.SettleButton.Size = new System.Drawing.Size(355, 60);
            this.SettleButton.TabIndex = 2;
            this.SettleButton.Text = "Заселення";
            this.SettleButton.UseVisualStyleBackColor = true;
            this.SettleButton.Click += new System.EventHandler(this.SettleButton_Click);
            // 
            // UnSettleButton
            // 
            this.UnSettleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UnSettleButton.Location = new System.Drawing.Point(394, 122);
            this.UnSettleButton.Name = "UnSettleButton";
            this.UnSettleButton.Size = new System.Drawing.Size(355, 60);
            this.UnSettleButton.TabIndex = 3;
            this.UnSettleButton.Text = "Виселення";
            this.UnSettleButton.UseVisualStyleBackColor = true;
            this.UnSettleButton.Click += new System.EventHandler(this.UnSettleButton_Click);
            // 
            // RoomsList
            // 
            this.RoomsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RoomsList.Location = new System.Drawing.Point(33, 233);
            this.RoomsList.Name = "RoomsList";
            this.RoomsList.Size = new System.Drawing.Size(355, 60);
            this.RoomsList.TabIndex = 4;
            this.RoomsList.Text = "Список номерів";
            this.RoomsList.UseVisualStyleBackColor = true;
            this.RoomsList.Click += new System.EventHandler(this.RoomsList_Click);
            // 
            // VisitorsList
            // 
            this.VisitorsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VisitorsList.Location = new System.Drawing.Point(394, 233);
            this.VisitorsList.Name = "VisitorsList";
            this.VisitorsList.Size = new System.Drawing.Size(355, 60);
            this.VisitorsList.TabIndex = 5;
            this.VisitorsList.Text = "Список гостей";
            this.VisitorsList.UseVisualStyleBackColor = true;
            this.VisitorsList.Click += new System.EventHandler(this.VisitorsList_Click);
            // 
            // TodayDate
            // 
            this.TodayDate.AutoSize = true;
            this.TodayDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TodayDate.Location = new System.Drawing.Point(27, 27);
            this.TodayDate.Name = "TodayDate";
            this.TodayDate.Size = new System.Drawing.Size(171, 36);
            this.TodayDate.TabIndex = 6;
            this.TodayDate.Text = "13-06-2024";
            // 
            // SkipDay
            // 
            this.SkipDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SkipDay.Location = new System.Drawing.Point(208, 27);
            this.SkipDay.Name = "SkipDay";
            this.SkipDay.Size = new System.Drawing.Size(35, 35);
            this.SkipDay.TabIndex = 7;
            this.SkipDay.Text = ">";
            this.SkipDay.UseVisualStyleBackColor = true;
            this.SkipDay.Click += new System.EventHandler(this.SkipDay_Click);
            // 
            // UnsettlingTodayButton
            // 
            this.UnsettlingTodayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UnsettlingTodayButton.Location = new System.Drawing.Point(755, 233);
            this.UnsettlingTodayButton.Name = "UnsettlingTodayButton";
            this.UnsettlingTodayButton.Size = new System.Drawing.Size(355, 60);
            this.UnsettlingTodayButton.TabIndex = 8;
            this.UnsettlingTodayButton.Text = "Список від\'їжджаючих сьогодні";
            this.UnsettlingTodayButton.UseVisualStyleBackColor = true;
            this.UnsettlingTodayButton.Click += new System.EventHandler(this.UnsettlingTodayButton_Click);
            // 
            // AddDaysButton
            // 
            this.AddDaysButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddDaysButton.Location = new System.Drawing.Point(755, 122);
            this.AddDaysButton.Name = "AddDaysButton";
            this.AddDaysButton.Size = new System.Drawing.Size(355, 60);
            this.AddDaysButton.TabIndex = 9;
            this.AddDaysButton.Text = "Подовжити бронювання";
            this.AddDaysButton.UseVisualStyleBackColor = true;
            this.AddDaysButton.Click += new System.EventHandler(this.AddDaysButton_Click);
            // 
            // SearchVisitorsButton
            // 
            this.SearchVisitorsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchVisitorsButton.Location = new System.Drawing.Point(33, 299);
            this.SearchVisitorsButton.Name = "SearchVisitorsButton";
            this.SearchVisitorsButton.Size = new System.Drawing.Size(355, 60);
            this.SearchVisitorsButton.TabIndex = 10;
            this.SearchVisitorsButton.Text = "Пошук відвідувачів";
            this.SearchVisitorsButton.UseVisualStyleBackColor = true;
            this.SearchVisitorsButton.Click += new System.EventHandler(this.SearchVisitorsButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveButton.Location = new System.Drawing.Point(755, 445);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(355, 60);
            this.SaveButton.TabIndex = 11;
            this.SaveButton.Text = "Зберегти готель";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // HotelAdministrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 517);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.SearchVisitorsButton);
            this.Controls.Add(this.AddDaysButton);
            this.Controls.Add(this.UnsettlingTodayButton);
            this.Controls.Add(this.SkipDay);
            this.Controls.Add(this.TodayDate);
            this.Controls.Add(this.VisitorsList);
            this.Controls.Add(this.RoomsList);
            this.Controls.Add(this.UnSettleButton);
            this.Controls.Add(this.SettleButton);
            this.Controls.Add(this.label1);
            this.Name = "HotelAdministrator";
            this.Text = "Адміністратор готелю";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SettleButton;
        private System.Windows.Forms.Button UnSettleButton;
        private System.Windows.Forms.Button RoomsList;
        private System.Windows.Forms.Button VisitorsList;
        private System.Windows.Forms.Label TodayDate;
        private System.Windows.Forms.Button SkipDay;
        private System.Windows.Forms.Button UnsettlingTodayButton;
        private System.Windows.Forms.Button AddDaysButton;
        private System.Windows.Forms.Button SearchVisitorsButton;
        private System.Windows.Forms.Button SaveButton;
    }
}