namespace CurdTraining
{
    partial class InicioSesionView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnInicioSesion = new Button();
            txtBoxUserName = new TextBox();
            lblInicioSesion = new Label();
            txtBoxPassword = new TextBox();
            SuspendLayout();
            // 
            // btnInicioSesion
            // 
            btnInicioSesion.Location = new Point(135, 338);
            btnInicioSesion.Name = "btnInicioSesion";
            btnInicioSesion.Size = new Size(139, 49);
            btnInicioSesion.TabIndex = 0;
            btnInicioSesion.Text = "Entrar";
            btnInicioSesion.UseVisualStyleBackColor = true;
            btnInicioSesion.Click += btnInicioSesion_Click;
            // 
            // txtBoxUserName
            // 
            txtBoxUserName.Location = new Point(104, 157);
            txtBoxUserName.Name = "txtBoxUserName";
            txtBoxUserName.Size = new Size(201, 23);
            txtBoxUserName.TabIndex = 1;
            // 
            // lblInicioSesion
            // 
            lblInicioSesion.AutoSize = true;
            lblInicioSesion.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblInicioSesion.Location = new Point(105, 65);
            lblInicioSesion.Name = "lblInicioSesion";
            lblInicioSesion.Size = new Size(199, 37);
            lblInicioSesion.TabIndex = 2;
            lblInicioSesion.Text = "Inicio de sesion";
            // 
            // txtBoxPassword
            // 
            txtBoxPassword.Location = new Point(104, 256);
            txtBoxPassword.Name = "txtBoxPassword";
            txtBoxPassword.Size = new Size(201, 23);
            txtBoxPassword.TabIndex = 3;
            // 
            // InicioSesionView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(423, 516);
            Controls.Add(txtBoxPassword);
            Controls.Add(lblInicioSesion);
            Controls.Add(txtBoxUserName);
            Controls.Add(btnInicioSesion);
            Name = "InicioSesionView";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnInicioSesion;
        private TextBox txtBoxUserName;
        private Label lblInicioSesion;
        private TextBox txtBoxPassword;
    }
}