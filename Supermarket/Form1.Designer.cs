namespace Supermarket
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
            this.lbProdukt = new System.Windows.Forms.Label();
            this.lbAnzahl = new System.Windows.Forms.Label();
            this.tbProdukt = new System.Windows.Forms.TextBox();
            this.tbAnzahl = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.listProdukt = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbProdukt
            // 
            this.lbProdukt.AutoSize = true;
            this.lbProdukt.Location = new System.Drawing.Point(51, 53);
            this.lbProdukt.Name = "lbProdukt";
            this.lbProdukt.Size = new System.Drawing.Size(57, 17);
            this.lbProdukt.TabIndex = 0;
            this.lbProdukt.Text = "Produkt";
            // 
            // lbAnzahl
            // 
            this.lbAnzahl.AutoSize = true;
            this.lbAnzahl.Location = new System.Drawing.Point(351, 53);
            this.lbAnzahl.Name = "lbAnzahl";
            this.lbAnzahl.Size = new System.Drawing.Size(51, 17);
            this.lbAnzahl.TabIndex = 1;
            this.lbAnzahl.Text = "Anzahl";
            // 
            // tbProdukt
            // 
            this.tbProdukt.Location = new System.Drawing.Point(123, 50);
            this.tbProdukt.Name = "tbProdukt";
            this.tbProdukt.Size = new System.Drawing.Size(211, 22);
            this.tbProdukt.TabIndex = 2;
            // 
            // tbAnzahl
            // 
            this.tbAnzahl.Location = new System.Drawing.Point(408, 50);
            this.tbAnzahl.Name = "tbAnzahl";
            this.tbAnzahl.Size = new System.Drawing.Size(80, 22);
            this.tbAnzahl.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(518, 46);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(119, 30);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Hizufügen";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(643, 46);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(119, 30);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Entfernen";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // listProdukt
            // 
            this.listProdukt.FormattingEnabled = true;
            this.listProdukt.ItemHeight = 16;
            this.listProdukt.Location = new System.Drawing.Point(25, 92);
            this.listProdukt.Name = "listProdukt";
            this.listProdukt.Size = new System.Drawing.Size(376, 340);
            this.listProdukt.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listProdukt);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbAnzahl);
            this.Controls.Add(this.tbProdukt);
            this.Controls.Add(this.lbAnzahl);
            this.Controls.Add(this.lbProdukt);
            this.Name = "Form1";
            this.Text = "Supermarket";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbProdukt;
        private System.Windows.Forms.Label lbAnzahl;
        private System.Windows.Forms.TextBox tbProdukt;
        private System.Windows.Forms.TextBox tbAnzahl;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ListBox listProdukt;
    }
}

