using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SolicitudDeBecas
{
    public partial class frmAcceso : Form
    {
        //Creaciones de Diccionarios globales
        Dictionary<string, string> usuarios = new Dictionary<string, string>();
        Dictionary<string, string> contrasenas = new Dictionary<string, string>();
        Dictionary<string, string> empleado = new Dictionary<string, string>();
        Dictionary<string, string> contrasenaEmpleado = new Dictionary<string, string>();
        //Instanciamos el segundo formulario "frmOpcionesDeBecas" pero por ahora convertido solo como una variable global, más
        //adelante terminaremos con la instanciación
        frmOpcionesDeBecas opcionesBecas;
        public frmAcceso()
        {
            InitializeComponent();
        }
        //Creación del evento Load para el form principal donde se cargaran todos los datos una vez halla inicado con la
        //ejecución del formAcceso
        private void frmAcceso_Load(object sender, EventArgs e)
        {
            //Agregar y cargar los datos al Diccionario los usuarios y contraseñas de los alumnos
            usuarios.Add("211000123","Jaime Emanuel Quistian Sanchez");
            usuarios.Add("211000112", "Amador Rivera Martinez");
            usuarios.Add("211000125", "Adrian Ortiz Quistian");
            contrasenas.Add("Ja01", "211000123");
            contrasenas.Add("Am02", "211000112");
            contrasenas.Add("Ad03", "211000125");
            //Agregar y cargar los datos al Dicionario los empleados y sus contraseñas
            empleado.Add("1000100", "Emanuel Jaime Sanchez Quistian");
            empleado.Add("1000101", "Mario Martinez Rivera");
            empleado.Add("1000102", "Antonio Ortiz Quitian");
            contrasenaEmpleado.Add("Em01", "1000100");
            contrasenaEmpleado.Add("Ma02", "1000101");
            contrasenaEmpleado.Add("An03", "1000102");
        }

        //Creación del Evento KeyPress para el componente txtUsuario, cuya funcion será evaluar las teclas precionadas por el
        //usuario
        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Secuencia comparativa del If para determinar que teclas no puede ingresar el usuario, esto se hace por medio del
            //código ASCII ya que son loas valores aceptados por el evento
            if (e.KeyChar >= 00 && e.KeyChar <= 7 || e.KeyChar >= 9 && e.KeyChar <= 47 || e.KeyChar >= 58 && e.KeyChar <= 255)
            {
                //Acción que se realiza en caso de ser verdadera la condición IF mandando llamar al errorProvided para mostrarle
                //al usuario que está cometiendo un error y como evitarlo
                e.Handled = true;
                epErrorUsuario.SetError(txtUsuario, "Debes ingresar solo números.");
                return;
            }
            else
            {
                //Secuencia a realizar en caso de que la condición no se cumpla evitando mostrar la advertencia
                epErrorUsuario.SetError(txtUsuario, "");
            }
        }
        //Creación del Evento If para eliminar el texto escrito anteriormente en el textBok txtUsuario
        private void txtUsuario_Click(object sender, EventArgs e)
        {
            //Eliminar la propiedad text por medio del metodo Clear()
            txtUsuario.Clear();
        }
        //Creación del evento click para el componente txtAceptar
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //Secuancia de validación de los usuarios y contraseñas ingresados para determinar si ntran al sistema o no
            if (usuarios.ContainsKey(txtUsuario.Text) && contrasenas.ContainsKey(txtContrasena.Text) &&
                usuarios.ContainsKey(txtUsuario.Text) == contrasenas.ContainsKey(txtContrasena.Text))
            {
                //Mostrar un mensaje para el usuario que le indique que ha ingresado exitosamente
                MessageBox.Show("Bienvenido Estudiante", "Información de las Becas", MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);
                //La variable global ahora si la convertimos en un obejeto para poder hacer uso de ella
                opcionesBecas = new frmOpcionesDeBecas();
                //Hacemos uso del apuntador this para ocultar este formulario y así evitar la creación de mas de un form en los
                //recursos del equipo
                this.Hide();
                //Llamamos al form por medio de un DialogResult que nos permitirá acceder al formulario evitando crear ventanas
                //de ejecución que podrián consumir los recursos del equipo si se abre en mas de una ocaión
                DialogResult respuesta = opcionesBecas.ShowDialog();
                if (respuesta == DialogResult.OK)
                {
                    this.Show();
                }
                else
                {
                    opcionesBecas.Close();
                    //Eliminación de los datos ingresados en el frmAcceso
                    txtUsuario.Clear();
                    txtContrasena.Clear();
                    txtUsuario.Focus();
                    this.Show();
                }
            }
            else
            {
                //Secuancia de validación de los usuarios y contraseñas ingresados para determinar si etran al sistema o no
                //(para validad si quien accede es un empleado)
                if (empleado.ContainsKey(txtUsuario.Text) && contrasenaEmpleado.ContainsKey(txtContrasena.Text) &&
                    empleado.ContainsKey(txtUsuario.Text) == contrasenaEmpleado.ContainsKey(txtContrasena.Text))
                {
                    //Mostrar un mensaje para el usuario que le indique que ha ingresado exitosamente
                    MessageBox.Show("Bienvenido personal Trabajador", "Información de las Becas", MessageBoxButtons.OK, 
                        MessageBoxIcon.Information);
                    //La variable global ahora si la convertimos en un obejeto para poder hacer uso de ella
                    opcionesBecas = new frmOpcionesDeBecas();
                    //Hacemos uso del apuntador this para ocultar este formulario y así evitar la creación de mas de un form en
                    //los recursos del equipo
                    this.Hide();
                    //Llamamos al form por medio de un DialogResult que nos permitirá acceder al formulario evitando crear
                    //ventanas de ejecución que podrián consumir los recursos del equipo si se abre en mas de una ocaión
                    DialogResult respuesta = opcionesBecas.ShowDialog();
                    if (respuesta == DialogResult.OK)
                    {
                        this.Show();
                    }
                    else
                    {
                        opcionesBecas.Close();
                        //Eliminación de los datos ingresados en el frmAcceso
                        txtUsuario.Clear();
                        txtContrasena.Clear();
                        txtUsuario.Focus();
                        this.Show();
                    }
                }
                //Secuencia a realizar en caso de no cumplirse la comparativa if
                else
                {
                    MessageBox.Show("Los datos son incorrectos", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        //Creación del envento Click para abandonar la ejecución y cerrar el formulario
        private void btnSalir_Click(object sender, EventArgs e)
        {
            //Hacemos uso del apuntador this para indicar que será este el form que cerraremos al dar clic en el botón btnSalir
            //por medio del metodo Close()
            this.Close();
        }
    }
}
