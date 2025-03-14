using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_U2
{
    public partial class frmActDelUsuario : Form
    {
        Datos datos = new Datos();
        public frmActDelUsuario(string id, string nombre, string aP, string aM, string tel, string mail)
        {
            InitializeComponent();
            tbId.Text = id;
            tbNombre.Text = nombre;
            tbAP.Text = aP;
            tbAM.Text = aM;
            tbTel.Text = tel;
            tbMail.Text = mail;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnActualiza_Click(object sender, EventArgs e)
        {
            string name = tbNombre.Text,
                aP = tbAP.Text,
                aM = tbAM.Text,
                tel = tbTel.Text,
                correo = tbMail.Text,
                id = tbId.Text;

            bool f = datos.cmd($"UPDATE usuarios SET " +
                $"nombre='{name}', " +
                $"a_paterno='{aP}', " +
                $"a_materno='{aM}', " +
                $"telefono='{tel}', " +
                $"correo='{correo}' " +
                $"WHERE id='{id}';");

            if (f)
            {
                MessageBox.Show("Datos actualizados", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error al actualizar", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show(
                "Seguro de borrar este registro?",
                "Sistema",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );

            if (r == DialogResult.Yes)
            {
                string id = tbId.Text;
                bool f = datos.cmd($"DELETE FROM usuarios WHERE id='{id}';");

                if (f)
                {
                    MessageBox.Show("Datos eliminados", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else
                {
                    MessageBox.Show("Error al eliminar", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.Close();
            }


        }
    }
}
