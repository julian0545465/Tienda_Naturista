namespace PresentationLayer
{
    partial class frmInvoice
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
            this.Vendedor = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtQuantityF = new System.Windows.Forms.TextBox();
            this.txtClientF = new System.Windows.Forms.ComboBox();
            this.txtProductF = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnFinishF = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.comboBoxVendedor = new System.Windows.Forms.ComboBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(307, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Facturación";
            // 
            // Vendedor
            // 
            this.Vendedor.AutoSize = true;
            this.Vendedor.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Vendedor.Location = new System.Drawing.Point(101, 91);
            this.Vendedor.Name = "Vendedor";
            this.Vendedor.Size = new System.Drawing.Size(77, 20);
            this.Vendedor.TabIndex = 1;
            this.Vendedor.Text = "Vendedor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(424, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(101, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cliente:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(101, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Producto:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(101, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Cantidad:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(511, 88);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // txtQuantityF
            // 
            this.txtQuantityF.Location = new System.Drawing.Point(213, 216);
            this.txtQuantityF.Name = "txtQuantityF";
            this.txtQuantityF.Size = new System.Drawing.Size(191, 23);
            this.txtQuantityF.TabIndex = 10;
            // 
            // txtClientF
            // 
            this.txtClientF.FormattingEnabled = true;
            this.txtClientF.Location = new System.Drawing.Point(213, 135);
            this.txtClientF.Name = "txtClientF";
            this.txtClientF.Size = new System.Drawing.Size(498, 23);
            this.txtClientF.TabIndex = 11;
            // 
            // txtProductF
            // 
            this.txtProductF.FormattingEnabled = true;
            this.txtProductF.Location = new System.Drawing.Point(213, 175);
            this.txtProductF.Name = "txtProductF";
            this.txtProductF.Size = new System.Drawing.Size(191, 23);
            this.txtProductF.TabIndex = 12;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.Location = new System.Drawing.Point(528, 218);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(173, 25);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = " Agregar producto";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnFinishF
            // 
            this.btnFinishF.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFinishF.Location = new System.Drawing.Point(101, 362);
            this.btnFinishF.Name = "btnFinishF";
            this.btnFinishF.Size = new System.Drawing.Size(173, 25);
            this.btnFinishF.TabIndex = 15;
            this.btnFinishF.Text = "Terminar Factura";
            this.btnFinishF.UseVisualStyleBackColor = true;
       
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(424, 367);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Total Factura:";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(528, 368);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(191, 23);
            this.txtTotal.TabIndex = 17;
            // 
            // comboBoxVendedor
            // 
            this.comboBoxVendedor.FormattingEnabled = true;
            this.comboBoxVendedor.Location = new System.Drawing.Point(213, 88);
            this.comboBoxVendedor.Name = "comboBoxVendedor";
            this.comboBoxVendedor.Size = new System.Drawing.Size(191, 23);
            this.comboBoxVendedor.TabIndex = 18;
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReturn.Location = new System.Drawing.Point(53, 27);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(95, 29);
            this.btnReturn.TabIndex = 19;
            this.btnReturn.Text = "Devolverse";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Codigo";
            this.Column1.Name = "Column1";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView2.Location = new System.Drawing.Point(182, 268);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(468, 88);
            this.dataGridView2.TabIndex = 20;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Codigo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Producto";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Cantidad";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Valor";
            this.Column4.Name = "Column4";
            // 
            // frmInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.comboBoxVendedor);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnFinishF);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtProductF);
            this.Controls.Add(this.txtClientF);
            this.Controls.Add(this.txtQuantityF);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Vendedor);
            this.Controls.Add(this.label1);
            this.Name = "frmInvoice";
            this.Text = "Invoice";
            this.Load += new System.EventHandler(this.frmInvoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label Vendedor;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private DateTimePicker dateTimePicker1;
        private TextBox txtQuantityF;
        private ComboBox txtClientF;
        private ComboBox txtProductF;
        private Button btnAdd;
        private Button btnFinishF;
        private Label label7;
        private TextBox txtTotal;
        private ComboBox comboBoxVendedor;
        private Button btnReturn;
        private DataGridViewTextBoxColumn Column1;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }
}