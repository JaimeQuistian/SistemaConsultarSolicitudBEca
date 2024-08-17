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
    public partial class frmOpcionesDeBecas : Form
    {
        //Declaraiones de instancias Globales
        frmBecaAcademica becaAcademica = new frmBecaAcademica();
        frmBecaDeExcelencia becaDeExcelencia = new frmBecaDeExcelencia();
        frmBecaDeportiva becaDeportiva = new frmBecaDeportiva();

        public frmOpcionesDeBecas()
        {
            InitializeComponent();
        }
        //Creación del evento MouseMove para que cuando el usuario acerque el cursor del mouse se abra el formulario
        //correspondiente al botón accedido
        private void btnBecaExcelencia_MouseMove(object sender, MouseEventArgs e)
        {
            //Mostramos el formulario por medio del metodo Show() y asignamos su posición de manera manual para que aparezca
            //a un lado del form frmOpcionesDeBecas
            becaDeExcelencia.Location=new Point(this.Location.X+Width,this.Location.Y);
            becaDeExcelencia.Show();
        }
        //Creacion del evento MouseLeave para que cuando el usuario elimine el cursor del mouse se cierre el formulario
        //correspondiente al botón accedido haciendo uso de la estructura Point para darle una ubicaión especifica
        private void btnBecaExcelencia_MouseLeave(object sender, EventArgs e)
        {
            //Ocultamos el formulario por medio del metodo Hide()
            becaDeExcelencia.Hide();
        }
        //Creación del evento MouseMove para que cuando el usuario acerque el cursor del mouse se abra el formulario
        //correspondiente al botón accedido
        private void btnBecaAcademica_MouseMove(object sender, MouseEventArgs e)
        {
            //Mostramos el formulario por medio del metodo Show() y asignamos su posición de manera manual para que aparezca
            //a un lado del form frmOpcionesDeBecas haciendo uso de la estructura Point para darle una ubicaión especifica
            becaAcademica.Location = new Point(this.Location.X + Width, this.Location.Y);
            becaAcademica.Show();
        }
        //Creacion del evento MouseLeave para que cuando el usuario elimine el cursor del mouse se cierre el formulario
        //correspondiente al botón accedido
        private void btnBecaAcademica_MouseLeave(object sender, EventArgs e)
        {
            //Ocultamos el formulario por medio del metodo Hide()
            becaAcademica.Hide();
        }
        //Creación del evento MouseMove para que cuando el usuario acerque el cursor del mouse se abra el formulario
        //correspondiente al botón accedido
        private void btnBecaDeportiva_MouseMove(object sender, MouseEventArgs e)
        {
            //Mostramos el formulario por medio del metodo Show() y asignamos su posición de manera manual para que aparezca
            //a un lado del form frmOpcionesDeBecas haciendo uso de la estructura Point para darle una ubicaión especifica
            becaDeportiva.Location = new Point(this.Location.X + Width, this.Location.Y);
            becaDeportiva.Show();
        }
        //Creacion del evento MouseLeave para que cuando el usuario elimine el cursor del mouse se cierre el formulario
        //correspondiente al botón accedido
        private void btnBecaDeportiva_MouseLeave(object sender, EventArgs e)
        {
            //Ocultamos el formulario por medio del metodo Hide()
            becaDeportiva.Hide();
        }
        //Creación del envento Click para abandonar la ejecución y cerrar el formulario
        private void tsRegresar_Click(object sender, EventArgs e)
        {
            //Hacemos uso del apuntador this para indicar que será este el form que cerraremos al dar clic en el
            //ToolStrip tsRegresar por medio del metodo Close()
            this.Close();
        }
    }
}
