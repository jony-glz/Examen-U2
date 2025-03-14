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
    public partial class frmInsertarUsuario : Form
    {
        public frmInsertarUsuario()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string nombre, aP, aM, tel, correo;
            nombre = tbNombre.Text;
            aP = tbAP.Text;
            aM = tbAM.Text;
            tel = tbTel.Text;
            correo = tbMail.Text;

            Datos datos = new Datos();
            bool f = datos.cmd($"INSERT INTO USUARIOS (nombre,a_paterno,a_materno,telefono,correo) " +
                $"VALUES('{nombre}','{aP}','{aM}','{tel}','{correo}');");

            if (f)
            {
                MessageBox.Show("Datos insertados", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {
                MessageBox.Show("Error al insertar", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
