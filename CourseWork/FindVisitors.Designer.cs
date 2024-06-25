namespace CourseWork
{
    partial class FindVisitors
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
            this.NameCheckBox = new System.Windows.Forms.CheckBox();
            this.NameToSearch = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SurnameToSearch = new System.Windows.Forms.TextBox();
            this.SurameCheckBox = new System.Windows.Forms.CheckBox();
            this.TextBox = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Пошук відвідувачів";
            // 
            // NameCheckBox
            // 
            this.NameCheckBox.AutoSize = true;
            this.NameCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameCheckBox.Location = new System.Drawing.Point(18, 81);
            this.NameCheckBox.Name = "NameCheckBox";
            this.NameCheckBox.Size = new System.Drawing.Size(15, 14);
            this.NameCheckBox.TabIndex = 3;
            this.NameCheckBox.UseVisualStyleBackColor = true;
            this.NameCheckBox.CheckedChanged += new System.EventHandler(this.NameCheckBox_CheckedChanged);
            // 
            // NameToSearch
            // 
            this.NameToSearch.Enabled = false;
            this.NameToSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameToSearch.Location = new System.Drawing.Point(39, 72);
            this.NameToSearch.Name = "NameToSearch";
            this.NameToSearch.Size = new System.Drawing.Size(118, 29);
            this.NameToSearch.TabIndex = 4;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.Location = new System.Drawing.Point(14, 45);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(41, 24);
            this.NameLabel.TabIndex = 10;
            this.NameLabel.Text = "Ім\'я";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(182, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Фамілія";
            // 
            // SurnameToSearch
            // 
            this.SurnameToSearch.Enabled = false;
            this.SurnameToSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SurnameToSearch.Location = new System.Drawing.Point(207, 72);
            this.SurnameToSearch.Name = "SurnameToSearch";
            this.SurnameToSearch.Size = new System.Drawing.Size(118, 29);
            this.SurnameToSearch.TabIndex = 13;
            // 
            // SurameCheckBox
            // 
            this.SurameCheckBox.AutoSize = true;
            this.SurameCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SurameCheckBox.Location = new System.Drawing.Point(186, 81);
            this.SurameCheckBox.Name = "SurameCheckBox";
            this.SurameCheckBox.Size = new System.Drawing.Size(15, 14);
            this.SurameCheckBox.TabIndex = 12;
            this.SurameCheckBox.UseVisualStyleBackColor = true;
            this.SurameCheckBox.CheckedChanged += new System.EventHandler(this.SurameCheckBox_CheckedChanged);
            // 
            // TextBox
            // 
            this.TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBox.Location = new System.Drawing.Point(17, 138);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(638, 298);
            this.TextBox.TabIndex = 14;
            this.TextBox.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 26);
            this.label3.TabIndex = 15;
            this.label3.Text = "Знайдені відвідувачі";
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchButton.Location = new System.Drawing.Point(17, 442);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(638, 43);
            this.SearchButton.TabIndex = 16;
            this.SearchButton.Text = "Шукати";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // FindVisitors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 497);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.SurnameToSearch);
            this.Controls.Add(this.SurameCheckBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.NameToSearch);
            this.Controls.Add(this.NameCheckBox);
            this.Controls.Add(this.label1);
            this.Name = "FindVisitors";
            this.Text = "Пошук відвідувачів";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox NameCheckBox;
        private System.Windows.Forms.TextBox NameToSearch;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SurnameToSearch;
        private System.Windows.Forms.CheckBox SurameCheckBox;
        private System.Windows.Forms.RichTextBox TextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SearchButton;
    }
}