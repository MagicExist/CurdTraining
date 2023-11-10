namespace CurdTraining.Views
{
    partial class MainHubView
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
            sideBar = new FlowLayoutPanel();
            btnAddCar = new Button();
            contentControl = new Panel();
            sideBar.SuspendLayout();
            SuspendLayout();
            // 
            // sideBar
            // 
            sideBar.Controls.Add(btnAddCar);
            sideBar.Dock = DockStyle.Left;
            sideBar.FlowDirection = FlowDirection.TopDown;
            sideBar.Location = new Point(0, 0);
            sideBar.Name = "sideBar";
            sideBar.Size = new Size(112, 450);
            sideBar.TabIndex = 0;
            // 
            // btnAddCar
            // 
            btnAddCar.BackgroundImage = Properties.Resources.CreateBtnImage;
            btnAddCar.BackgroundImageLayout = ImageLayout.Stretch;
            btnAddCar.FlatAppearance.BorderSize = 0;
            btnAddCar.FlatStyle = FlatStyle.Flat;
            btnAddCar.Location = new Point(3, 3);
            btnAddCar.Name = "btnAddCar";
            btnAddCar.Size = new Size(103, 89);
            btnAddCar.TabIndex = 0;
            btnAddCar.UseVisualStyleBackColor = true;
            btnAddCar.Click += btnAddCar_Click;
            // 
            // contentControl
            // 
            contentControl.Dock = DockStyle.Fill;
            contentControl.Location = new Point(112, 0);
            contentControl.Name = "contentControl";
            contentControl.Size = new Size(688, 450);
            contentControl.TabIndex = 1;
            // 
            // MainHubView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(contentControl);
            Controls.Add(sideBar);
            MaximizeBox = false;
            MaximumSize = new Size(816, 489);
            MinimumSize = new Size(816, 489);
            Name = "MainHubView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main Hub";
            sideBar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel sideBar;
        private Button btnAddCar;
        private Panel contentControl;
    }
}