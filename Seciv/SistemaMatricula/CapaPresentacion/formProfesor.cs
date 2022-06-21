using SistemaMatricula.CapaIntegracion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaMatricula.CapaPresentacion.Validar_TextBox;

namespace CapaPresentacion
{
    public partial class frmProfesor : Form
    {
        DataSet dsProfesor = new DataSet();
        DataTable dtProfesor = new DataTable();
        private string estadoUsuario = "";
        public string EstadoUsuario { get => estadoUsuario; set => estadoUsuario = value; }
        public frmProfesor()
        {
            
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)//frmProfesor_Load
        {
            if (estadoUsuario != "A") // activacion de ciertas botones segun estado usuario 
            {
                chkbxMostrarEliminados.Enabled = false;
                chkbxMostrarEliminados.Visible = false;
                btnActivarEliminado.Enabled = false;
                btnActivarEliminado.Visible = false;
                btnReporteProfesores.Enabled = false;
                btnReporteProfesores.Visible = false;
                btnReporteCursosProfesor.Enabled = false;
                btnReporteCursosProfesor.Visible = false;
            }
            validarCampo();
            CargarGridProfesor();
            CargarComboProfesor();

        }

        private void btnProfesor_Insertar_Click(object sender, EventArgs e)
        {
            using (GestorProfesor elProfesor = new GestorProfesor())
            {
                elProfesor.insertarProfesor(txtProfesor_cedula.Text, txtProfesor_nombre.Text, txtProfesor_primerApellido.Text,
                    txtProfesor_segundoApellido.Text, txtProfesor_telefono.Text, txtProfesor_correoElectronico.Text,
                    txtProfesor_direccion.Text, "A");
            }

            LimpiarTxts();

            CargarGridProfesor();
            CargarComboProfesor();

        }

        private void LimpiarTxts()
        {
            txtProfesor_cedula.ResetText();
            txtProfesor_nombre.ResetText();
            txtProfesor_primerApellido.ResetText();
            txtProfesor_segundoApellido.ResetText();
            txtProfesor_telefono.ResetText();
            txtProfesor_correoElectronico.ResetText();
            txtProfesor_direccion.ResetText();

            validarCampo();
        }

        private void CargarGridProfesor()
        {
            using (GestorProfesor elProfesor = new GestorProfesor())
            {
                if (chkbxMostrarEliminados.Checked)
                {
                    dgvProfesores.DataSource = elProfesor.ListarProfesoresInactivos();
                }
                else
                {
                    dgvProfesores.DataSource = elProfesor.ListarProfesor();
                }

                dgvProfesores.Columns["Profesor_id"].Visible = false;
                dgvProfesores.Columns["Profesor_cedula"].HeaderText = "Cedula";
                dgvProfesores.Columns["Profesor_nombre"].HeaderText = "Nombre";
                dgvProfesores.Columns["Profesor_primerApellido"].HeaderText = "Apellido";
                dgvProfesores.Columns["Profesor_segundoApellido"].HeaderText = "Apellido";
                dgvProfesores.Columns["Profesor_telefono"].HeaderText = "Telefono";
                dgvProfesores.Columns["Profesor_correoElectronico"].HeaderText = "eMail";
                dgvProfesores.Columns["Profesor_direccion"].HeaderText = "Direccion";
                dgvProfesores.Columns["Profesor_estado"].Visible = false;

            }
        }

        private void CargarComboProfesor()
        {
            using (GestorProfesor elProfesor = new GestorProfesor())
            {

                if (chkbxMostrarEliminados.Checked)
                {
                    cbxProfesor.DataSource = elProfesor.ListarProfesoresInactivos();
                }
                else
                {
                    cbxProfesor.DataSource = elProfesor.ListarProfesor();
                }

                cbxProfesor.ValueMember = "Profesor_id";
                cbxProfesor.DisplayMember = "Profesor_cedula";// despliega cedula pero selecciona id
            }
        }
        private void BuscarProfesor()
        {
            int Profesor_id = int.Parse(cbxProfesor.SelectedValue.ToString());


            using (GestorProfesor Profesor = new GestorProfesor())
            {
                this.dsProfesor = Profesor.ConsultarProfesor(Profesor_id);
                this.dtProfesor = this.dsProfesor.Tables[0];
            }
            CargarDatosProfesor();
        }

        private void CargarDatosProfesor()
        {
            txtProfesor_cedula.Text = this.dtProfesor.Rows[0]["Profesor_cedula"].ToString();
            txtProfesor_nombre.Text = this.dtProfesor.Rows[0]["Profesor_nombre"].ToString();
            txtProfesor_primerApellido.Text = this.dtProfesor.Rows[0]["Profesor_primerApellido"].ToString();
            txtProfesor_segundoApellido.Text = this.dtProfesor.Rows[0]["Profesor_segundoApellido"].ToString();
            txtProfesor_telefono.Text = this.dtProfesor.Rows[0]["Profesor_telefono"].ToString();
            txtProfesor_correoElectronico.Text = this.dtProfesor.Rows[0]["Profesor_correoElectronico"].ToString();
            txtProfesor_direccion.Text = this.dtProfesor.Rows[0]["Profesor_direccion"].ToString();

        }

        private void btnCargarDatos_Click(object sender, EventArgs e)
        {
            BuscarProfesor();
        }

