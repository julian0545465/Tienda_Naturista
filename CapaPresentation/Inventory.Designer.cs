namespace PresentationLayer
{
    partial class frmInventory
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
            this.label5 = new System.Windows.Forms.Label();
            this.txtProductI = new System.Windows.Forms.ComboBox();
            this.btnConsultarI = new System.Windows.Forms.Button();
            this.dataGridViewIn = new System.Windows.Forms.DataGridView();
            this.btnReturn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIn)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(323, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inventory";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(199, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Producto:";
            // 
            // txtProductI
            // 
            this.txtProductI.FormattingEnabled = true;
            this.txtProductI.Location = new System.Drawing.Point(302, 80);
            this.txtProductI.Name = "txtProductI";
            this.txtProductI.Size = new System.Drawing.Size(228, 23);
            this.txtProductI.TabIndex = 13;
            // 
            // btnConsultarI
            // 
            this.btnConsultarI.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnConsultarI.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConsultarI.Location = new System.Drawing.Point(328, 124);
            this.btnConsultarI.Name = "btnConsultarI";
            this.btnConsultarI.Size = new System.Drawing.Size(138, 28);
            this.btnConsultarI.TabIndex = 14;
            this.btnConsultarI.Text = "Consultar";
            this.btnConsultarI.UseVisualStyleBackColor = true;
            this.btnConsultarI.Click += new System.EventHandler(this.btnConsultarI_Click);
            // 
            // dataGridViewIn
            // 
            this.dataGridViewIn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIn.Location = new System.Drawing.Point(162, 181);
            this.dataGridViewIn.Name = "dataGridViewIn";
            this.dataGridViewIn.RowTemplate.Height = 25;
            this.dataGridViewIn.Size = new System.Drawing.Size(493, 110);
            this.dataGridViewIn.TabIndex = 15;
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReturn.Location = new System.Drawing.Point(25, 15);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(96, 32);
            this.btnReturn.TabIndex = 16;
            this.btnReturn.Text = "Devolverse";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // frmInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.dataGridViewIn);
            this.Controls.Add(this.btnConsultarI);
            this.Controls.Add(this.txtProductI);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "frmInventory";
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.frmInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label5;
        private ComboBox txtProductI;
        private Button btnConsultarI;
        private DataGridView dataGridViewIn;
        private Button btnReturn;
    }
}