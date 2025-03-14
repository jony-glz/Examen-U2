namespace Examen_U2
{
    partial class frmUsuarios
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
            tableLayoutPanel1 = new TableLayoutPanel();
            btnInsert = new Button();
            dataGridViewUsuarios = new DataGridView();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsuarios).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(btnInsert, 0, 0);
            tableLayoutPanel1.Controls.Add(dataGridViewUsuarios, 0, 1);
            tableLayoutPanel1.Location = new Point(21, 28);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15.6302519F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 84.36975F));
            tableLayoutPanel1.Size = new Size(1746, 764);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btnInsert
            // 
            btnInsert.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnInsert.Location = new Point(3, 3);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(1740, 113);
            btnInsert.TabIndex = 0;
            btnInsert.Text = "Insertar";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // dataGridViewUsuarios
            // 
            dataGridViewUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUsuarios.Dock = DockStyle.Fill;
            dataGridViewUsuarios.Location = new Point(3, 122);
            dataGridViewUsuarios.Name = "dataGridViewUsuarios";
            dataGridViewUsuarios.RowHeadersWidth = 123;
            dataGridViewUsuarios.Size = new Size(1740, 639);
            dataGridViewUsuarios.TabIndex = 1;
            dataGridViewUsuarios.CellContentClick += dataGridViewUsuarios_CellContentClick;
            // 
            // frmUsuarios
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1792, 834);
            Controls.Add(tableLayoutPanel1);
            Name = "frmUsuarios";
            Text = "Usuarios";
            Activated += frmUsuarios_Activated;
            Load += frmUsuarios_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsuarios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button btnInsert;
        private DataGridView dataGridViewUsuarios;
    }
}
