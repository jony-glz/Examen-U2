namespace Examen_U2
{
    partial class frmActDelUsuario
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
            btnBorrar = new Button();
            btnActualiza = new Button();
            tbNombre = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbAP = new TextBox();
            label4 = new Label();
            tbAM = new TextBox();
            label5 = new Label();
            tbTel = new TextBox();
            label6 = new Label();
            tbMail = new TextBox();
            label7 = new Label();
            tbId = new TextBox();
            SuspendLayout();
            // 
            // btnBorrar
            // 
            btnBorrar.BackColor = Color.FromArgb(255, 128, 128);
            btnBorrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnBorrar.Location = new Point(37, 630);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(225, 69);
            btnBorrar.TabIndex = 22;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = false;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnActualiza
            // 
            btnActualiza.BackColor = Color.FromArgb(192, 255, 255);
            btnActualiza.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnActualiza.Location = new Point(481, 630);
            btnActualiza.Name = "btnActualiza";
            btnActualiza.Size = new Size(225, 69);
            btnActualiza.TabIndex = 21;
            btnActualiza.Text = "Actualizar";
            btnActualiza.UseVisualStyleBackColor = false;
            btnActualiza.Click += btnActualiza_Click;
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(387, 104);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(457, 55);
            tbNombre.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(-57, 146);
            label1.Name = "label1";
            label1.Size = new Size(51, 48);
            label1.TabIndex = 19;
            label1.Text = "Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.Location = new Point(12, 105);
            label2.Name = "label2";
            label2.Size = new Size(179, 54);
            label2.TabIndex = 23;
            label2.Text = "Nombre";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.Location = new Point(12, 203);
            label3.Name = "label3";
            label3.Size = new Size(339, 54);
            label3.TabIndex = 25;
            label3.Text = "Apellido Paterno";
            // 
            // tbAP
            // 
            tbAP.Location = new Point(387, 202);
            tbAP.Name = "tbAP";
            tbAP.Size = new Size(457, 55);
            tbAP.TabIndex = 24;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label4.Location = new Point(12, 301);
            label4.Name = "label4";
            label4.Size = new Size(353, 54);
            label4.TabIndex = 27;
            label4.Text = "Apellido Materno";
            // 
            // tbAM
            // 
            tbAM.Location = new Point(387, 289);
            tbAM.Name = "tbAM";
            tbAM.Size = new Size(457, 55);
            tbAM.TabIndex = 26;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label5.Location = new Point(12, 402);
            label5.Name = "label5";
            label5.Size = new Size(184, 54);
            label5.TabIndex = 29;
            label5.Text = "Telefono";
            // 
            // tbTel
            // 
            tbTel.Location = new Point(387, 401);
            tbTel.Name = "tbTel";
            tbTel.Size = new Size(457, 55);
            tbTel.TabIndex = 28;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label6.Location = new Point(12, 496);
            label6.Name = "label6";
            label6.Size = new Size(150, 54);
            label6.TabIndex = 31;
            label6.Text = "Correo";
            // 
            // tbMail
            // 
            tbMail.Location = new Point(208, 495);
            tbMail.Name = "tbMail";
            tbMail.Size = new Size(636, 55);
            tbMail.TabIndex = 30;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 19);
            label7.Name = "label7";
            label7.Size = new Size(55, 48);
            label7.TabIndex = 33;
            label7.Text = "ID";
            // 
            // tbId
            // 
            tbId.Enabled = false;
            tbId.Location = new Point(73, 19);
            tbId.Name = "tbId";
            tbId.Size = new Size(199, 55);
            tbId.TabIndex = 32;
            // 
            // frmActDelUsuario
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(894, 740);
            Controls.Add(label7);
            Controls.Add(tbId);
            Controls.Add(label6);
            Controls.Add(tbMail);
            Controls.Add(label5);
            Controls.Add(tbTel);
            Controls.Add(label4);
            Controls.Add(tbAM);
            Controls.Add(label3);
            Controls.Add(tbAP);
            Controls.Add(label2);
            Controls.Add(btnBorrar);
            Controls.Add(btnActualiza);
            Controls.Add(tbNombre);
            Controls.Add(label1);
            Name = "frmActDelUsuario";
            Text = "Actualizar y Borrar Usuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBorrar;
        private Button btnActualiza;
        private TextBox tbNombre;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbAP;
        private Label label4;
        private TextBox tbAM;
        private Label label5;
        private TextBox tbTel;
        private Label label6;
        private TextBox tbMail;
        private Label label7;
        private TextBox tbId;
    }
}