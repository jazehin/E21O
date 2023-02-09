namespace EletjatekGUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cbSor = new System.Windows.Forms.ComboBox();
            this.cbOszlop = new System.Windows.Forms.ComboBox();
            this.btnUres = new System.Windows.Forms.Button();
            this.btnMentes = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mátrix mérete [sor x oszlop]:";
            // 
            // cbSor
            // 
            this.cbSor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSor.FormattingEnabled = true;
            this.cbSor.Location = new System.Drawing.Point(175, 18);
            this.cbSor.Name = "cbSor";
            this.cbSor.Size = new System.Drawing.Size(56, 23);
            this.cbSor.TabIndex = 1;
            // 
            // cbOszlop
            // 
            this.cbOszlop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOszlop.FormattingEnabled = true;
            this.cbOszlop.Location = new System.Drawing.Point(237, 18);
            this.cbOszlop.Name = "cbOszlop";
            this.cbOszlop.Size = new System.Drawing.Size(56, 23);
            this.cbOszlop.TabIndex = 2;
            // 
            // btnUres
            // 
            this.btnUres.Location = new System.Drawing.Point(12, 59);
            this.btnUres.Name = "btnUres";
            this.btnUres.Size = new System.Drawing.Size(159, 23);
            this.btnUres.TabIndex = 3;
            this.btnUres.Text = "Üres mátrix létrehozása";
            this.btnUres.UseVisualStyleBackColor = true;
            this.btnUres.Click += new System.EventHandler(this.btnUres_Click);
            // 
            // btnMentes
            // 
            this.btnMentes.Location = new System.Drawing.Point(185, 59);
            this.btnMentes.Name = "btnMentes";
            this.btnMentes.Size = new System.Drawing.Size(108, 23);
            this.btnMentes.TabIndex = 4;
            this.btnMentes.Text = "Állás mentése";
            this.btnMentes.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(293, 244);
            this.panel1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 510);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnMentes);
            this.Controls.Add(this.btnUres);
            this.Controls.Add(this.cbOszlop);
            this.Controls.Add(this.cbSor);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Életjáték álláskészítő";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ComboBox cbSor;
        private ComboBox cbOszlop;
        private Button btnUres;
        private Button btnMentes;
        private Panel panel1;
    }
}