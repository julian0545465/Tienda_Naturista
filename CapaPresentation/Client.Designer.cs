namespace Presentation
{
    partial class frmClient
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ingresarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlDeleteCli = new System.Windows.Forms.Panel();
            this.btnDeleteC = new System.Windows.Forms.Button();
            this.comboBoxDelete = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.pnlModifyClient = new System.Windows.Forms.Panel();
            this.txtEmailCliM = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSaveChangeCliM = new System.Windows.Forms.Button();
            this.txtNumberphoneCliM = new System.Windows.Forms.TextBox();
            this.txtAddressCliM = new System.Windows.Forms.TextBox();
            this.txtNameCliM = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBoxModify = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnConsultCliM = new System.Windows.Forms.Button();
            this.pnlInsertClient = new System.Windows.Forms.Panel();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCleanCli = new System.Windows.Forms.Button();
            this.btnSaveCli = new System.Windows.Forms.Button();
            this.txtNumberphone = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDocument = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlConsultClient = new System.Windows.Forms.Panel();
            this.dataGridViewCli = new System.Windows.Forms.DataGridView();
            this.txtSearchC = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnConsultCliC = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.pnlDeleteCli.SuspendLayout();
            this.pnlModifyClient.SuspendLayout();
            this.pnlInsertClient.SuspendLayout();
            this.pnlConsultClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCli)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(338, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cliente";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.menuStrip1);
            this.groupBox1.Controls.Add(this.pnlDeleteCli);
            this.groupBox1.Controls.Add(this.pnlModifyClient);
            this.groupBox1.Controls.Add(this.pnlInsertClient);
            this.groupBox1.Controls.Add(this.pnlConsultClient);
            this.groupBox1.Location = new System.Drawing.Point(25, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 365);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gestion Cliente";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarClienteToolStripMenuItem,
            this.consultarClienteToolStripMenuItem,
            this.modificarClienteToolStripMenuItem,
            this.eliminarClienteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 19);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(769, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ingresarClienteToolStripMenuItem
            // 
            this.ingresarClienteToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ingresarClienteToolStripMenuItem.Name = "ingresarClienteToolStripMenuItem";
            this.ingresarClienteToolStripMenuItem.Size = new System.Drawing.Size(124, 24);
            this.ingresarClienteToolStripMenuItem.Text = "Ingresar Cliente";
            this.ingresarClienteToolStripMenuItem.Click += new System.EventHandler(this.ingresarClienteToolStripMenuItem_Click);
            // 
            // consultarClienteToolStripMenuItem
            // 
            this.consultarClienteToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.consultarClienteToolStripMenuItem.Name = "consultarClienteToolStripMenuItem";
            this.consultarClienteToolStripMenuItem.Size = new System.Drawing.Size(133, 24);
            this.consultarClienteToolStripMenuItem.Text = "Consultar Cliente";
            this.consultarClienteToolStripMenuItem.Click += new System.EventHandler(this.consultarClienteToolStripMenuItem_Click);
            // 
            // modificarClienteToolStripMenuItem
            // 
            this.modificarClienteToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.modificarClienteToolStripMenuItem.Name = "modificarClienteToolStripMenuItem";
            this.modificarClienteToolStripMenuItem.Size = new System.Drawing.Size(135, 24);
            this.modificarClienteToolStripMenuItem.Text = "Modificar Cliente";
            this.modificarClienteToolStripMenuItem.Click += new System.EventHandler(this.modificarClienteToolStripMenuItem_Click);
            // 
            // eliminarClienteToolStripMenuItem
            // 
            this.eliminarClienteToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.eliminarClienteToolStripMenuItem.Name = "eliminarClienteToolStripMenuItem";
            this.eliminarClienteToolStripMenuItem.Size = new System.Drawing.Size(125, 24);
            this.eliminarClienteToolStripMenuItem.Text = "Eliminar Cliente";
            this.eliminarClienteToolStripMenuItem.Click += new System.EventHandler(this.eliminarClienteToolStripMenuItem_Click);
            // 
            // pnlDeleteCli
            // 
            this.pnlDeleteCli.Controls.Add(this.btnDeleteC);
            this.pnlDeleteCli.Controls.Add(this.comboBoxDelete);
            this.pnlDeleteCli.Controls.Add(this.label16);
            this.pnlDeleteCli.Location = new System.Drawing.Point(17, 50);
            this.pnlDeleteCli.Name = "pnlDeleteCli";
            this.pnlDeleteCli.Size = new System.Drawing.Size(746, 318);
            this.pnlDeleteCli.TabIndex = 35;
            // 
            // btnDeleteC
            // 
            this.btnDeleteC.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteC.Location = new System.Drawing.Point(276, 60);
            this.btnDeleteC.Name = "btnDeleteC";
            this.btnDeleteC.Size = new System.Drawing.Size(84, 37);
            this.btnDeleteC.TabIndex = 27;
            this.btnDeleteC.Text = "Eliminar";
            this.btnDeleteC.UseVisualStyleBackColor = true;
            this.btnDeleteC.Click += new System.EventHandler(this.btnDeleteC_Click);
            // 
            // comboBoxDelete
            // 
            this.comboBoxDelete.FormattingEnabled = true;
            this.comboBoxDelete.Location = new System.Drawing.Point(275, 13);
            this.comboBoxDelete.Name = "comboBoxDelete";
            this.comboBoxDelete.Size = new System.Drawing.Size(263, 23);
            this.comboBoxDelete.TabIndex = 26;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(161, 17);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 20);
            this.label16.TabIndex = 17;
            this.label16.Text = "Cliente";
            // 
            // pnlModifyClient
            // 
            this.pnlModifyClient.Controls.Add(this.txtEmailCliM);
            this.pnlModifyClient.Controls.Add(this.label7);
            this.pnlModifyClient.Controls.Add(this.btnSaveChangeCliM);
            this.pnlModifyClient.Controls.Add(this.txtNumberphoneCliM);
            this.pnlModifyClient.Controls.Add(this.txtAddressCliM);
            this.pnlModifyClient.Controls.Add(this.txtNameCliM);
            this.pnlModifyClient.Controls.Add(this.label8);
            this.pnlModifyClient.Controls.Add(this.label10);
            this.pnlModifyClient.Controls.Add(this.label12);
            this.pnlModifyClient.Controls.Add(this.comboBoxModify);
            this.pnlModifyClient.Controls.Add(this.label9);
            this.pnlModifyClient.Controls.Add(this.btnConsultCliM);
            this.pnlModifyClient.Location = new System.Drawing.Point(17, 50);
            this.pnlModifyClient.Name = "pnlModifyClient";
            this.pnlModifyClient.Size = new System.Drawing.Size(746, 318);
            this.pnlModifyClient.TabIndex = 21;
            // 
            // txtEmailCliM
            // 
            this.txtEmailCliM.Location = new System.Drawing.Point(392, 203);
            this.txtEmailCliM.Name = "txtEmailCliM";
            this.txtEmailCliM.Size = new System.Drawing.Size(126, 23);
            this.txtEmailCliM.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(234, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 20);
            this.label7.TabIndex = 33;
            this.label7.Text = "Email:";
            // 
            // btnSaveChangeCliM
            // 
            this.btnSaveChangeCliM.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSaveChangeCliM.Location = new System.Drawing.Point(296, 228);
            this.btnSaveChangeCliM.Name = "btnSaveChangeCliM";
            this.btnSaveChangeCliM.Size = new System.Drawing.Size(145, 35);
            this.btnSaveChangeCliM.TabIndex = 22;
            this.btnSaveChangeCliM.Text = "Guardar Cambios";
            this.btnSaveChangeCliM.UseVisualStyleBackColor = true;
            this.btnSaveChangeCliM.Click += new System.EventHandler(this.btnSaveChangeCliM_Click);
            // 
            // txtNumberphoneCliM
            // 
            this.txtNumberphoneCliM.Location = new System.Drawing.Point(392, 165);
            this.txtNumberphoneCliM.Name = "txtNumberphoneCliM";
            this.txtNumberphoneCliM.Size = new System.Drawing.Size(126, 23);
            this.txtNumberphoneCliM.TabIndex = 32;
            // 
            // txtAddressCliM
            // 
            this.txtAddressCliM.Location = new System.Drawing.Point(392, 131);
            this.txtAddressCliM.Name = "txtAddressCliM";
            this.txtAddressCliM.Size = new System.Drawing.Size(126, 23);
            this.txtAddressCliM.TabIndex = 31;
            // 
            // txtNameCliM
            // 
            this.txtNameCliM.Location = new System.Drawing.Point(392, 95);
            this.txtNameCliM.Name = "txtNameCliM";
            this.txtNameCliM.Size = new System.Drawing.Size(126, 23);
            this.txtNameCliM.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(234, 168);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 20);
            this.label8.TabIndex = 29;
            this.label8.Text = "Telefono:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(234, 94);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 20);
            this.label10.TabIndex = 27;
            this.label10.Text = "Nombre:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(234, 130);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 20);
            this.label12.TabIndex = 28;
            this.label12.Text = "Direccion:";
            // 
            // comboBoxModify
            // 
            this.comboBoxModify.FormattingEnabled = true;
            this.comboBoxModify.Location = new System.Drawing.Point(275, 13);
            this.comboBoxModify.Name = "comboBoxModify";
            this.comboBoxModify.Size = new System.Drawing.Size(263, 23);
            this.comboBoxModify.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(161, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "Cliente";
            // 
            // btnConsultCliM
            // 
            this.btnConsultCliM.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConsultCliM.Location = new System.Drawing.Point(318, 50);
            this.btnConsultCliM.Name = "btnConsultCliM";
            this.btnConsultCliM.Size = new System.Drawing.Size(84, 38);
            this.btnConsultCliM.TabIndex = 18;
            this.btnConsultCliM.Text = "Consultar";
            this.btnConsultCliM.UseVisualStyleBackColor = true;
            this.btnConsultCliM.Click += new System.EventHandler(this.btnConsultCliM_Click);
            // 
            // pnlInsertClient
            // 
            this.pnlInsertClient.Controls.Add(this.txtEmail);
            this.pnlInsertClient.Controls.Add(this.label6);
            this.pnlInsertClient.Controls.Add(this.btnCleanCli);
            this.pnlInsertClient.Controls.Add(this.btnSaveCli);
            this.pnlInsertClient.Controls.Add(this.txtNumberphone);
            this.pnlInsertClient.Controls.Add(this.txtAddress);
            this.pnlInsertClient.Controls.Add(this.txtName);
            this.pnlInsertClient.Controls.Add(this.txtDocument);
            this.pnlInsertClient.Controls.Add(this.label5);
            this.pnlInsertClient.Controls.Add(this.label4);
            this.pnlInsertClient.Controls.Add(this.label3);
            this.pnlInsertClient.Controls.Add(this.label2);
            this.pnlInsertClient.Location = new System.Drawing.Point(17, 50);
            this.pnlInsertClient.Name = "pnlInsertClient";
            this.pnlInsertClient.Size = new System.Drawing.Size(728, 304);
            this.pnlInsertClient.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(361, 168);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(126, 23);
            this.txtEmail.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(203, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Email:";
            // 
            // btnCleanCli
            // 
            this.btnCleanCli.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCleanCli.Location = new System.Drawing.Point(338, 225);
            this.btnCleanCli.Name = "btnCleanCli";
            this.btnCleanCli.Size = new System.Drawing.Size(97, 38);
            this.btnCleanCli.TabIndex = 18;
            this.btnCleanCli.Text = "Limpiar";
            this.btnCleanCli.UseVisualStyleBackColor = true;
            this.btnCleanCli.Click += new System.EventHandler(this.btnCleanCli_Click);
            // 
            // btnSaveCli
            // 
            this.btnSaveCli.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSaveCli.Location = new System.Drawing.Point(238, 225);
            this.btnSaveCli.Name = "btnSaveCli";
            this.btnSaveCli.Size = new System.Drawing.Size(84, 38);
            this.btnSaveCli.TabIndex = 17;
            this.btnSaveCli.Text = "Guardar";
            this.btnSaveCli.UseVisualStyleBackColor = true;
            this.btnSaveCli.Click += new System.EventHandler(this.btnSaveCli_Click);
            // 
            // txtNumberphone
            // 
            this.txtNumberphone.Location = new System.Drawing.Point(361, 130);
            this.txtNumberphone.Name = "txtNumberphone";
            this.txtNumberphone.Size = new System.Drawing.Size(126, 23);
            this.txtNumberphone.TabIndex = 16;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(361, 96);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(126, 23);
            this.txtAddress.TabIndex = 15;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(361, 60);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(126, 23);
            this.txtName.TabIndex = 14;
            // 
            // txtDocument
            // 
            this.txtDocument.Location = new System.Drawing.Point(361, 21);
            this.txtDocument.Name = "txtDocument";
            this.txtDocument.Size = new System.Drawing.Size(126, 23);
            this.txtDocument.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(203, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Telefono:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(203, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(203, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Direccion:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(203, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Documento:";
            // 
            // pnlConsultClient
            // 
            this.pnlConsultClient.Controls.Add(this.dataGridViewCli);
            this.pnlConsultClient.Controls.Add(this.txtSearchC);
            this.pnlConsultClient.Controls.Add(this.label11);
            this.pnlConsultClient.Controls.Add(this.btnConsultCliC);
            this.pnlConsultClient.Location = new System.Drawing.Point(14, 50);
            this.pnlConsultClient.Name = "pnlConsultClient";
            this.pnlConsultClient.Size = new System.Drawing.Size(746, 318);
            this.pnlConsultClient.TabIndex = 36;
            // 
            // dataGridViewCli
            // 
            this.dataGridViewCli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCli.Location = new System.Drawing.Point(74, 124);
            this.dataGridViewCli.Name = "dataGridViewCli";
            this.dataGridViewCli.RowTemplate.Height = 25;
            this.dataGridViewCli.Size = new System.Drawing.Size(606, 90);
            this.dataGridViewCli.TabIndex = 27;
            // 
            // txtSearchC
            // 
            this.txtSearchC.FormattingEnabled = true;
            this.txtSearchC.Location = new System.Drawing.Point(275, 13);
            this.txtSearchC.Name = "txtSearchC";
            this.txtSearchC.Size = new System.Drawing.Size(263, 23);
            this.txtSearchC.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(161, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 20);
            this.label11.TabIndex = 17;
            this.label11.Text = "Cliente";
            // 
            // btnConsultCliC
            // 
            this.btnConsultCliC.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConsultCliC.Location = new System.Drawing.Point(318, 50);
            this.btnConsultCliC.Name = "btnConsultCliC";
            this.btnConsultCliC.Size = new System.Drawing.Size(84, 38);
            this.btnConsultCliC.TabIndex = 18;
            this.btnConsultCliC.Text = "Consultar";
            this.btnConsultCliC.UseVisualStyleBackColor = true;
            this.btnConsultCliC.Click += new System.EventHandler(this.btnConsultCliC_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReturn.Location = new System.Drawing.Point(42, 17);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(93, 37);
            this.btnReturn.TabIndex = 3;
            this.btnReturn.Text = "Devolverse";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // frmClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmClient";
            this.Text = "Client";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlDeleteCli.ResumeLayout(false);
            this.pnlDeleteCli.PerformLayout();
            this.pnlModifyClient.ResumeLayout(false);
            this.pnlModifyClient.PerformLayout();
            this.pnlInsertClient.ResumeLayout(false);
            this.pnlInsertClient.PerformLayout();
            this.pnlConsultClient.ResumeLayout(false);
            this.pnlConsultClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCli)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem ingresarClienteToolStripMenuItem;
        private ToolStripMenuItem consultarClienteToolStripMenuItem;
        private ToolStripMenuItem modificarClienteToolStripMenuItem;
        private ToolStripMenuItem eliminarClienteToolStripMenuItem;
        private Panel pnlInsertClient;
        private TextBox txtEmail;
        private Label label6;
        private Button btnCleanCli;
        private Button btnSaveCli;
        private TextBox txtNumberphone;
        private TextBox txtAddress;
        private TextBox txtName;
        private TextBox txtDocument;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Panel pnlModifyClient;
        private ComboBox comboBoxModify;
        private Label label9;
        private Button btnConsultCliM;
        private Button btnSaveChangeCliM;
        private TextBox txtEmailCliM;
        private Label label7;
        private TextBox txtNumberphoneCliM;
        private TextBox txtAddressCliM;
        private TextBox txtNameCliM;
        private Label label8;
        private Label label10;
        private Label label12;
        private Panel pnlDeleteCli;
        private ComboBox comboBoxDelete;
        private Label label16;
        private Panel pnlConsultClient;
        private DataGridView dataGridViewCli;
        private ComboBox txtSearchC;
        private Label label11;
        private Button btnConsultCliC;
        private Button btnDeleteC;
        private Button btnReturn;
    }
}