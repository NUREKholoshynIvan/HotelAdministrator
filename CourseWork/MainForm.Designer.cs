namespace CourseWork
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NewHotel = new System.Windows.Forms.Button();
            this.LoadHotel = new System.Windows.Forms.Button();
            this.CloseProgram = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(293, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(405, 353);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(32, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Адміністратор готелю";
            // 
            // NewHotel
            // 
            this.NewHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewHotel.Location = new System.Drawing.Point(39, 125);
            this.NewHotel.Name = "NewHotel";
            this.NewHotel.Size = new System.Drawing.Size(294, 49);
            this.NewHotel.TabIndex = 2;
            this.NewHotel.Text = "Новий готель";
            this.NewHotel.UseVisualStyleBackColor = true;
            this.NewHotel.Click += new System.EventHandler(this.NewHotel_Click);
            // 
            // LoadHotel
            // 
            this.LoadHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoadHotel.Location = new System.Drawing.Point(39, 180);
            this.LoadHotel.Name = "LoadHotel";
            this.LoadHotel.Size = new System.Drawing.Size(294, 49);
            this.LoadHotel.TabIndex = 3;
            this.LoadHotel.Text = "Завантажити готель";
            this.LoadHotel.UseVisualStyleBackColor = true;
            this.LoadHotel.Click += new System.EventHandler(this.LoadHotel_Click);
            // 
            // CloseProgram
            // 
            this.CloseProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseProgram.Location = new System.Drawing.Point(39, 299);
            this.CloseProgram.Name = "CloseProgram";
            this.CloseProgram.Size = new System.Drawing.Size(294, 49);
            this.CloseProgram.TabIndex = 4;
            this.CloseProgram.Text = "Закрити програму";
            this.CloseProgram.UseVisualStyleBackColor = true;
            this.CloseProgram.Click += new System.EventHandler(this.CloseProgram_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 360);
            this.Controls.Add(this.CloseProgram);
            this.Controls.Add(this.LoadHotel);
            this.Controls.Add(this.NewHotel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MainForm";
            this.Text = "Адміністратор готелю: Головне меню";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button NewHotel;
        private System.Windows.Forms.Button LoadHotel;
        private System.Windows.Forms.Button CloseProgram;
    }
}

