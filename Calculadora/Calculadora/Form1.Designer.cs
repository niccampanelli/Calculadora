namespace Calculadora
{
    partial class form
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form));
            this.opResult = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.igualar = new System.Windows.Forms.Button();
            this.virgula = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.mais = new System.Windows.Forms.Button();
            this.tres = new System.Windows.Forms.Button();
            this.dois = new System.Windows.Forms.Button();
            this.um = new System.Windows.Forms.Button();
            this.menos = new System.Windows.Forms.Button();
            this.seis = new System.Windows.Forms.Button();
            this.cinco = new System.Windows.Forms.Button();
            this.quatro = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.nove = new System.Windows.Forms.Button();
            this.oito = new System.Windows.Forms.Button();
            this.sete = new System.Windows.Forms.Button();
            this.backspace = new System.Windows.Forms.Button();
            this.limparOp = new System.Windows.Forms.Button();
            this.limparTudo = new System.Windows.Forms.Button();
            this.percent = new System.Windows.Forms.Button();
            this.anterior = new System.Windows.Forms.TextBox();
            this.resultLabel = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // opResult
            // 
            this.opResult.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.opResult.AutoSize = true;
            this.opResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opResult.Location = new System.Drawing.Point(279, 99);
            this.opResult.Name = "opResult";
            this.opResult.Size = new System.Drawing.Size(0, 39);
            this.opResult.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Black;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.igualar, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.virgula, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.zero, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.multiply, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.mais, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.tres, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.dois, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.um, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.menos, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.seis, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.cinco, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.quatro, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.divide, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.nove, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.oito, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.sete, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.backspace, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.limparOp, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.limparTudo, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.percent, 0, 0);
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(-1, 160);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(385, 374);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // igualar
            // 
            this.igualar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.igualar.AutoSize = true;
            this.igualar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.igualar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.igualar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.igualar.FlatAppearance.BorderSize = 0;
            this.igualar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.igualar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.igualar.Location = new System.Drawing.Point(291, 299);
            this.igualar.Name = "igualar";
            this.igualar.Size = new System.Drawing.Size(91, 72);
            this.igualar.TabIndex = 19;
            this.igualar.Text = "=";
            this.igualar.UseVisualStyleBackColor = false;
            this.igualar.Click += new System.EventHandler(this.igualar_Click);
            // 
            // virgula
            // 
            this.virgula.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.virgula.AutoSize = true;
            this.virgula.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.virgula.BackColor = System.Drawing.Color.Black;
            this.virgula.Cursor = System.Windows.Forms.Cursors.Hand;
            this.virgula.FlatAppearance.BorderSize = 0;
            this.virgula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.virgula.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.virgula.Location = new System.Drawing.Point(195, 299);
            this.virgula.Name = "virgula";
            this.virgula.Size = new System.Drawing.Size(90, 72);
            this.virgula.TabIndex = 18;
            this.virgula.Text = ",";
            this.virgula.UseVisualStyleBackColor = false;
            this.virgula.Click += new System.EventHandler(this.virgula_Click);
            // 
            // zero
            // 
            this.zero.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.zero.AutoSize = true;
            this.zero.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.zero.BackColor = System.Drawing.Color.Black;
            this.zero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.zero.FlatAppearance.BorderSize = 0;
            this.zero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zero.Location = new System.Drawing.Point(99, 299);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(90, 72);
            this.zero.TabIndex = 17;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = false;
            this.zero.Click += new System.EventHandler(this.zero_Click);
            // 
            // multiply
            // 
            this.multiply.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.multiply.AutoSize = true;
            this.multiply.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.multiply.BackColor = System.Drawing.Color.Black;
            this.multiply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.multiply.FlatAppearance.BorderSize = 0;
            this.multiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.multiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiply.Location = new System.Drawing.Point(3, 299);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(90, 72);
            this.multiply.TabIndex = 16;
            this.multiply.Text = "x";
            this.multiply.UseVisualStyleBackColor = false;
            this.multiply.Click += new System.EventHandler(this.multiply_Click);
            // 
            // mais
            // 
            this.mais.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mais.AutoSize = true;
            this.mais.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mais.BackColor = System.Drawing.Color.Black;
            this.mais.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mais.FlatAppearance.BorderSize = 0;
            this.mais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mais.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mais.Location = new System.Drawing.Point(291, 225);
            this.mais.Name = "mais";
            this.mais.Size = new System.Drawing.Size(91, 68);
            this.mais.TabIndex = 15;
            this.mais.Text = "+";
            this.mais.UseVisualStyleBackColor = false;
            this.mais.Click += new System.EventHandler(this.mais_Click);
            // 
            // tres
            // 
            this.tres.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tres.AutoSize = true;
            this.tres.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tres.BackColor = System.Drawing.Color.Black;
            this.tres.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tres.FlatAppearance.BorderSize = 0;
            this.tres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tres.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tres.Location = new System.Drawing.Point(195, 225);
            this.tres.Name = "tres";
            this.tres.Size = new System.Drawing.Size(90, 68);
            this.tres.TabIndex = 14;
            this.tres.Text = "3";
            this.tres.UseVisualStyleBackColor = false;
            this.tres.Click += new System.EventHandler(this.tres_Click);
            // 
            // dois
            // 
            this.dois.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dois.AutoSize = true;
            this.dois.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.dois.BackColor = System.Drawing.Color.Black;
            this.dois.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dois.FlatAppearance.BorderSize = 0;
            this.dois.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dois.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dois.Location = new System.Drawing.Point(99, 225);
            this.dois.Name = "dois";
            this.dois.Size = new System.Drawing.Size(90, 68);
            this.dois.TabIndex = 13;
            this.dois.Text = "2";
            this.dois.UseVisualStyleBackColor = false;
            this.dois.Click += new System.EventHandler(this.dois_Click);
            // 
            // um
            // 
            this.um.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.um.AutoSize = true;
            this.um.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.um.BackColor = System.Drawing.Color.Black;
            this.um.Cursor = System.Windows.Forms.Cursors.Hand;
            this.um.FlatAppearance.BorderSize = 0;
            this.um.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.um.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.um.Location = new System.Drawing.Point(3, 225);
            this.um.Name = "um";
            this.um.Size = new System.Drawing.Size(90, 68);
            this.um.TabIndex = 12;
            this.um.Text = "1";
            this.um.UseVisualStyleBackColor = false;
            this.um.Click += new System.EventHandler(this.um_Click);
            // 
            // menos
            // 
            this.menos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menos.AutoSize = true;
            this.menos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.menos.BackColor = System.Drawing.Color.Black;
            this.menos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menos.FlatAppearance.BorderSize = 0;
            this.menos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menos.Location = new System.Drawing.Point(291, 151);
            this.menos.Name = "menos";
            this.menos.Size = new System.Drawing.Size(91, 68);
            this.menos.TabIndex = 11;
            this.menos.Text = "-";
            this.menos.UseVisualStyleBackColor = false;
            this.menos.Click += new System.EventHandler(this.menos_Click);
            // 
            // seis
            // 
            this.seis.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.seis.AutoSize = true;
            this.seis.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.seis.BackColor = System.Drawing.Color.Black;
            this.seis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.seis.FlatAppearance.BorderSize = 0;
            this.seis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.seis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seis.Location = new System.Drawing.Point(195, 151);
            this.seis.Name = "seis";
            this.seis.Size = new System.Drawing.Size(90, 68);
            this.seis.TabIndex = 10;
            this.seis.Text = "6";
            this.seis.UseVisualStyleBackColor = false;
            this.seis.Click += new System.EventHandler(this.seis_Click);
            // 
            // cinco
            // 
            this.cinco.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cinco.AutoSize = true;
            this.cinco.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cinco.BackColor = System.Drawing.Color.Black;
            this.cinco.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cinco.FlatAppearance.BorderSize = 0;
            this.cinco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cinco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cinco.Location = new System.Drawing.Point(99, 151);
            this.cinco.Name = "cinco";
            this.cinco.Size = new System.Drawing.Size(90, 68);
            this.cinco.TabIndex = 9;
            this.cinco.Text = "5";
            this.cinco.UseVisualStyleBackColor = false;
            this.cinco.Click += new System.EventHandler(this.cinco_Click);
            // 
            // quatro
            // 
            this.quatro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.quatro.AutoSize = true;
            this.quatro.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.quatro.BackColor = System.Drawing.Color.Black;
            this.quatro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.quatro.FlatAppearance.BorderSize = 0;
            this.quatro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quatro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quatro.Location = new System.Drawing.Point(3, 151);
            this.quatro.Name = "quatro";
            this.quatro.Size = new System.Drawing.Size(90, 68);
            this.quatro.TabIndex = 8;
            this.quatro.Text = "4";
            this.quatro.UseVisualStyleBackColor = false;
            this.quatro.Click += new System.EventHandler(this.quatro_Click);
            // 
            // divide
            // 
            this.divide.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.divide.AutoSize = true;
            this.divide.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.divide.BackColor = System.Drawing.Color.Black;
            this.divide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.divide.FlatAppearance.BorderSize = 0;
            this.divide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divide.Location = new System.Drawing.Point(291, 77);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(91, 68);
            this.divide.TabIndex = 7;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = false;
            this.divide.Click += new System.EventHandler(this.divide_Click);
            // 
            // nove
            // 
            this.nove.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nove.AutoSize = true;
            this.nove.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.nove.BackColor = System.Drawing.Color.Black;
            this.nove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nove.FlatAppearance.BorderSize = 0;
            this.nove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nove.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nove.Location = new System.Drawing.Point(195, 77);
            this.nove.Name = "nove";
            this.nove.Size = new System.Drawing.Size(90, 68);
            this.nove.TabIndex = 6;
            this.nove.Text = "9";
            this.nove.UseVisualStyleBackColor = false;
            this.nove.Click += new System.EventHandler(this.nove_Click);
            // 
            // oito
            // 
            this.oito.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.oito.AutoSize = true;
            this.oito.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.oito.BackColor = System.Drawing.Color.Black;
            this.oito.Cursor = System.Windows.Forms.Cursors.Hand;
            this.oito.FlatAppearance.BorderSize = 0;
            this.oito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.oito.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oito.Location = new System.Drawing.Point(99, 77);
            this.oito.Name = "oito";
            this.oito.Size = new System.Drawing.Size(90, 68);
            this.oito.TabIndex = 5;
            this.oito.Text = "8";
            this.oito.UseVisualStyleBackColor = false;
            this.oito.Click += new System.EventHandler(this.oito_Click);
            // 
            // sete
            // 
            this.sete.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sete.AutoSize = true;
            this.sete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.sete.BackColor = System.Drawing.Color.Black;
            this.sete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sete.FlatAppearance.BorderSize = 0;
            this.sete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sete.Location = new System.Drawing.Point(3, 77);
            this.sete.Name = "sete";
            this.sete.Size = new System.Drawing.Size(90, 68);
            this.sete.TabIndex = 4;
            this.sete.Text = "7";
            this.sete.UseVisualStyleBackColor = false;
            this.sete.Click += new System.EventHandler(this.sete_Click);
            // 
            // backspace
            // 
            this.backspace.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.backspace.AutoSize = true;
            this.backspace.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.backspace.BackColor = System.Drawing.Color.Black;
            this.backspace.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backspace.FlatAppearance.BorderSize = 0;
            this.backspace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backspace.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backspace.Location = new System.Drawing.Point(291, 3);
            this.backspace.Name = "backspace";
            this.backspace.Size = new System.Drawing.Size(91, 68);
            this.backspace.TabIndex = 3;
            this.backspace.Text = "Backspace";
            this.backspace.UseVisualStyleBackColor = false;
            this.backspace.Click += new System.EventHandler(this.backspace_Click);
            // 
            // limparOp
            // 
            this.limparOp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.limparOp.AutoSize = true;
            this.limparOp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.limparOp.BackColor = System.Drawing.Color.Black;
            this.limparOp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.limparOp.FlatAppearance.BorderSize = 0;
            this.limparOp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.limparOp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limparOp.Location = new System.Drawing.Point(195, 3);
            this.limparOp.Name = "limparOp";
            this.limparOp.Size = new System.Drawing.Size(90, 68);
            this.limparOp.TabIndex = 2;
            this.limparOp.Text = "C";
            this.limparOp.UseVisualStyleBackColor = false;
            this.limparOp.Click += new System.EventHandler(this.limparOp_Click);
            // 
            // limparTudo
            // 
            this.limparTudo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.limparTudo.AutoSize = true;
            this.limparTudo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.limparTudo.BackColor = System.Drawing.Color.Black;
            this.limparTudo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.limparTudo.FlatAppearance.BorderSize = 0;
            this.limparTudo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.limparTudo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limparTudo.Location = new System.Drawing.Point(99, 3);
            this.limparTudo.Name = "limparTudo";
            this.limparTudo.Size = new System.Drawing.Size(90, 68);
            this.limparTudo.TabIndex = 1;
            this.limparTudo.Text = "CE";
            this.limparTudo.UseVisualStyleBackColor = false;
            this.limparTudo.Click += new System.EventHandler(this.limparTudo_Click);
            // 
            // percent
            // 
            this.percent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.percent.AutoSize = true;
            this.percent.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.percent.BackColor = System.Drawing.Color.Black;
            this.percent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.percent.FlatAppearance.BorderSize = 0;
            this.percent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.percent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percent.Location = new System.Drawing.Point(3, 3);
            this.percent.Name = "percent";
            this.percent.Size = new System.Drawing.Size(90, 68);
            this.percent.TabIndex = 0;
            this.percent.Text = "%";
            this.percent.UseVisualStyleBackColor = false;
            this.percent.Click += new System.EventHandler(this.percent_Click);
            // 
            // anterior
            // 
            this.anterior.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.anterior.BackColor = System.Drawing.Color.Black;
            this.anterior.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.anterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anterior.ForeColor = System.Drawing.SystemColors.Info;
            this.anterior.Location = new System.Drawing.Point(-96, 55);
            this.anterior.Name = "anterior";
            this.anterior.ReadOnly = true;
            this.anterior.Size = new System.Drawing.Size(468, 31);
            this.anterior.TabIndex = 5;
            this.anterior.TabStop = false;
            this.anterior.Text = "0";
            this.anterior.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.anterior.WordWrap = false;
            // 
            // resultLabel
            // 
            this.resultLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.resultLabel.BackColor = System.Drawing.Color.Black;
            this.resultLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel.ForeColor = System.Drawing.SystemColors.Info;
            this.resultLabel.Location = new System.Drawing.Point(-96, 99);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.ReadOnly = true;
            this.resultLabel.Size = new System.Drawing.Size(468, 42);
            this.resultLabel.TabIndex = 6;
            this.resultLabel.TabStop = false;
            this.resultLabel.Text = "\r\n0";
            this.resultLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(384, 531);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.anterior);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.opResult);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(400, 570);
            this.Name = "form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.form_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label opResult;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button igualar;
        private System.Windows.Forms.Button virgula;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button mais;
        private System.Windows.Forms.Button tres;
        private System.Windows.Forms.Button dois;
        private System.Windows.Forms.Button um;
        private System.Windows.Forms.Button menos;
        private System.Windows.Forms.Button seis;
        private System.Windows.Forms.Button cinco;
        private System.Windows.Forms.Button quatro;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button nove;
        private System.Windows.Forms.Button oito;
        private System.Windows.Forms.Button sete;
        private System.Windows.Forms.Button backspace;
        private System.Windows.Forms.Button limparOp;
        private System.Windows.Forms.Button limparTudo;
        private System.Windows.Forms.Button percent;
        private System.Windows.Forms.TextBox anterior;
        private System.Windows.Forms.TextBox resultLabel;
    }
}

