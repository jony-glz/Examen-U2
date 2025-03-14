using System.Data;

namespace Examen_U2
{
    public partial class frmUsuarios : Form
    {
        private void actualizarGrid()
        {
            Datos datos = new Datos();
            DataSet dS = datos.consulta("SELECT id as 'ID', nombre as 'Nombre', a_paterno as 'Apellido Paterno', a_materno as 'Apellido Materno', telefono as 'Telefono', correo as 'Correo' FROM usuarios;");
            if (dS != null)
            {
                dataGridViewUsuarios.DataSource = dS.Tables[0];
            }
        }
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            actualizarGrid();
        }

        private void frmUsuarios_Activated(object sender, EventArgs e)
        {
            actualizarGrid();
        }

        private void dataGridViewUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            frmActDelUsuario frmActDel = new frmActDelUsuario(
                 dataGridViewUsuarios[0, e.RowIndex].Value.ToString(),
                 dataGridViewUsuarios[1, e.RowIndex].Value.ToString(),
                 dataGridViewUsuarios[2, e.RowIndex].Value.ToString(),
                 dataGridViewUsuarios[3, e.RowIndex].Value.ToString(),
                 dataGridViewUsuarios[4, e.RowIndex].Value.ToString(),
                 dataGridViewUsuarios[5, e.RowIndex].Value.ToString()
            );
            frmActDel.Show();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            frmInsertarUsuario fI = new frmInsertarUsuario();
            fI.Show();
        }
    }
}
