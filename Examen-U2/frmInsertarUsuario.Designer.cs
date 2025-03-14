namespace Examen_U2
{
    partial class frmInsertarUsuario
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
            label6 = new Label();
            tbMail = new TextBox();
            label5 = new Label();
            tbTel = new TextBox();
            label4 = new Label();
            tbAM = new TextBox();
            label3 = new Label();
            tbAP = new TextBox();
            label2 = new Label();
            btnInsert = new Button();
            tbNombre = new TextBox();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label6.Location = new Point(12, 420);
            label6.Name = "label6";
            label6.Size = new Size(150, 54);
            label6.TabIndex = 42;
            label6.Text = "Correo";
            // 
            // tbMail
            // 
            tbMail.Location = new Point(369, 419);
            tbMail.Name = "tbMail";
            tbMail.Size = new Size(457, 55);
            tbMail.TabIndex = 41;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label5.Location = new Point(12, 326);
            label5.Name = "label5";
            label5.Size = new Size(184, 54);
            label5.TabIndex = 40;
            label5.Text = "Telefono";
            // 
            // tbTel
            // 
            tbTel.Location = new Point(369, 314);
            tbTel.Name = "tbTel";
            tbTel.Size = new Size(457, 55);
            tbTel.TabIndex = 39;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label4.Location = new Point(12, 225);
            label4.Name = "label4";
            label4.Size = new Size(353, 54);
            label4.TabIndex = 38;
            label4.Text = "Apellido Materno";
            // 
            // tbAM
            // 
            tbAM.Location = new Point(369, 225);
            tbAM.Name = "tbAM";
            tbAM.Size = new Size(457, 55);
            tbAM.TabIndex = 37;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.Location = new Point(12, 127);
            label3.Name = "label3";
            label3.Size = new Size(339, 54);
            label3.TabIndex = 36;
            label3.Text = "Apellido Paterno";
            // 
            // tbAP
            // 
            tbAP.Location = new Point(369, 127);
            tbAP.Name = "tbAP";
            tbAP.Size = new Size(457, 55);
            tbAP.TabIndex = 35;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.Location = new Point(12, 29);
            label2.Name = "label2";
            label2.Size = new Size(179, 54);
            label2.TabIndex = 34;
            label2.Text = "Nombre";
            // 
            // btnInsert
            // 
            btnInsert.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnInsert.Location = new Point(257, 596);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(225, 69);
            btnInsert.TabIndex = 33;
            btnInsert.Text = "Insertar";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(369, 30);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(457, 55);
            tbNombre.TabIndex = 32;
            // 
            // frmInsertarUsuario
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1098, 764);
            Controls.Add(label6);
            Controls.Add(tbMail);
            Controls.Add(label5);
            Controls.Add(tbTel);
            Controls.Add(label4);
            Controls.Add(tbAM);
            Controls.Add(label3);
            Controls.Add(tbAP);
            Controls.Add(label2);
            Controls.Add(btnInsert);
            Controls.Add(tbNombre);
            Name = "frmInsertarUsuario";
            Text = "Insertar Usuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private TextBox tbMail;
        private Label label5;
        private TextBox tbTel;
        private Label label4;
        private TextBox tbAM;
        private Label label3;
        private TextBox tbAP;
        private Label label2;
        private Button btnInsert;
        private TextBox tbNombre;
    }
}