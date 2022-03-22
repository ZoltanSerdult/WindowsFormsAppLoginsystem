
namespace WindowsFormsApp_Loginsystem
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_nev = new System.Windows.Forms.TextBox();
            this.textBox_jelszo = new System.Windows.Forms.TextBox();
            this.button_Be = new System.Windows.Forms.Button();
            this.label_allapot = new System.Windows.Forms.Label();
            this.listBox_jelenit = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(34, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Név";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(34, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Jelszó";
            // 
            // textBox_nev
            // 
            this.textBox_nev.Location = new System.Drawing.Point(125, 28);
            this.textBox_nev.Name = "textBox_nev";
            this.textBox_nev.Size = new System.Drawing.Size(100, 20);
            this.textBox_nev.TabIndex = 2;
            // 
            // textBox_jelszo
            // 
            this.textBox_jelszo.Location = new System.Drawing.Point(125, 79);
            this.textBox_jelszo.Name = "textBox_jelszo";
            this.textBox_jelszo.Size = new System.Drawing.Size(100, 20);
            this.textBox_jelszo.TabIndex = 3;
            // 
            // button_Be
            // 
            this.button_Be.Location = new System.Drawing.Point(39, 117);
            this.button_Be.Name = "button_Be";
            this.button_Be.Size = new System.Drawing.Size(186, 38);
            this.button_Be.TabIndex = 4;
            this.button_Be.Text = "Bejelentkezés";
            this.button_Be.UseVisualStyleBackColor = true;
            this.button_Be.Click += new System.EventHandler(this.button_Be_Click);
            // 
            // label_allapot
            // 
            this.label_allapot.AutoSize = true;
            this.label_allapot.Location = new System.Drawing.Point(56, 176);
            this.label_allapot.Name = "label_allapot";
            this.label_allapot.Size = new System.Drawing.Size(142, 13);
            this.label_allapot.TabIndex = 5;
            this.label_allapot.Text = "Irja be a nevét és a jelszavát";
            // 
            // listBox_jelenit
            // 
            this.listBox_jelenit.FormattingEnabled = true;
            this.listBox_jelenit.Location = new System.Drawing.Point(39, 262);
            this.listBox_jelenit.Name = "listBox_jelenit";
            this.listBox_jelenit.Size = new System.Drawing.Size(186, 82);
            this.listBox_jelenit.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "A login adatbázis nézet (Teszt céból)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 382);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox_jelenit);
            this.Controls.Add(this.label_allapot);
            this.Controls.Add(this.button_Be);
            this.Controls.Add(this.textBox_jelszo);
            this.Controls.Add(this.textBox_nev);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Bejelentkezés";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_nev;
        private System.Windows.Forms.TextBox textBox_jelszo;
        private System.Windows.Forms.Button button_Be;
        private System.Windows.Forms.Label label_allapot;
        private System.Windows.Forms.ListBox listBox_jelenit;
        private System.Windows.Forms.Label label3;
    }
}

