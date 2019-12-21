namespace persistenciaArchivos
{
    partial class CreateFilesForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateFilesForm));
            this.ChequesDataGridView = new System.Windows.Forms.DataGridView();
            this.CerrarButton = new System.Windows.Forms.Button();
            this.CrearArchivoButton = new System.Windows.Forms.Button();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.UpsertPanel = new System.Windows.Forms.Panel();
            this.MontoLabel = new System.Windows.Forms.Label();
            this.MontoTextBox = new System.Windows.Forms.TextBox();
            this.DescripcionLlabel = new System.Windows.Forms.Label();
            this.DescripcionTextBox = new System.Windows.Forms.TextBox();
            this.NumeroChequeLabel = new System.Windows.Forms.Label();
            this.EmisorLabel = new System.Windows.Forms.Label();
            this.NumeroChequeTextBox = new System.Windows.Forms.TextBox();
            this.EmisorTextBox = new System.Windows.Forms.TextBox();
            this.AgregarButton = new System.Windows.Forms.Button();
            this.LimpiarButton = new System.Windows.Forms.Button();
            this.ListaChequesLabel = new System.Windows.Forms.Label();
            this.InformacionRutaLabel = new System.Windows.Forms.Label();
            this.BorrarRenglonButton = new System.Windows.Forms.Button();
            this.InformationProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.ReceptorLabel = new System.Windows.Forms.Label();
            this.ReceptorTextBox = new System.Windows.Forms.TextBox();
            this.FechaLabel = new System.Windows.Forms.Label();
            this.FechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.InstitucionLabel = new System.Windows.Forms.Label();
            this.InstitucionTextBox = new System.Windows.Forms.TextBox();
            this.MonedaLabel = new System.Windows.Forms.Label();
            this.MonedaComboBox = new System.Windows.Forms.ComboBox();
            this.EmisorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReceptorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InstitucionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MonedaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ChequesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.UpsertPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InformationProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // ChequesDataGridView
            // 
            this.ChequesDataGridView.AllowUserToAddRows = false;
            this.ChequesDataGridView.AllowUserToDeleteRows = false;
            this.ChequesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ChequesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmisorColumn,
            this.ReceptorColumn,
            this.FechaColumn,
            this.NumeroColumn,
            this.MontoColumn,
            this.InstitucionColumn,
            this.DescripcionColumn,
            this.MonedaColumn});
            this.ChequesDataGridView.Location = new System.Drawing.Point(375, 74);
            this.ChequesDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ChequesDataGridView.Name = "ChequesDataGridView";
            this.ChequesDataGridView.ReadOnly = true;
            this.ChequesDataGridView.RowHeadersWidth = 51;
            this.ChequesDataGridView.Size = new System.Drawing.Size(784, 325);
            this.ChequesDataGridView.TabIndex = 2;
            this.ChequesDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ChequesDataGridView_CellContentClick);
            // 
            // CerrarButton
            // 
            this.CerrarButton.Location = new System.Drawing.Point(375, 417);
            this.CerrarButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CerrarButton.Name = "CerrarButton";
            this.CerrarButton.Size = new System.Drawing.Size(100, 28);
            this.CerrarButton.TabIndex = 11;
            this.CerrarButton.Text = "Cerrar";
            this.CerrarButton.UseVisualStyleBackColor = true;
            this.CerrarButton.Click += new System.EventHandler(this.CerrarButton_Click);
            // 
            // CrearArchivoButton
            // 
            this.CrearArchivoButton.Location = new System.Drawing.Point(1035, 417);
            this.CrearArchivoButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CrearArchivoButton.Name = "CrearArchivoButton";
            this.CrearArchivoButton.Size = new System.Drawing.Size(124, 28);
            this.CrearArchivoButton.TabIndex = 11;
            this.CrearArchivoButton.Text = "Crear Archivo";
            this.CrearArchivoButton.UseVisualStyleBackColor = true;
            this.CrearArchivoButton.Click += new System.EventHandler(this.CrearArchivoButton_Click);
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            this.ErrorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("ErrorProvider.Icon")));
            // 
            // UpsertPanel
            // 
            this.UpsertPanel.BackColor = System.Drawing.Color.DarkBlue;
            this.UpsertPanel.Controls.Add(this.MonedaComboBox);
            this.UpsertPanel.Controls.Add(this.MonedaLabel);
            this.UpsertPanel.Controls.Add(this.InstitucionTextBox);
            this.UpsertPanel.Controls.Add(this.InstitucionLabel);
            this.UpsertPanel.Controls.Add(this.FechaDateTimePicker);
            this.UpsertPanel.Controls.Add(this.FechaLabel);
            this.UpsertPanel.Controls.Add(this.ReceptorTextBox);
            this.UpsertPanel.Controls.Add(this.ReceptorLabel);
            this.UpsertPanel.Controls.Add(this.MontoLabel);
            this.UpsertPanel.Controls.Add(this.MontoTextBox);
            this.UpsertPanel.Controls.Add(this.DescripcionLlabel);
            this.UpsertPanel.Controls.Add(this.DescripcionTextBox);
            this.UpsertPanel.Controls.Add(this.NumeroChequeLabel);
            this.UpsertPanel.Controls.Add(this.EmisorLabel);
            this.UpsertPanel.Controls.Add(this.NumeroChequeTextBox);
            this.UpsertPanel.Controls.Add(this.EmisorTextBox);
            this.UpsertPanel.Controls.Add(this.AgregarButton);
            this.UpsertPanel.Controls.Add(this.LimpiarButton);
            this.UpsertPanel.Location = new System.Drawing.Point(0, 0);
            this.UpsertPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UpsertPanel.Name = "UpsertPanel";
            this.UpsertPanel.Size = new System.Drawing.Size(335, 544);
            this.UpsertPanel.TabIndex = 12;
            // 
            // MontoLabel
            // 
            this.MontoLabel.AutoSize = true;
            this.MontoLabel.ForeColor = System.Drawing.Color.White;
            this.MontoLabel.Location = new System.Drawing.Point(27, 200);
            this.MontoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MontoLabel.Name = "MontoLabel";
            this.MontoLabel.Size = new System.Drawing.Size(148, 17);
            this.MontoLabel.TabIndex = 20;
            this.MontoLabel.Text = "Monto (Solo números)";
            // 
            // MontoTextBox
            // 
            this.MontoTextBox.Location = new System.Drawing.Point(27, 221);
            this.MontoTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MontoTextBox.Name = "MontoTextBox";
            this.MontoTextBox.Size = new System.Drawing.Size(272, 22);
            this.MontoTextBox.TabIndex = 15;
            // 
            // DescripcionLlabel
            // 
            this.DescripcionLlabel.AutoSize = true;
            this.DescripcionLlabel.ForeColor = System.Drawing.Color.White;
            this.DescripcionLlabel.Location = new System.Drawing.Point(27, 356);
            this.DescripcionLlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DescripcionLlabel.Name = "DescripcionLlabel";
            this.DescripcionLlabel.Size = new System.Drawing.Size(284, 17);
            this.DescripcionLlabel.TabIndex = 18;
            this.DescripcionLlabel.Text = "Descripción( min 10 caractéres, encriptada)";
            // 
            // DescripcionTextBox
            // 
            this.DescripcionTextBox.Location = new System.Drawing.Point(30, 377);
            this.DescripcionTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DescripcionTextBox.Multiline = true;
            this.DescripcionTextBox.Name = "DescripcionTextBox";
            this.DescripcionTextBox.Size = new System.Drawing.Size(269, 118);
            this.DescripcionTextBox.TabIndex = 16;
            // 
            // NumeroChequeLabel
            // 
            this.NumeroChequeLabel.AutoSize = true;
            this.NumeroChequeLabel.ForeColor = System.Drawing.Color.White;
            this.NumeroChequeLabel.Location = new System.Drawing.Point(27, 153);
            this.NumeroChequeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NumeroChequeLabel.Name = "NumeroChequeLabel";
            this.NumeroChequeLabel.Size = new System.Drawing.Size(248, 17);
            this.NumeroChequeLabel.TabIndex = 16;
            this.NumeroChequeLabel.Text = "Número de cheque (min 5 caractéres)";
            // 
            // EmisorLabel
            // 
            this.EmisorLabel.AutoSize = true;
            this.EmisorLabel.ForeColor = System.Drawing.Color.White;
            this.EmisorLabel.Location = new System.Drawing.Point(24, 15);
            this.EmisorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EmisorLabel.Name = "EmisorLabel";
            this.EmisorLabel.Size = new System.Drawing.Size(51, 17);
            this.EmisorLabel.TabIndex = 15;
            this.EmisorLabel.Text = "Emisor";
            // 
            // NumeroChequeTextBox
            // 
            this.NumeroChequeTextBox.Location = new System.Drawing.Point(28, 174);
            this.NumeroChequeTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NumeroChequeTextBox.Name = "NumeroChequeTextBox";
            this.NumeroChequeTextBox.Size = new System.Drawing.Size(272, 22);
            this.NumeroChequeTextBox.TabIndex = 14;
            // 
            // EmisorTextBox
            // 
            this.EmisorTextBox.Location = new System.Drawing.Point(28, 34);
            this.EmisorTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EmisorTextBox.Name = "EmisorTextBox";
            this.EmisorTextBox.Size = new System.Drawing.Size(271, 22);
            this.EmisorTextBox.TabIndex = 13;
            // 
            // AgregarButton
            // 
            this.AgregarButton.Location = new System.Drawing.Point(200, 503);
            this.AgregarButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AgregarButton.Name = "AgregarButton";
            this.AgregarButton.Size = new System.Drawing.Size(100, 28);
            this.AgregarButton.TabIndex = 12;
            this.AgregarButton.Text = "Agregar";
            this.AgregarButton.UseVisualStyleBackColor = true;
            this.AgregarButton.Click += new System.EventHandler(this.AgregarButton_Click);
            // 
            // LimpiarButton
            // 
            this.LimpiarButton.Location = new System.Drawing.Point(27, 503);
            this.LimpiarButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LimpiarButton.Name = "LimpiarButton";
            this.LimpiarButton.Size = new System.Drawing.Size(100, 28);
            this.LimpiarButton.TabIndex = 11;
            this.LimpiarButton.Text = "Limpiar";
            this.LimpiarButton.UseVisualStyleBackColor = true;
            this.LimpiarButton.Click += new System.EventHandler(this.LimpiarButton_Click);
            // 
            // ListaChequesLabel
            // 
            this.ListaChequesLabel.AutoSize = true;
            this.ListaChequesLabel.BackColor = System.Drawing.Color.Transparent;
            this.ListaChequesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaChequesLabel.ForeColor = System.Drawing.Color.Black;
            this.ListaChequesLabel.Location = new System.Drawing.Point(597, 15);
            this.ListaChequesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ListaChequesLabel.Name = "ListaChequesLabel";
            this.ListaChequesLabel.Size = new System.Drawing.Size(211, 29);
            this.ListaChequesLabel.TabIndex = 15;
            this.ListaChequesLabel.Text = "Lista de cheques";
            // 
            // InformacionRutaLabel
            // 
            this.InformacionRutaLabel.Location = new System.Drawing.Point(372, 46);
            this.InformacionRutaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.InformacionRutaLabel.Name = "InformacionRutaLabel";
            this.InformacionRutaLabel.Size = new System.Drawing.Size(787, 24);
            this.InformacionRutaLabel.TabIndex = 16;
            this.InformacionRutaLabel.Text = "@InformacionRutaArchivos";
            // 
            // BorrarRenglonButton
            // 
            this.BorrarRenglonButton.Location = new System.Drawing.Point(498, 417);
            this.BorrarRenglonButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BorrarRenglonButton.Name = "BorrarRenglonButton";
            this.BorrarRenglonButton.Size = new System.Drawing.Size(127, 28);
            this.BorrarRenglonButton.TabIndex = 11;
            this.BorrarRenglonButton.Text = "Borrar renglón";
            this.BorrarRenglonButton.UseVisualStyleBackColor = true;
            this.BorrarRenglonButton.Click += new System.EventHandler(this.BorrarRenglonButton_Click);
            // 
            // InformationProvider
            // 
            this.InformationProvider.ContainerControl = this;
            this.InformationProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("InformationProvider.Icon")));
            // 
            // ReceptorLabel
            // 
            this.ReceptorLabel.AutoSize = true;
            this.ReceptorLabel.ForeColor = System.Drawing.Color.White;
            this.ReceptorLabel.Location = new System.Drawing.Point(27, 60);
            this.ReceptorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ReceptorLabel.Name = "ReceptorLabel";
            this.ReceptorLabel.Size = new System.Drawing.Size(66, 17);
            this.ReceptorLabel.TabIndex = 21;
            this.ReceptorLabel.Text = "Receptor";
            // 
            // ReceptorTextBox
            // 
            this.ReceptorTextBox.Location = new System.Drawing.Point(27, 81);
            this.ReceptorTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ReceptorTextBox.Name = "ReceptorTextBox";
            this.ReceptorTextBox.Size = new System.Drawing.Size(272, 22);
            this.ReceptorTextBox.TabIndex = 22;
            this.ReceptorTextBox.TextChanged += new System.EventHandler(this.ReceptorTextBox_TextChanged);
            // 
            // FechaLabel
            // 
            this.FechaLabel.AutoSize = true;
            this.FechaLabel.ForeColor = System.Drawing.Color.White;
            this.FechaLabel.Location = new System.Drawing.Point(27, 107);
            this.FechaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FechaLabel.Name = "FechaLabel";
            this.FechaLabel.Size = new System.Drawing.Size(47, 17);
            this.FechaLabel.TabIndex = 23;
            this.FechaLabel.Text = "Fecha";
            // 
            // FechaDateTimePicker
            // 
            this.FechaDateTimePicker.Location = new System.Drawing.Point(27, 128);
            this.FechaDateTimePicker.Name = "FechaDateTimePicker";
            this.FechaDateTimePicker.Size = new System.Drawing.Size(273, 22);
            this.FechaDateTimePicker.TabIndex = 24;
            this.FechaDateTimePicker.ValueChanged += new System.EventHandler(this.FechaDateTimePicker_ValueChanged);
            // 
            // InstitucionLabel
            // 
            this.InstitucionLabel.AutoSize = true;
            this.InstitucionLabel.ForeColor = System.Drawing.Color.White;
            this.InstitucionLabel.Location = new System.Drawing.Point(28, 247);
            this.InstitucionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.InstitucionLabel.Name = "InstitucionLabel";
            this.InstitucionLabel.Size = new System.Drawing.Size(141, 17);
            this.InstitucionLabel.TabIndex = 25;
            this.InstitucionLabel.Text = "Institucion Financiera";
            // 
            // InstitucionTextBox
            // 
            this.InstitucionTextBox.Location = new System.Drawing.Point(27, 268);
            this.InstitucionTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.InstitucionTextBox.Name = "InstitucionTextBox";
            this.InstitucionTextBox.Size = new System.Drawing.Size(272, 22);
            this.InstitucionTextBox.TabIndex = 26;
            // 
            // MonedaLabel
            // 
            this.MonedaLabel.AutoSize = true;
            this.MonedaLabel.ForeColor = System.Drawing.Color.White;
            this.MonedaLabel.Location = new System.Drawing.Point(27, 294);
            this.MonedaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MonedaLabel.Name = "MonedaLabel";
            this.MonedaLabel.Size = new System.Drawing.Size(59, 17);
            this.MonedaLabel.TabIndex = 27;
            this.MonedaLabel.Text = "Moneda";
            // 
            // MonedaComboBox
            // 
            this.MonedaComboBox.FormattingEnabled = true;
            this.MonedaComboBox.Location = new System.Drawing.Point(27, 315);
            this.MonedaComboBox.Name = "MonedaComboBox";
            this.MonedaComboBox.Size = new System.Drawing.Size(272, 24);
            this.MonedaComboBox.TabIndex = 28;
            // 
            // EmisorColumn
            // 
            this.EmisorColumn.HeaderText = "Emisor";
            this.EmisorColumn.MinimumWidth = 6;
            this.EmisorColumn.Name = "EmisorColumn";
            this.EmisorColumn.ReadOnly = true;
            this.EmisorColumn.Width = 125;
            // 
            // ReceptorColumn
            // 
            this.ReceptorColumn.HeaderText = "Receptor";
            this.ReceptorColumn.MinimumWidth = 6;
            this.ReceptorColumn.Name = "ReceptorColumn";
            this.ReceptorColumn.ReadOnly = true;
            this.ReceptorColumn.Width = 125;
            // 
            // FechaColumn
            // 
            this.FechaColumn.HeaderText = "Fecha";
            this.FechaColumn.MinimumWidth = 6;
            this.FechaColumn.Name = "FechaColumn";
            this.FechaColumn.ReadOnly = true;
            this.FechaColumn.Width = 125;
            // 
            // NumeroColumn
            // 
            this.NumeroColumn.HeaderText = "Numero de Cheque";
            this.NumeroColumn.MinimumWidth = 6;
            this.NumeroColumn.Name = "NumeroColumn";
            this.NumeroColumn.ReadOnly = true;
            this.NumeroColumn.Width = 125;
            // 
            // MontoColumn
            // 
            this.MontoColumn.HeaderText = "Monto";
            this.MontoColumn.MinimumWidth = 6;
            this.MontoColumn.Name = "MontoColumn";
            this.MontoColumn.ReadOnly = true;
            this.MontoColumn.Width = 125;
            // 
            // InstitucionColumn
            // 
            this.InstitucionColumn.HeaderText = "Institucion";
            this.InstitucionColumn.MinimumWidth = 6;
            this.InstitucionColumn.Name = "InstitucionColumn";
            this.InstitucionColumn.ReadOnly = true;
            this.InstitucionColumn.Width = 125;
            // 
            // DescripcionColumn
            // 
            this.DescripcionColumn.HeaderText = "Descripcion";
            this.DescripcionColumn.MinimumWidth = 6;
            this.DescripcionColumn.Name = "DescripcionColumn";
            this.DescripcionColumn.ReadOnly = true;
            this.DescripcionColumn.Width = 125;
            // 
            // MonedaColumn
            // 
            this.MonedaColumn.HeaderText = "Moneda";
            this.MonedaColumn.MinimumWidth = 6;
            this.MonedaColumn.Name = "MonedaColumn";
            this.MonedaColumn.ReadOnly = true;
            this.MonedaColumn.Width = 125;
            // 
            // CreateFilesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1204, 544);
            this.Controls.Add(this.InformacionRutaLabel);
            this.Controls.Add(this.BorrarRenglonButton);
            this.Controls.Add(this.CerrarButton);
            this.Controls.Add(this.UpsertPanel);
            this.Controls.Add(this.CrearArchivoButton);
            this.Controls.Add(this.ChequesDataGridView);
            this.Controls.Add(this.ListaChequesLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CreateFilesForm";
            this.Text = "Información de archivos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CreateFilesForm_FormClosing);
            this.Load += new System.EventHandler(this.CreateFilesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ChequesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.UpsertPanel.ResumeLayout(false);
            this.UpsertPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InformationProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ChequesDataGridView;
        private System.Windows.Forms.Button CerrarButton;
        private System.Windows.Forms.Button CrearArchivoButton;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
        private System.Windows.Forms.Panel UpsertPanel;
        private System.Windows.Forms.Label MontoLabel;
        private System.Windows.Forms.TextBox MontoTextBox;
        private System.Windows.Forms.Label DescripcionLlabel;
        private System.Windows.Forms.TextBox DescripcionTextBox;
        private System.Windows.Forms.Label NumeroChequeLabel;
        private System.Windows.Forms.Label EmisorLabel;
        private System.Windows.Forms.TextBox NumeroChequeTextBox;
        private System.Windows.Forms.TextBox EmisorTextBox;
        private System.Windows.Forms.Button AgregarButton;
        private System.Windows.Forms.Button LimpiarButton;
        private System.Windows.Forms.Label InformacionRutaLabel;
        private System.Windows.Forms.Label ListaChequesLabel;
        private System.Windows.Forms.Button BorrarRenglonButton;
        private System.Windows.Forms.ErrorProvider InformationProvider;
        private System.Windows.Forms.TextBox ReceptorTextBox;
        private System.Windows.Forms.Label ReceptorLabel;
        private System.Windows.Forms.Label InstitucionLabel;
        private System.Windows.Forms.DateTimePicker FechaDateTimePicker;
        private System.Windows.Forms.Label FechaLabel;
        private System.Windows.Forms.ComboBox MonedaComboBox;
        private System.Windows.Forms.Label MonedaLabel;
        private System.Windows.Forms.TextBox InstitucionTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmisorColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceptorColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn InstitucionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MonedaColumn;
    }
}

