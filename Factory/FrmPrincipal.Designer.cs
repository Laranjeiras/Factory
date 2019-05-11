namespace Factory
{
    partial class FrmPrincipal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.Grid = new System.Windows.Forms.DataGridView();
            this.BancoNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BomPara = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorBruto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desconto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descontoReal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorLiq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTaxaJuros = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btSalvar = new System.Windows.Forms.Button();
            this.txtData = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btCalcular = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTotalLiquido = new System.Windows.Forms.Label();
            this.lblTotalDesconto = new System.Windows.Forms.Label();
            this.lblTotalBruto = new System.Windows.Forms.Label();
            this.btBuscarCobrancas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // Grid
            // 
            this.Grid.AllowUserToDeleteRows = false;
            this.Grid.AllowUserToOrderColumns = true;
            this.Grid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Grid.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BancoNumero,
            this.colDocumento,
            this.BomPara,
            this.Dias,
            this.ValorBruto,
            this.desconto,
            this.descontoReal,
            this.ValorLiq});
            this.Grid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.Grid.Location = new System.Drawing.Point(14, 85);
            this.Grid.Name = "Grid";
            this.Grid.RowHeadersVisible = false;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grid.RowsDefaultCellStyle = dataGridViewCellStyle11;
            this.Grid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grid.Size = new System.Drawing.Size(1048, 303);
            this.Grid.TabIndex = 0;
            // 
            // BancoNumero
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.BancoNumero.DefaultCellStyle = dataGridViewCellStyle3;
            this.BancoNumero.HeaderText = "N Banco";
            this.BancoNumero.Name = "BancoNumero";
            // 
            // colDocumento
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colDocumento.DefaultCellStyle = dataGridViewCellStyle4;
            this.colDocumento.HeaderText = "Documento";
            this.colDocumento.Name = "colDocumento";
            // 
            // BomPara
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.BomPara.DefaultCellStyle = dataGridViewCellStyle5;
            this.BomPara.HeaderText = "Bom Para";
            this.BomPara.Name = "BomPara";
            // 
            // Dias
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Dias.DefaultCellStyle = dataGridViewCellStyle6;
            this.Dias.HeaderText = "Dias";
            this.Dias.Name = "Dias";
            this.Dias.ReadOnly = true;
            // 
            // ValorBruto
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValorBruto.DefaultCellStyle = dataGridViewCellStyle7;
            this.ValorBruto.HeaderText = "Valor Bruto";
            this.ValorBruto.Name = "ValorBruto";
            // 
            // desconto
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.desconto.DefaultCellStyle = dataGridViewCellStyle8;
            this.desconto.HeaderText = "Desconto %";
            this.desconto.Name = "desconto";
            this.desconto.ReadOnly = true;
            // 
            // descontoReal
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.descontoReal.DefaultCellStyle = dataGridViewCellStyle9;
            this.descontoReal.HeaderText = "Desconto R$";
            this.descontoReal.Name = "descontoReal";
            this.descontoReal.ReadOnly = true;
            // 
            // ValorLiq
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ValorLiq.DefaultCellStyle = dataGridViewCellStyle10;
            this.ValorLiq.HeaderText = "Valor Liq";
            this.ValorLiq.Name = "ValorLiq";
            this.ValorLiq.ReadOnly = true;
            // 
            // txtTaxaJuros
            // 
            this.txtTaxaJuros.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaxaJuros.Location = new System.Drawing.Point(460, 28);
            this.txtTaxaJuros.Name = "txtTaxaJuros";
            this.txtTaxaJuros.Size = new System.Drawing.Size(132, 21);
            this.txtTaxaJuros.TabIndex = 1;
            this.txtTaxaJuros.Text = "0,00";
            this.txtTaxaJuros.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTaxaJuros.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTaxaJuros_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(456, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Taxa de Juros (%):";
            // 
            // btSalvar
            // 
            this.btSalvar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalvar.Location = new System.Drawing.Point(821, 394);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(117, 26);
            this.btSalvar.TabIndex = 3;
            this.btSalvar.Text = "Exportar html";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(70, 29);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(300, 21);
            this.txtData.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Data:";
            // 
            // btCalcular
            // 
            this.btCalcular.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCalcular.Location = new System.Drawing.Point(652, 22);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(117, 30);
            this.btCalcular.TabIndex = 6;
            this.btCalcular.Text = "Calcular";
            this.btCalcular.UseVisualStyleBackColor = true;
            this.btCalcular.Click += new System.EventHandler(this.BtCalcular_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.Location = new System.Drawing.Point(945, 394);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(117, 26);
            this.btCancelar.TabIndex = 7;
            this.btCancelar.Text = "Sair...";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 401);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Total Bruto:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(511, 401);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Total Liquido:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(248, 401);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Valor Desconto:";
            // 
            // lblTotalLiquido
            // 
            this.lblTotalLiquido.BackColor = System.Drawing.Color.White;
            this.lblTotalLiquido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalLiquido.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalLiquido.Location = new System.Drawing.Point(615, 401);
            this.lblTotalLiquido.Name = "lblTotalLiquido";
            this.lblTotalLiquido.Size = new System.Drawing.Size(138, 21);
            this.lblTotalLiquido.TabIndex = 13;
            this.lblTotalLiquido.Text = "R$ 0,00";
            this.lblTotalLiquido.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalDesconto
            // 
            this.lblTotalDesconto.BackColor = System.Drawing.Color.White;
            this.lblTotalDesconto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalDesconto.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDesconto.Location = new System.Drawing.Point(365, 401);
            this.lblTotalDesconto.Name = "lblTotalDesconto";
            this.lblTotalDesconto.Size = new System.Drawing.Size(138, 21);
            this.lblTotalDesconto.TabIndex = 14;
            this.lblTotalDesconto.Text = "R$ 0,00";
            this.lblTotalDesconto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalBruto
            // 
            this.lblTotalBruto.BackColor = System.Drawing.Color.White;
            this.lblTotalBruto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalBruto.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalBruto.Location = new System.Drawing.Point(103, 402);
            this.lblTotalBruto.Name = "lblTotalBruto";
            this.lblTotalBruto.Size = new System.Drawing.Size(138, 21);
            this.lblTotalBruto.TabIndex = 15;
            this.lblTotalBruto.Text = "R$ 0,00";
            this.lblTotalBruto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btBuscarCobrancas
            // 
            this.btBuscarCobrancas.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBuscarCobrancas.Location = new System.Drawing.Point(914, 12);
            this.btBuscarCobrancas.Name = "btBuscarCobrancas";
            this.btBuscarCobrancas.Size = new System.Drawing.Size(148, 30);
            this.btBuscarCobrancas.TabIndex = 16;
            this.btBuscarCobrancas.Text = "Buscar Cobranças ... ";
            this.btBuscarCobrancas.UseVisualStyleBackColor = true;
            this.btBuscarCobrancas.Click += new System.EventHandler(this.btBuscarCobrancas_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 432);
            this.Controls.Add(this.btBuscarCobrancas);
            this.Controls.Add(this.lblTotalBruto);
            this.Controls.Add(this.lblTotalDesconto);
            this.Controls.Add(this.lblTotalLiquido);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btCalcular);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTaxaJuros);
            this.Controls.Add(this.Grid);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LTEC - Factory [www.laranjeiras.dev]";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.TextBox txtTaxaJuros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.DateTimePicker txtData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btCalcular;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTotalLiquido;
        private System.Windows.Forms.Label lblTotalDesconto;
        private System.Windows.Forms.Label lblTotalBruto;
        private System.Windows.Forms.Button btBuscarCobrancas;
        private System.Windows.Forms.DataGridViewTextBoxColumn BancoNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn BomPara;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dias;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorBruto;
        private System.Windows.Forms.DataGridViewTextBoxColumn desconto;
        private System.Windows.Forms.DataGridViewTextBoxColumn descontoReal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorLiq;
    }
}

