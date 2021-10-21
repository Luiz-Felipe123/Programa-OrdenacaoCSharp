namespace BuscaOrdenada
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnOrdenar = new FontAwesome.Sharp.IconButton();
            this.btnCarregar = new FontAwesome.Sharp.IconButton();
            this.btnSalvar = new FontAwesome.Sharp.IconButton();
            this.btn_buscaSeq = new FontAwesome.Sharp.IconButton();
            this.btn_buscaByn = new FontAwesome.Sharp.IconButton();
            this.btnAdd = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.listDados = new System.Windows.Forms.ListBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBusca = new FontAwesome.Sharp.IconButton();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(65)))), ((int)(((byte)(70)))));
            this.panelMenu.Controls.Add(this.btnOrdenar);
            this.panelMenu.Controls.Add(this.btnCarregar);
            this.panelMenu.Controls.Add(this.btnSalvar);
            this.panelMenu.Controls.Add(this.btn_buscaSeq);
            this.panelMenu.Controls.Add(this.btn_buscaByn);
            this.panelMenu.Controls.Add(this.btnAdd);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(285, 656);
            this.panelMenu.TabIndex = 0;
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOrdenar.FlatAppearance.BorderSize = 0;
            this.btnOrdenar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrdenar.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdenar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnOrdenar.IconChar = FontAwesome.Sharp.IconChar.SortAlphaDown;
            this.btnOrdenar.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnOrdenar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnOrdenar.IconSize = 45;
            this.btnOrdenar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrdenar.Location = new System.Drawing.Point(0, 445);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnOrdenar.Size = new System.Drawing.Size(285, 60);
            this.btnOrdenar.TabIndex = 13;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrdenar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click_1);
            // 
            // btnCarregar
            // 
            this.btnCarregar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCarregar.FlatAppearance.BorderSize = 0;
            this.btnCarregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarregar.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarregar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCarregar.IconChar = FontAwesome.Sharp.IconChar.Upload;
            this.btnCarregar.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnCarregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCarregar.IconSize = 45;
            this.btnCarregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCarregar.Location = new System.Drawing.Point(0, 385);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnCarregar.Size = new System.Drawing.Size(285, 60);
            this.btnCarregar.TabIndex = 12;
            this.btnCarregar.Text = "Carregar";
            this.btnCarregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCarregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCarregar.UseVisualStyleBackColor = true;
            this.btnCarregar.Click += new System.EventHandler(this.btnCarregar_Click_1);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSalvar.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnSalvar.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnSalvar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSalvar.IconSize = 45;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(0, 325);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnSalvar.Size = new System.Drawing.Size(285, 60);
            this.btnSalvar.TabIndex = 11;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click_1);
            // 
            // btn_buscaSeq
            // 
            this.btn_buscaSeq.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_buscaSeq.FlatAppearance.BorderSize = 0;
            this.btn_buscaSeq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscaSeq.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscaSeq.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_buscaSeq.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btn_buscaSeq.IconColor = System.Drawing.Color.Gainsboro;
            this.btn_buscaSeq.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_buscaSeq.IconSize = 45;
            this.btn_buscaSeq.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_buscaSeq.Location = new System.Drawing.Point(0, 265);
            this.btn_buscaSeq.Name = "btn_buscaSeq";
            this.btn_buscaSeq.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_buscaSeq.Size = new System.Drawing.Size(285, 60);
            this.btn_buscaSeq.TabIndex = 8;
            this.btn_buscaSeq.Text = "Busca Sequencial";
            this.btn_buscaSeq.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_buscaSeq.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_buscaSeq.UseVisualStyleBackColor = true;
            this.btn_buscaSeq.Click += new System.EventHandler(this.btn_buscaSeq_Click);
            // 
            // btn_buscaByn
            // 
            this.btn_buscaByn.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_buscaByn.FlatAppearance.BorderSize = 0;
            this.btn_buscaByn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscaByn.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscaByn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_buscaByn.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btn_buscaByn.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btn_buscaByn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_buscaByn.IconSize = 45;
            this.btn_buscaByn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_buscaByn.Location = new System.Drawing.Point(0, 205);
            this.btn_buscaByn.Name = "btn_buscaByn";
            this.btn_buscaByn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_buscaByn.Size = new System.Drawing.Size(285, 60);
            this.btn_buscaByn.TabIndex = 6;
            this.btn_buscaByn.Text = "Busca Binária";
            this.btn_buscaByn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_buscaByn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_buscaByn.UseVisualStyleBackColor = true;
            this.btn_buscaByn.Click += new System.EventHandler(this.btn_buscaByn_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAdd.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnAdd.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdd.IconSize = 45;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(0, 145);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnAdd.Size = new System.Drawing.Size(285, 60);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.btnHome);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(285, 145);
            this.panelLogo.TabIndex = 4;
            // 
            // btnHome
            // 
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(44, 21);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(194, 107);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // listDados
            // 
            this.listDados.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listDados.FormattingEnabled = true;
            this.listDados.ItemHeight = 31;
            this.listDados.Location = new System.Drawing.Point(284, 53);
            this.listDados.Name = "listDados";
            this.listDados.Size = new System.Drawing.Size(918, 624);
            this.listDados.TabIndex = 24;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Roboto Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(289, 3);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(901, 38);
            this.txtSearch.TabIndex = 25;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(65)))), ((int)(((byte)(70)))));
            this.panel1.Location = new System.Drawing.Point(283, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(923, 11);
            this.panel1.TabIndex = 26;
            // 
            // btnBusca
            // 
            this.btnBusca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(65)))), ((int)(((byte)(70)))));
            this.btnBusca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBusca.FlatAppearance.BorderSize = 0;
            this.btnBusca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBusca.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnBusca.IconColor = System.Drawing.Color.Black;
            this.btnBusca.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBusca.IconSize = 38;
            this.btnBusca.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBusca.Location = new System.Drawing.Point(1131, 3);
            this.btnBusca.Name = "btnBusca";
            this.btnBusca.Size = new System.Drawing.Size(72, 39);
            this.btnBusca.TabIndex = 27;
            this.btnBusca.UseVisualStyleBackColor = false;
            this.btnBusca.Click += new System.EventHandler(this.btnBusca_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 656);
            this.Controls.Add(this.btnBusca);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.listDados);
            this.Controls.Add(this.panelMenu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btn_buscaByn;
        private FontAwesome.Sharp.IconButton btnAdd;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox btnHome;
        private FontAwesome.Sharp.IconButton btnOrdenar;
        private FontAwesome.Sharp.IconButton btnCarregar;
        private FontAwesome.Sharp.IconButton btnSalvar;
        private FontAwesome.Sharp.IconButton btn_buscaSeq;
        private System.Windows.Forms.ListBox listDados;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnBusca;
    }
}

