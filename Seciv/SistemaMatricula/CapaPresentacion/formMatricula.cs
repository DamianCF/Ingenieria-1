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

namespace CapaPresentacion
{
    public partial class formMatricula : Form
    {
        DataSet dsMatricula = new DataSet();
        DataTable dtMatricula = new DataTable();
        private string estadoUsuario = "";
        private string avisos = ""; // string que recolecta errores en caso de existir al momento de insertar matricula
        int IDAulaAnterior = 0;


        public formMatricula()
        {
            InitializeComponent();
        }

        private void formMatricula_Load(object sender, EventArgs e)
        {
            if (estadoUsuario != "A") // desactivacion de ciertas funciones si el usuario es administrador
            {
                chkbxMostrarEliminados.Enabled = false;
                chkbxMostrarEliminados.Visible = false;
                btnActivarEliminado.Enabled = false;
                btnActivarEliminado.Visible = false;
                btnReporteMatriculas.Enabled = false;
                btnReporteMatriculas.Visible = false;
            }
            validarCampo();
            CargarGridMatricula();
            CargarComboMatricula();
            CargarComboEstudiante();
            CargarComboCurso();
            CargarComboGrupo();
            CargarComboProfesor();
            CargarComboHorario();
            CargarComboAula();

        }


        public string EstadoUsuario { get => estadoUsuario; set => estadoUsuario = value; }
        public string Avisos { get => avisos; set => avisos = value; }
        private void btnMatricula_Insertar_Click(object sender, EventArgs e)
        {
            // validaciones para insertar o modificar la matricula: -- if con requisitos()
            //que el grupo del estudiante se cambia al que hay en matricula 
            //que en la aula seleccionada exista capacidad para el estudiante
            //que el curso seleccionado tenga campo en el cupo y este curso no este ya matriculado
            //que el horario selecionado no choque con otro ya matriculado en cuando dia

            if (requisitos())
            {
                //grupo del estudiante se cambia al que hay en matricula 
                cambiarGrupoEstudiante();
                //aumento cantidad de estudiantes en aula
                aumentoEstudiantesAula();

                using (GestorMatricula elMatricula = new GestorMatricula())
                {
                    elMatricula.insertarMatricula(int.Parse(cbxEstudiante.SelectedValue.ToString()), int.Parse(cbxGrupo.SelectedValue.ToString()),
                        int.Parse(cbxCurso.SelectedValue.ToString()), int.Parse(cbxProfesor.SelectedValue.ToString()), int.Parse(cbxHorario.SelectedValue.ToString()),
                        int.Parse(cbxAula.SelectedValue.ToString()), txtMatricula_comprobante.Text, "A");

                }

                LimpiarTxts();

                CargarGridMatricula();
                CargarComboMatricula();
                CargarComboEstudiante();
                CargarComboCurso();
                CargarComboGrupo();
                CargarComboProfesor();
                CargarComboHorario();
                CargarComboAula();
            }
            else
            {
                MessageBox.Show(avisos, "Error Insercion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            //grupo del estudiante se cambia al que hay en matricula 
            cambiarGrupoEstudiante();
            //aumento cantidad de estudiantes en aula en caso de cambiar de aula
            if (int.Parse(cbxAula.SelectedValue.ToString()) != IDAulaAnterior)
            {
                disminuirEstudiantesAnteriorAula();
            }

            using (GestorMatricula elMatricula = new GestorMatricula())
            {
                elMatricula.ModificarMatricula(int.Parse(cbxMatriculas.SelectedValue.ToString()), int.Parse(cbxEstudiante.SelectedValue.ToString()), int.Parse(cbxGrupo.SelectedValue.ToString()),
                    int.Parse(cbxCurso.SelectedValue.ToString()), int.Parse(cbxProfesor.SelectedValue.ToString()), int.Parse(cbxHorario.SelectedValue.ToString()),
                    int.Parse(cbxAula.SelectedValue.ToString()), txtMatricula_comprobante.Text, "A");
            }
            CargarGridMatricula();
            CargarComboMatricula();
            CargarComboEstudiante();
            CargarComboCurso();
            CargarComboGrupo();
            CargarComboProfesor();
            CargarComboHorario();
            CargarComboAula();

        }

        private bool requisitos() // metodo que ayuda a buscar problemas al matricular
        {   // validaciones para insertar o modificar la matricula:
            avisos = "";
            
            //que en la aula seleccionada exista capacidad para el estudiante
            var vr = verificarCapacidadAula_Curso() &&
           //que el curso seleccionado tenga campo en el cupo y este curso no este ya matriculado
           verificarDisponibilidadCurso();
            //que el horario selecionado no choque con otro ya matriculado en cuando dia
            //verificarDisponibilidadHorario();


            //mostrar mensaje con avisos en caso de ser necesario
            return vr;
        }

        private bool cambiarGrupoEstudiante()
        {
            try
            {
                DataSet dsEstudiante = new DataSet();
                DataTable dtEstudiante = new DataTable();

                using (GestorEstudiante Estudiante = new GestorEstudiante()) // cargar datos estudiante
                {
                    dsEstudiante = Estudiante.ConsultarEstudiante(int.Parse(cbxEstudiante.SelectedValue.ToString()));
                    dtEstudiante = dsEstudiante.Tables[0];
                }

                using (GestorEstudiante elEstudiante = new GestorEstudiante()) // modificar grupo de estudiante
                {
                    elEstudiante.ModificarEstudiante(int.Parse(cbxEstudiante.SelectedValue.ToString()), int.Parse(cbxGrupo.SelectedValue.ToString()),
                        dtEstudiante.Rows[0]["Estudiante_cedula"].ToString(), dtEstudiante.Rows[0]["Estudiante_nombre"].ToString(), dtEstudiante.Rows[0]["Estudiante_primerApellido"].ToString(),
                        dtEstudiante.Rows[0]["Estudiante_segundoApellido"].ToString(), dtEstudiante.Rows[0]["Estudiante_telefono"].ToString(), dtEstudiante.Rows[0]["Estudiante_correoElectronico"].ToString(),
                        dtEstudiante.Rows[0]["Estudiante_direccion"].ToString(), "A");
                }

            }
            catch (Exception)
            {
                Console.WriteLine("error editar grupo en estudiante catch");
                
                return false;
            }
            return true;
        }

        private bool aumentoEstudiantesAula()//aumento cantidad de estudiantes en aula
        {
            try
            {
                DataSet dsAula = new DataSet();
                DataTable dtAula = new DataTable();

                using (GestorAula Aula = new GestorAula()) // cargado de aula
                {
                    dsAula = Aula.ConsultarAula(int.Parse(cbxAula.SelectedValue.ToString()));
                    dtAula = dsAula.Tables[0];
                }

                using (GestorAula elAula = new GestorAula())// modificacion  de aula
                {
                    int num = int.Parse(dtAula.Rows[0]["Aula_capacidad"].ToString());
                    Console.WriteLine(num);
                    num++;
                    Console.WriteLine(num);

                    elAula.ModificarAula(int.Parse(cbxAula.SelectedValue.ToString()),
                        dtAula.Rows[0]["Aula_descripcion"].ToString(), num.ToString(), "A");
                }

            }
            catch (Exception)
            {
                Console.WriteLine("error editar grupo en estudiante catch");
                
                return false;
            }
            return true;
        }


        private bool disminuirEstudiantesAnteriorAula()
        {
            try
            {
                DataSet dsAula = new DataSet();
                DataTable dtAula = new DataTable();

                using (GestorAula Aula = new GestorAula())// cargar aula
                {
                    dsAula = Aula.ConsultarAula(IDAulaAnterior);
                    dtAula = dsAula.Tables[0];
                }

                using (GestorAula elAula = new GestorAula())
                {
                    int num = int.Parse(dtAula.Rows[0]["Aula_capacidad"].ToString());
                    if (num > 0)
                    {
                        num--;

                    }
                    //disminuir cantidad de estudiantes en aula
                    elAula.ModificarAula(IDAulaAnterior, dtAula.Rows[0]["Aula_descripcion"].ToString(), num.ToString(), "A");
                }

            }
            catch (Exception)
            {
                Console.WriteLine("error editar grupo en estudiante catch");
                
                return false;
            }
            return true;
        }

        private bool verificarCapacidadAula_Curso() // verifica si queda campo para matricular estudiante
        {
            try
            {   // encontrar capacidad de aula
                DataSet dsAula = new DataSet();
                DataTable dtAula = new DataTable();
                using (GestorAula Aula = new GestorAula())
                {
                    dsAula = Aula.ConsultarAula(int.Parse(cbxAula.SelectedValue.ToString()));
                    dtAula = dsAula.Tables[0];
                }
                int capacidad = int.Parse(dtAula.Rows[0]["Aula_capacidad"].ToString());

                // encontrar cupo de curso 
                DataSet dsCurso = new DataSet();
                DataTable dtCurso = new DataTable();
                using (GestorCurso Curso = new GestorCurso())
                {
                    dsCurso = Curso.ConsultarCurso(int.Parse(cbxCurso.SelectedValue.ToString()));
                    dtCurso = dsCurso.Tables[0];
                }
                int cupo = int.Parse(dtCurso.Rows[0]["Curso_cupo"].ToString());

                // buscar sihay campo en curso para matricular estudiante
                if (cupo > capacidad) // la cantidad de estudiantes en el aula debe ser menor o igual al cupo de estuduiantes del curso
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("error capacidad de aula y curso al limite en cupos");
                    avisos += " capacidad de aula y curso al limite en cupos,";
                    return false;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("error verificarCapacidadAula catch");

                return false;
            }

        }

        private bool verificarDisponibilidadCurso()
        {
            //busca que el curso no este matriculado anteriormente
            try
            {
                using (GestorMatricula elMatricula = new GestorMatricula()) // busqueda de curso en matriculas de estudiante
                {
                    DataTable repetidos = elMatricula.ListarMatriculasEstudianteCurso(int.Parse(cbxEstudiante.SelectedValue.ToString()), int.Parse(cbxCurso.SelectedValue.ToString()));
                    if (int.Parse(repetidos.Rows.Count.ToString()) != 0)
                    {
                        Console.WriteLine("error estudiante con curso anteriormente matriculado");
                        avisos += " curso matriculado anteriormente, ";
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("error estudiante con curso matriculado catch");
                return false;
            }

        }

        //private bool verificarDisponibilidadHorario()
        //{///revisa que no choquen horarios de cursos matriculados por un estudiante
        //   // idest ... idhorario ... si debuelve algo chocan entonces no matricular
        //    return false;
        //}

        private void LimpiarTxts()
        {

            txtMatricula_comprobante.ResetText();

            CargarComboEstudiante();
            CargarComboCurso();
            CargarComboGrupo();
            CargarComboProfesor();
            CargarComboHorario();
            CargarComboAula();
            validarCampo();
        }

        private void CargarGridMatricula()
        {// cargado de matriculas activas o inactivas
            using (GestorMatricula elMatricula = new GestorMatricula())
            {
                if (chkbxMostrarEliminados.Checked)
                {
                    //dgvMatriculas.DataSource = elMatricula.ListarMatriculasInactivas();
                    dgvMatriculas.DataSource = elMatricula.ListarMatriculasInactivasDescripcion();
                }
                else
                {
                    //dgvMatriculas.DataSource = elMatricula.ListarMatricula();
                    dgvMatriculas.DataSource = elMatricula.ListarMatriculaDescripcion();
                }


                //dgvMatriculas.Columns["Matricula_id"].Visible = false;
                //dgvMatriculas.Columns["Estudiante_id"].HeaderText = "ID Estudiante";
                //dgvMatriculas.Columns["Grupo_id"].HeaderText = "ID Grupo";
                //dgvMatriculas.Columns["Curso_id"].HeaderText = "ID Curso";
                //dgvMatriculas.Columns["Profesor_id"].HeaderText = "ID Profesor";
                //dgvMatriculas.Columns["Horario_id"].HeaderText = "ID Horario";
                //dgvMatriculas.Columns["Aula_id"].HeaderText = "ID Aula";
                //dgvMatriculas.Columns["MatriculaComprobante"].HeaderText = "Comprobante";
                //dgvMatriculas.Columns["Matricula_estado"].Visible = false;


                dgvMatriculas.Columns["Matricula_id"].Visible = false;
                dgvMatriculas.Columns["Estudiante_cedula"].HeaderText = "Estudiante";
                dgvMatriculas.Columns["Grupo_descripcion"].HeaderText = "Grupo";
                dgvMatriculas.Columns["Curso_nombre"].HeaderText = "Curso";
                dgvMatriculas.Columns["Profesor_cedula"].HeaderText = "Profesor";
                dgvMatriculas.Columns["Horario_descripcion"].HeaderText = "Horario";
                dgvMatriculas.Columns["Aula_descripcion"].HeaderText = "Aula";
                dgvMatriculas.Columns["MatriculaComprobante"].HeaderText = "Comprobante";
                dgvMatriculas.Columns["Matricula_estado"].Visible = false;

            }
        }

        private void CargarComboMatricula()
        {// cargado de matriculas activas o inactivas
            using (GestorMatricula elMatricula = new GestorMatricula())
            {
                if (chkbxMostrarEliminados.Checked)
                {
                    cbxMatriculas.DataSource = elMatricula.ListarMatriculasInactivas();
                }
                else
                {
                    cbxMatriculas.DataSource = elMatricula.ListarMatricula();

                }


                cbxMatriculas.ValueMember = "Matricula_id";
                cbxMatriculas.DisplayMember = "MatriculaComprobante";//
            }
        }

        private void CargarComboEstudiante()
        {
            using (GestorEstudiante elEstudiante = new GestorEstudiante())
            {
                cbxEstudiante.DataSource = elEstudiante.ListarEstudiante();
                cbxEstudiante.ValueMember = "Estudiante_id";
                cbxEstudiante.DisplayMember = "Estudiante_cedula";// despliega cedula pero selecciona id

            }
        }

        private void CargarComboGrupo()
        {
            using (GestorGrupo elGrupo = new GestorGrupo())
            {
                cbxGrupo.DataSource = elGrupo.ListarGrupo();
                cbxGrupo.ValueMember = "Grupo_id";
                cbxGrupo.DisplayMember = "Grupo_descripcion";

            }
        }

        private void CargarComboCurso()
        {
            using (GestorCurso elCurso = new GestorCurso())
            {
                cbxCurso.DataSource = elCurso.ListarCurso();
                cbxCurso.ValueMember = "Curso_id";
                cbxCurso.DisplayMember = "Curso_nombre";
            }
        }

        private void CargarComboProfesor()
        {
            using (GestorProfesor elProfesor = new GestorProfesor())
            {
                cbxProfesor.DataSource = elProfesor.ListarProfesor();
                cbxProfesor.ValueMember = "Profesor_id";
                cbxProfesor.DisplayMember = "Profesor_cedula";
            }
        }

        private void CargarComboHorario()
        {
            using (GestorHorario elHorario = new GestorHorario())
            {
                cbxHorario.DataSource = elHorario.ListarHorario();
                cbxHorario.ValueMember = "Horario_id";
                cbxHorario.DisplayMember = "Horario_descripcion";
            }
        }

        private void CargarComboAula()
        {
            using (GestorAula elAula = new GestorAula())
            {
                cbxAula.DataSource = elAula.ListarAula();
                cbxAula.ValueMember = "Aula_id";
                cbxAula.DisplayMember = "Aula_descripcion";

            }
        }

        private void BuscarMatricula()
        {
            int Matricula_id = int.Parse(cbxMatriculas.SelectedValue.ToString());


            using (GestorMatricula Matricula = new GestorMatricula())
            {
                this.dsMatricula = Matricula.ConsultarMatricula(Matricula_id);
                this.dtMatricula = this.dsMatricula.Tables[0];
            }
            CargarDatosMatricula();
        }

        private void CargarDatosMatricula()
        {
            cbxEstudiante.SelectedValue = this.dtMatricula.Rows[0]["Estudiante_id"].ToString();
            cbxGrupo.SelectedValue = this.dtMatricula.Rows[0]["Grupo_id"].ToString();
            cbxCurso.SelectedValue = this.dtMatricula.Rows[0]["Curso_id"].ToString();
            cbxProfesor.SelectedValue = this.dtMatricula.Rows[0]["Profesor_id"].ToString();
            cbxHorario.SelectedValue = this.dtMatricula.Rows[0]["horario_id"].ToString();
            cbxAula.SelectedValue = this.dtMatricula.Rows[0]["Aula_id"].ToString();
            IDAulaAnterior = int.Parse(this.dtMatricula.Rows[0]["Aula_id"].ToString());
            txtMatricula_comprobante.Text = this.dtMatricula.Rows[0]["MatriculaComprobante"].ToString();

        }

        private void btnCargarDatos_Click(object sender, EventArgs e)
        {
            BuscarMatricula();
        }

        private void dgvMatriculaes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try // recomendado un try catch con eventos sobre grid
            {

                int numFila = dgvMatriculas.CurrentCell.RowIndex;
                int Matricula_id = int.Parse(this.dgvMatriculas[0, numFila].Value.ToString());


                using (GestorMatricula Matricula = new GestorMatricula())
                {
                    this.dsMatricula = Matricula.ConsultarMatricula(Matricula_id);
                    this.dtMatricula = this.dsMatricula.Tables[0];
                }
                CargarDatosMatricula();
                cbxMatriculas.SelectedIndex = numFila;
                validarCampo();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Base de datos vacia. Ingrese datos", "Alerta", // mensage 
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (System.FormatException) // solucion error cargado de fila vacia
            {
                MessageBox.Show("Elemento de tabla no seleccionado", "Error Eleccion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnReporteMatriculaes_Click(object sender, EventArgs e)
        {
            frmReporte reporte = new frmReporte();
            reporte.Eleccion = 'M';
            reporte.Show();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarTxts();
        }

        private void cbxMatricula_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvMatriculas.ClearSelection();
        }

        private void Titulo_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            using (GestorMatricula elMatricula = new GestorMatricula())
            {
                elMatricula.InactivarMatricula(int.Parse(cbxMatriculas.SelectedValue.ToString()));
            }
            LimpiarTxts();

            CargarGridMatricula();
            CargarComboMatricula();
        }

        private void txtMatricula_comprobante_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarCampo();
        }

        private void validarCampo() // validaciones de campos llenos para insertar....
        {
            var vr = !string.IsNullOrEmpty(txtMatricula_comprobante.Text) &&
                cbxEstudiante.SelectedItem != null &&
                cbxGrupo.SelectedItem != null &&
                cbxCurso.SelectedItem != null &&
                cbxProfesor.SelectedItem != null &&
                cbxHorario.SelectedItem != null &&
                cbxAula.SelectedItem != null;


            btnModificar.Enabled = vr;
            btnMatricula_Insertar.Enabled = vr;
            btnEliminar.Enabled = vr;
            if (vr)
            {
                btnModificar.BackColor = Color.CornflowerBlue;
                btnMatricula_Insertar.BackColor = Color.CornflowerBlue;
                btnEliminar.BackColor = Color.CornflowerBlue;
            }
            else
            {
                btnModificar.BackColor = Color.Gray;
                btnMatricula_Insertar.BackColor = Color.Gray;
                btnEliminar.BackColor = Color.Gray;
            }
            // boton btnActivarEliminado manejo mas especifico
            if (vr && chkbxMostrarEliminados.Checked)
            {
                btnActivarEliminado.Enabled = true;
                btnActivarEliminado.BackColor = Color.CornflowerBlue;
            }
            else
            {
                btnActivarEliminado.Enabled = true;
                btnActivarEliminado.BackColor = Color.Gray;
            }
        }

        private void chkbxMostrarEliminados_CheckedChanged(object sender, EventArgs e)
        {
            LimpiarTxts();

            CargarGridMatricula();
            CargarComboMatricula();
        }

        private void cbxEstudiante_SelectedIndexChanged(object sender, EventArgs e)
        {
            validarCampo();

        }

        private void cbxGrupo_SelectedIndexChanged(object sender, EventArgs e)
        {
            validarCampo();
        }

        private void cbxCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            validarCampo();
        }

        private void cbxProfesor_SelectedIndexChanged(object sender, EventArgs e)
        {
            validarCampo();
        }

        private void cbxHorario_SelectedIndexChanged(object sender, EventArgs e)
        {
            validarCampo();
        }

        private void cbxAula_SelectedIndexChanged(object sender, EventArgs e)
        {
            validarCampo();
        }
    }
}
