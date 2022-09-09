namespace Presentation
{
    partial class Seller
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
            this.btnReturnS = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlInsertClient = new System.Windows.Forms.Panel();
            this.btnCleanSeller = new System.Windows.Forms.Button();
            this.btnSaveSeller = new System.Windows.Forms.Button();
            this.txtPasswordSeller = new System.Windows.Forms.TextBox();
            this.txtUsserSeller = new System.Windows.Forms.TextBox();
            this.txtIdSeller = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlInsertClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReturnS
            // 
            this.btnReturnS.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReturnS.Location = new System.Drawing.Point(24, 48);
            this.btnReturnS.Name = "btnReturnS";
            this.btnReturnS.Size = new System.Drawing.Size(96, 32);
            this.btnReturnS.TabIndex = 25;
            this.btnReturnS.Text = "Devolverse";
            this.btnReturnS.UseVisualStyleBackColor = true;
            this.btnReturnS.Click += new System.EventHandler(this.btnReturnS_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(336, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 38);
            this.label1.TabIndex = 24;
            this.label1.Text = "Seller";
            // 
            // pnlInsertClient
            // 
            this.pnlInsertClient.Controls.Add(this.btnCleanSeller);
            this.pnlInsertClient.Controls.Add(this.btnSaveSeller);
            this.pnlInsertClient.Controls.Add(this.txtPasswordSeller);
            this.pnlInsertClient.Controls.Add(this.txtUsserSeller);
            this.pnlInsertClient.Controls.Add(this.txtIdSeller);
            this.pnlInsertClient.Controls.Add(this.label4);
            this.pnlInsertClient.Controls.Add(this.label3);
            this.pnlInsertClient.Controls.Add(this.label2);
            this.pnlInsertClient.Location = new System.Drawing.Point(48, 99);
            this.pnlInsertClient.Name = "pnlInsertClient";
            this.pnlInsertClient.Size = new System.Drawing.Size(728, 304);
            this.pnlInsertClient.TabIndex = 23;
            // 
            // btnCleanSeller
            // 
            this.btnCleanSeller.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCleanSeller.Location = new System.Drawing.Point(338, 225);
            this.btnCleanSeller.Name = "btnCleanSeller";
            this.btnCleanSeller.Size = new System.Drawing.Size(97, 38);
            this.btnCleanSeller.TabIndex = 18;
            this.btnCleanSeller.Text = "Limpiar";
            this.btnCleanSeller.UseVisualStyleBackColor = true;
            this.btnCleanSeller.Click += new System.EventHandler(this.btnCleanSeller_Click);
            // 
            // btnSaveSeller
            // 
            this.btnSaveSeller.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSaveSeller.Location = new System.Drawing.Point(238, 225);
            this.btnSaveSeller.Name = "btnSaveSeller";
            this.btnSaveSeller.Size = new System.Drawing.Size(84, 38);
            this.btnSaveSeller.TabIndex = 17;
            this.btnSaveSeller.Text = "Guardar";
            this.btnSaveSeller.UseVisualStyleBackColor = true;
            this.btnSaveSeller.Click += new System.EventHandler(this.btnSaveSeller_Click);
            // 
            // txtPasswordSeller
            // 
            this.txtPasswordSeller.Location = new System.Drawing.Point(361, 96);
            this.txtPasswordSeller.Name = "txtPasswordSeller";
            this.txtPasswordSeller.Size = new System.Drawing.Size(126, 23);
            this.txtPasswordSeller.TabIndex = 15;
            this.txtPasswordSeller.UseSystemPasswordChar = true;
            // 
            // txtUsserSeller
            // 
            this.txtUsserSeller.Location = new System.Drawing.Point(361, 60);
            this.txtUsserSeller.Name = "txtUsserSeller";
            this.txtUsserSeller.Size = new System.Drawing.Size(126, 23);
            this.txtUsserSeller.TabIndex = 14;
            // 
            // txtIdSeller
            // 
            this.txtIdSeller.Location = new System.Drawing.Point(361, 21);
            this.txtIdSeller.Name = "txtIdSeller";
            this.txtIdSeller.Size = new System.Drawing.Size(126, 23);
            this.txtIdSeller.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(203, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Usuario:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(203, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Contraseña";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(203, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "IdSeller:";
            // 
            // Seller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReturnS);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlInsertClient);
            this.Name = "Seller";
            this.Text = "Seller";
            this.pnlInsertClient.ResumeLayout(false);
            this.pnlInsertClient.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnReturnS;
        private Label label1;
        private Panel pnlInsertClient;
        private Button btnCleanSeller;
        private Button btnSaveSeller;
        private TextBox txtPasswordSeller;
        private TextBox txtUsserSeller;
        private TextBox txtIdSeller;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}