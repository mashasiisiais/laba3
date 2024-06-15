namespace laba3
{
    partial class fMain
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
            this.tbAbonentsInfo = new System.Windows.Forms.TextBox();
            this.btnAddAbonent = new System.Windows.Forms.Button();
            this.btnAddClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbAbonentsInfo
            // 
            this.tbAbonentsInfo.Location = new System.Drawing.Point(12, 12);
            this.tbAbonentsInfo.Multiline = true;
            this.tbAbonentsInfo.Name = "tbAbonentsInfo";
            this.tbAbonentsInfo.ReadOnly = true;
            this.tbAbonentsInfo.Size = new System.Drawing.Size(652, 426);
            this.tbAbonentsInfo.TabIndex = 0;
           
            // 
            // btnAddAbonent
            // 
            this.btnAddAbonent.Location = new System.Drawing.Point(670, 27);
            this.btnAddAbonent.Name = "btnAddAbonent";
            this.btnAddAbonent.Size = new System.Drawing.Size(118, 43);
            this.btnAddAbonent.TabIndex = 1;
            this.btnAddAbonent.Text = "Додати абонента";
            this.btnAddAbonent.UseVisualStyleBackColor = true;
            this.btnAddAbonent.Click += new System.EventHandler(this.btnAddAbonent_Click);
            // 
            // btnAddClose
            // 
            this.btnAddClose.Location = new System.Drawing.Point(670, 387);
            this.btnAddClose.Name = "btnAddClose";
            this.btnAddClose.Size = new System.Drawing.Size(118, 23);
            this.btnAddClose.TabIndex = 2;
            this.btnAddClose.Text = "Закрити";
            this.btnAddClose.UseVisualStyleBackColor = true;
            this.btnAddClose.Click += new System.EventHandler(this.btnAddClose_Click);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddClose);
            this.Controls.Add(this.btnAddAbonent);
            this.Controls.Add(this.tbAbonentsInfo);
            this.MaximizeBox = false;
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лабораторна робота3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbAbonentsInfo;
        private System.Windows.Forms.Button btnAddAbonent;
        private System.Windows.Forms.Button btnAddClose;
    }
}