        private void dgvProfesores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try // recomendado un try catch con eventos sobre grid
            {

                int numFila = dgvProfesores.CurrentCell.RowIndex;
                int Profesor_id = int.Parse(this.dgvProfesores[0, numFila].Value.ToString());


                using (GestorProfesor Profesor = new GestorProfesor())
                {
                    this.dsProfesor = Profesor.ConsultarProfesor(Profesor_id);
                    this.dtProfesor = this.dsProfesor.Tables[0];
                }
                CargarDatosProfesor();
                cbxProfesor.SelectedIndex = numFila;
                validarCampo();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Base de datos vacia. Ingrese datos", "Alerta", // mensage 
                    MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Elemento de tabla no seleccionado", "Error Eleccion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            using (GestorProfesor elProfesor = new GestorProfesor())
            {                               //si cambia la variable a global Profesor_id y le manda esa funciona si se seleciona desde el grid
                elProfesor.ModificarProfesor(int.Parse(cbxProfesor.SelectedValue.ToString()), txtProfesor_cedula.Text, txtProfesor_nombre.Text, txtProfesor_primerApellido.Text,
                                            txtProfesor_segundoApellido.Text, txtProfesor_telefono.Text, txtProfesor_correoElectronico.Text,
                                            txtProfesor_direccion.Text, "A");
            }
            CargarGridProfesor();
            CargarComboProfesor();
        }

        private void btnReporteProfesores_Click(object sender, EventArgs e)
        {
            frmReporte reporte = new frmReporte();
            reporte.Eleccion = 'P';
            reporte.Show();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarTxts();
        }

        private void cbxProfesor_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvProfesores.ClearSelection();
        }

        private void txtProfesor_cedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
            validarCampo();
        }

        private void txtProfesor_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloLetras(e);
            validarCampo();
        }

        private void txtProfesor_primerApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloLetras(e);
            validarCampo();
        }

        private void txtProfesor_segundoApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloLetras(e);
            validarCampo();
        }

        private void txtProfesor_telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
            validarCampo();
        }

        private void validarCampo() // validacion de campos completos
        {
            var vr = !string.IsNullOrEmpty(txtProfesor_cedula.Text) &&
                !string.IsNullOrEmpty(txtProfesor_nombre.Text) &&
                !string.IsNullOrEmpty(txtProfesor_primerApellido.Text) &&
                !string.IsNullOrEmpty(txtProfesor_segundoApellido.Text) &&
                !string.IsNullOrEmpty(txtProfesor_telefono.Text) &&
                !string.IsNullOrEmpty(txtProfesor_correoElectronico.Text) &&
                !string.IsNullOrEmpty(txtProfesor_direccion.Text);

            btnModificar.Enabled = vr;
            btnProfesor_Insertar.Enabled = vr;
            btnEliminar.Enabled = vr;
           
            if (vr)
            {
                btnModificar.BackColor = Color.CornflowerBlue;
                btnProfesor_Insertar.BackColor = Color.CornflowerBlue;
                btnEliminar.BackColor = Color.CornflowerBlue;
                btnReporteCursosProfesor.Enabled = true;
                btnReporteCursosProfesor.BackColor = Color.CornflowerBlue;
            }
            else
            {
                btnModificar.BackColor = Color.Gray;
                btnProfesor_Insertar.BackColor = Color.Gray;
                btnEliminar.BackColor = Color.Gray;
                btnReporteCursosProfesor.Enabled = true;
                btnReporteCursosProfesor.BackColor = Color.Gray;
            }
            // boton btnActivarEliminado manejo mas especifico
            if (vr && chkbxMostrarEliminados.Checked) {
                btnActivarEliminado.Enabled = true;
                btnActivarEliminado.BackColor = Color.CornflowerBlue;
            }
            else
            {
                btnActivarEliminado.Enabled = true;
                btnActivarEliminado.BackColor = Color.Gray;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e) // realmente lo inactiva
        {
            //busca que el Profesor no este en  matriculas
            try
            {
                using (GestorMatricula elMatricula = new GestorMatricula()) // busqueda de Profesor en matriculas
                {
                    DataTable repetidos = elMatricula.ListarMatriculasProfesor(int.Parse(cbxProfesor.SelectedValue.ToString()));
                    if (int.Parse(repetidos.Rows.Count.ToString()) != 0)
                    {
                        Console.WriteLine("error eliminar Profesor ");
                        MessageBox.Show(" Profesor con cursos matriculados", "Error eliminar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {

                        using (GestorProfesor elProfesor = new GestorProfesor())
                        {
                            elProfesor.InactivarProfesor(int.Parse(cbxProfesor.SelectedValue.ToString()));
                        }
                        LimpiarTxts();

                        CargarGridProfesor();
                        CargarComboProfesor();

                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("error eliminar Profesor   catch");
            }

        }

        private void chkbxMostrarEliminados_CheckedChanged(object sender, EventArgs e)
        {
            LimpiarTxts();

            CargarGridProfesor();
            CargarComboProfesor();
        }

        private void btnReporteCursosProfesor_Click(object sender, EventArgs e)
        {
            if (chkbxMostrarEliminados.Checked == false)
            {
                frmReporte reporte = new frmReporte();
                reporte.Eleccion = '2';/// lista de cursos del profesor en un report
                reporte.IDParametro1 = int.Parse(cbxProfesor.SelectedValue.ToString());
                reporte.Show();
            }
        }
    }
}
