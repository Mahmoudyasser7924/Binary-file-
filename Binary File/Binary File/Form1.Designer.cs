namespace Binary_File
{
    partial class Form1
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
            this.Creatbtn = new System.Windows.Forms.Button();
            this.Deletebtn = new System.Windows.Forms.Button();
            this.Savebtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BirthDatel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Genderl = new System.Windows.Forms.Label();
            this.IDtxtBox = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.GendertxtBox = new System.Windows.Forms.TextBox();
            this.BirthDatetxtBox = new System.Windows.Forms.TextBox();
            this.FilenametextBox = new System.Windows.Forms.TextBox();
            this.displaybtn = new System.Windows.Forms.Button();
            this.searchbtn = new System.Windows.Forms.Button();
            this.errorlabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.name1txtBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.name2txtBox = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Creatbtn
            // 
            this.Creatbtn.Location = new System.Drawing.Point(33, 355);
            this.Creatbtn.Margin = new System.Windows.Forms.Padding(4);
            this.Creatbtn.Name = "Creatbtn";
            this.Creatbtn.Size = new System.Drawing.Size(100, 28);
            this.Creatbtn.TabIndex = 0;
            this.Creatbtn.Text = "creat";
            this.Creatbtn.UseVisualStyleBackColor = true;
            this.Creatbtn.Click += new System.EventHandler(this.Creat_Click);
            // 
            // Deletebtn
            // 
            this.Deletebtn.Location = new System.Drawing.Point(33, 391);
            this.Deletebtn.Margin = new System.Windows.Forms.Padding(4);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(100, 28);
            this.Deletebtn.TabIndex = 1;
            this.Deletebtn.Text = "Delete";
            this.Deletebtn.UseVisualStyleBackColor = true;
            this.Deletebtn.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Savebtn
            // 
            this.Savebtn.Location = new System.Drawing.Point(32, 427);
            this.Savebtn.Margin = new System.Windows.Forms.Padding(4);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(100, 28);
            this.Savebtn.TabIndex = 2;
            this.Savebtn.Text = "Save";
            this.Savebtn.UseVisualStyleBackColor = true;
            this.Savebtn.Click += new System.EventHandler(this.Savebtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Doctor_ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 152);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Phone";
            // 
            // BirthDatel
            // 
            this.BirthDatel.AutoSize = true;
            this.BirthDatel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BirthDatel.Location = new System.Drawing.Point(33, 243);
            this.BirthDatel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BirthDatel.Name = "BirthDatel";
            this.BirthDatel.Size = new System.Drawing.Size(70, 16);
            this.BirthDatel.TabIndex = 5;
            this.BirthDatel.Text = "BirthDate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 313);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "File name";
            // 
            // Genderl
            // 
            this.Genderl.AutoSize = true;
            this.Genderl.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Genderl.Location = new System.Drawing.Point(33, 193);
            this.Genderl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Genderl.Name = "Genderl";
            this.Genderl.Size = new System.Drawing.Size(54, 16);
            this.Genderl.TabIndex = 7;
            this.Genderl.Text = "Gender";
            // 
            // IDtxtBox
            // 
            this.IDtxtBox.Location = new System.Drawing.Point(178, 69);
            this.IDtxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.IDtxtBox.Name = "IDtxtBox";
            this.IDtxtBox.Size = new System.Drawing.Size(232, 23);
            this.IDtxtBox.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(178, 145);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(232, 23);
            this.textBox2.TabIndex = 10;
            // 
            // GendertxtBox
            // 
            this.GendertxtBox.Location = new System.Drawing.Point(178, 193);
            this.GendertxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.GendertxtBox.Name = "GendertxtBox";
            this.GendertxtBox.Size = new System.Drawing.Size(232, 23);
            this.GendertxtBox.TabIndex = 11;
            // 
            // BirthDatetxtBox
            // 
            this.BirthDatetxtBox.Location = new System.Drawing.Point(178, 236);
            this.BirthDatetxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.BirthDatetxtBox.Name = "BirthDatetxtBox";
            this.BirthDatetxtBox.Size = new System.Drawing.Size(232, 23);
            this.BirthDatetxtBox.TabIndex = 12;
            // 
            // FilenametextBox
            // 
            this.FilenametextBox.Location = new System.Drawing.Point(153, 313);
            this.FilenametextBox.Margin = new System.Windows.Forms.Padding(4);
            this.FilenametextBox.Name = "FilenametextBox";
            this.FilenametextBox.Size = new System.Drawing.Size(232, 23);
            this.FilenametextBox.TabIndex = 13;
            // 
            // displaybtn
            // 
            this.displaybtn.Location = new System.Drawing.Point(33, 463);
            this.displaybtn.Margin = new System.Windows.Forms.Padding(4);
            this.displaybtn.Name = "displaybtn";
            this.displaybtn.Size = new System.Drawing.Size(100, 28);
            this.displaybtn.TabIndex = 15;
            this.displaybtn.Text = "Display";
            this.displaybtn.UseVisualStyleBackColor = true;
            this.displaybtn.Click += new System.EventHandler(this.displaybtn_Click);
            // 
            // searchbtn
            // 
            this.searchbtn.Location = new System.Drawing.Point(33, 499);
            this.searchbtn.Margin = new System.Windows.Forms.Padding(4);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(100, 28);
            this.searchbtn.TabIndex = 16;
            this.searchbtn.Text = "Search";
            this.searchbtn.UseVisualStyleBackColor = true;
            // 
            // errorlabel
            // 
            this.errorlabel.AutoSize = true;
            this.errorlabel.ForeColor = System.Drawing.Color.DarkRed;
            this.errorlabel.Location = new System.Drawing.Point(153, 344);
            this.errorlabel.Name = "errorlabel";
            this.errorlabel.Size = new System.Drawing.Size(69, 16);
            this.errorlabel.TabIndex = 17;
            this.errorlabel.Text = "file exists";
            this.errorlabel.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "firstname";
            // 
            // name1txtBox
            // 
            this.name1txtBox.Location = new System.Drawing.Point(178, 103);
            this.name1txtBox.Name = "name1txtBox";
            this.name1txtBox.Size = new System.Drawing.Size(106, 23);
            this.name1txtBox.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(105, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Second";
            // 
            // name2txtBox
            // 
            this.name2txtBox.Location = new System.Drawing.Point(299, 103);
            this.name2txtBox.Name = "name2txtBox";
            this.name2txtBox.Size = new System.Drawing.Size(111, 23);
            this.name2txtBox.TabIndex = 21;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(294, 369);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(308, 166);
            this.richTextBox1.TabIndex = 22;
            this.richTextBox1.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(221, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 19);
            this.label6.TabIndex = 23;
            this.label6.Text = "Doctor Information";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 547);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.name2txtBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.name1txtBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.errorlabel);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.displaybtn);
            this.Controls.Add(this.FilenametextBox);
            this.Controls.Add(this.BirthDatetxtBox);
            this.Controls.Add(this.GendertxtBox);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.IDtxtBox);
            this.Controls.Add(this.Genderl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BirthDatel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Savebtn);
            this.Controls.Add(this.Deletebtn);
            this.Controls.Add(this.Creatbtn);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Clinic";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Creatbtn;
        private System.Windows.Forms.Button Deletebtn;
        private System.Windows.Forms.Button Savebtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label BirthDatel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Genderl;
        private System.Windows.Forms.TextBox IDtxtBox;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox GendertxtBox;
        private System.Windows.Forms.TextBox BirthDatetxtBox;
        private System.Windows.Forms.TextBox FilenametextBox;
        private System.Windows.Forms.Button displaybtn;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.Label errorlabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox name1txtBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox name2txtBox;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label6;
    }
}

