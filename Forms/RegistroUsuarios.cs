using Demo;
using System;
using System.Windows.Forms;

namespace FitLine
{
    public partial class RegistroUsuarios : Form
    {
        public static string line;
        public static string RegistroHuella;
        public RegistroUsuarios()
        {
            InitializeComponent();
        }

        private void btnEnroll_Click(object sender, EventArgs e)
        {

        }

        private void REGISTRO_USUARIOS_Load(object sender, EventArgs e)
        {
            CConexion con = new CConexion();
            con.establecerConexion();
            ClassModules.clsCargarUsuarios tablaUsuarios = new ClassModules.clsCargarUsuarios();
            tablaUsuarios.MostrarUsuarios(TABLA);
            SetHuella("");

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Inicio abrir = new Inicio();
            abrir.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HuellaGuardar abrir = new HuellaGuardar();
            abrir.Show();
            //this.Close();

            
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        public void SetHuella(string template)
        {
            if (template.Equals(""))
            {
                TxtHuella.Text = "NO CARGADA";
            }
            else
            {
                TxtHuella.Text = "CARGADA";
            }
        }
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            utils.GlobalCachingProvider objCache = utils.GlobalCachingProvider.Instance;
            ClassModules.clsCargarUsuarios tablaUsuarios = new ClassModules.clsCargarUsuarios();
            
            String CEDULA = TxtCedula.Text;
            String Nombre = TxtNombres.Text;
            String Apellidos = TxtApellidos.Text;
            String NumeroCont = TxtNumeroCon.Text;
            String ContacEmer = TxtContactoEmer.Text;
            String Email = TxtEmail.Text;
            String Huella = objCache.GetItem("huella", false) as string;
            


            ClassModules.clsCargarUsuarios Guardar = new ClassModules.clsCargarUsuarios();
            Guardar.GUARDAR(CEDULA, Nombre, Apellidos, NumeroCont, ContacEmer, Email, Huella);
            tablaUsuarios.MostrarUsuarios(TABLA);

        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            utils.GlobalCachingProvider objCache = utils.GlobalCachingProvider.Instance;
            ClassModules.clsCargarUsuarios tablaUsuarios = new ClassModules.clsCargarUsuarios();
            String CEDULA = TxtCedula.Text;
            String Nombre = TxtNombres.Text;
            String Apellidos = TxtApellidos.Text;
            String NumeroCont = TxtNumeroCon.Text;
            String ContacEmer = TxtContactoEmer.Text;
            String Email = TxtEmail.Text;
            ClassModules.clsCargarUsuarios EDITAR = new ClassModules.clsCargarUsuarios();
            String Huella = objCache.GetItem("huella", false) as string;

            EDITAR.editar(CEDULA, Nombre, Apellidos, NumeroCont, ContacEmer, Email, Huella);
            tablaUsuarios.MostrarUsuarios(TABLA);
        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            ClassModules.clsCargarUsuarios tablaUsuarios = new ClassModules.clsCargarUsuarios();
            String CEDULA = TxtCedula.Text;
            ClassModules.clsCargarUsuarios BORRAR = new ClassModules.clsCargarUsuarios();
            BORRAR.borrar(CEDULA);
            tablaUsuarios.MostrarUsuarios(TABLA);
        }
        
        
        private void TABLA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TABLA_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ClassModules.clsCargarUsuarios cargar = new ClassModules.clsCargarUsuarios();
            cargar.seleccionar(TABLA, TxtCedula, TxtNombres, TxtApellidos, TxtNumeroCon, TxtContactoEmer, TxtEmail);
        }

        private void TxtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
                return;
            }
        }

        private void TxtNumeroCon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
                return;
            }
        }

        private void TxtContactoEmer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
                return;
            }
        }

        private void TxtFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClassModules.clsCargarUsuarios cargar = new ClassModules.clsCargarUsuarios();
            String Filtro = TxtFiltro.Text;
            cargar.Filtrar(TABLA, Filtro);
        }
    }
    
}
