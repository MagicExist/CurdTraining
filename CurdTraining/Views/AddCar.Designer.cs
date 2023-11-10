namespace CurdTraining.Views
{
    partial class AddCar
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtBoxPlaca = new TextBox();
            txtBoxPrecio = new TextBox();
            txtBoxReferencia = new TextBox();
            txtBoxPropietario = new TextBox();
            txtBoxModelo = new TextBox();
            cbBoxFabricantes = new ComboBox();
            btnAddCar = new Button();
            label1 = new Label();
            btnSelectImage = new Button();
            OpenFile = new OpenFileDialog();
            pbCar = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbCar).BeginInit();
            SuspendLayout();
            // 
            // txtBoxPlaca
            // 
            txtBoxPlaca.Location = new Point(87, 83);
            txtBoxPlaca.Name = "txtBoxPlaca";
            txtBoxPlaca.Size = new Size(100, 23);
            txtBoxPlaca.TabIndex = 0;
            txtBoxPlaca.Text = "Placa";
            // 
            // txtBoxPrecio
            // 
            txtBoxPrecio.Location = new Point(87, 144);
            txtBoxPrecio.Name = "txtBoxPrecio";
            txtBoxPrecio.Size = new Size(100, 23);
            txtBoxPrecio.TabIndex = 1;
            txtBoxPrecio.Text = "Precio";
            // 
            // txtBoxReferencia
            // 
            txtBoxReferencia.Location = new Point(87, 208);
            txtBoxReferencia.Name = "txtBoxReferencia";
            txtBoxReferencia.Size = new Size(100, 23);
            txtBoxReferencia.TabIndex = 2;
            txtBoxReferencia.Text = "Referencia";
            // 
            // txtBoxPropietario
            // 
            txtBoxPropietario.Location = new Point(87, 328);
            txtBoxPropietario.Name = "txtBoxPropietario";
            txtBoxPropietario.Size = new Size(100, 23);
            txtBoxPropietario.TabIndex = 3;
            txtBoxPropietario.Text = "Propietario";
            // 
            // txtBoxModelo
            // 
            txtBoxModelo.Location = new Point(87, 268);
            txtBoxModelo.Name = "txtBoxModelo";
            txtBoxModelo.Size = new Size(100, 23);
            txtBoxModelo.TabIndex = 4;
            txtBoxModelo.Text = "Modelo";
            // 
            // cbBoxFabricantes
            // 
            cbBoxFabricantes.FormattingEnabled = true;
            cbBoxFabricantes.Location = new Point(290, 144);
            cbBoxFabricantes.Name = "cbBoxFabricantes";
            cbBoxFabricantes.Size = new Size(121, 23);
            cbBoxFabricantes.TabIndex = 5;
            cbBoxFabricantes.Text = "Fabricantes";
            cbBoxFabricantes.SelectedIndexChanged += cbBoxFabricantes_SelectedIndexChanged;
            // 
            // btnAddCar
            // 
            btnAddCar.Location = new Point(503, 328);
            btnAddCar.Name = "btnAddCar";
            btnAddCar.Size = new Size(139, 49);
            btnAddCar.TabIndex = 6;
            btnAddCar.Text = "Agregar";
            btnAddCar.UseVisualStyleBackColor = true;
            btnAddCar.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(232, 14);
            label1.Name = "label1";
            label1.Size = new Size(220, 37);
            label1.TabIndex = 7;
            label1.Text = "Agregar Vehiculo";
            // 
            // btnSelectImage
            // 
            btnSelectImage.Location = new Point(290, 267);
            btnSelectImage.Name = "btnSelectImage";
            btnSelectImage.Size = new Size(121, 23);
            btnSelectImage.TabIndex = 8;
            btnSelectImage.Text = "Imagen";
            btnSelectImage.UseVisualStyleBackColor = true;
            btnSelectImage.Click += btnSelectImage_Click;
            // 
            // OpenFile
            // 
            OpenFile.FileName = "openFileDialog1";
            // 
            // pbCar
            // 
            pbCar.Location = new Point(478, 83);
            pbCar.Name = "pbCar";
            pbCar.Size = new Size(187, 226);
            pbCar.TabIndex = 9;
            pbCar.TabStop = false;
            pbCar.Click += pbCar_Click;
            // 
            // AddCar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(pbCar);
            Controls.Add(btnSelectImage);
            Controls.Add(label1);
            Controls.Add(btnAddCar);
            Controls.Add(cbBoxFabricantes);
            Controls.Add(txtBoxModelo);
            Controls.Add(txtBoxPropietario);
            Controls.Add(txtBoxReferencia);
            Controls.Add(txtBoxPrecio);
            Controls.Add(txtBoxPlaca);
            Name = "AddCar";
            Size = new Size(688, 450);
            Load += AddCar_Load;
            ((System.ComponentModel.ISupportInitialize)pbCar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBoxPlaca;
        private TextBox txtBoxPrecio;
        private TextBox txtBoxReferencia;
        private TextBox txtBoxPropietario;
        private TextBox txtBoxModelo;
        private ComboBox cbBoxFabricantes;
        private Button btnAddCar;
        private Label label1;
        private Button btnSelectImage;
        private OpenFileDialog OpenFile;
        private PictureBox pbCar;
    }
}
