
namespace CapaPresentacion
{
    partial class formMatricula
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMatricula));
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.Titulo = new System.Windows.Forms.Label();
            this.btnReporteMatriculas = new System.Windows.Forms.Button();
            this.btnCargarDatos = new System.Windows.Forms.Button();
            this.cbxMatriculas = new System.Windows.Forms.ComboBox();
            this.dgvMatriculas = new System.Windows.Forms.DataGridView();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnMatricula_Insertar = new System.Windows.Forms.Button();
            this.txtMatricula_comprobante = new System.Windows.Forms.TextBox();
            this.lblMatricula_comprobante = new System.Windows.Forms.Label();
            this.lblHorario_id = new System.Windows.Forms.Label();
            this.lblProfesor_id = new System.Windows.Forms.Label();
            this.lblCurso_id = new System.Windows.Forms.Label();
            this.lblGrupo_id = new System.Windows.Forms.Label();
            this.lblEstudiante_id = new System.Windows.Forms.Label();
            this.lblAula_id = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.cbxEstudiante = new System.Windows.Forms.ComboBox();
            this.cbxGrupo = new System.Windows.Forms.ComboBox();
            this.cbxProfesor = new System.Windows.Forms.ComboBox();
            this.cbxCurso = new System.Windows.Forms.ComboBox();
            this.cbxAula = new System.Windows.Forms.ComboBox();
            this.cbxHorario = new System.Windows.Forms.ComboBox();
            this.chkbxMostrarEliminados = new System.Windows.Forms.CheckBox();
            this.btnActivarEliminado = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriculas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(50, 423);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(140, 41);
            this.btnLimpiar.TabIndex = 43;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.Titulo.Location = new System.Drawing.Point(173, 71);
            this.Titulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(163, 38);
            this.Titulo.TabIndex = 42;
            this.Titulo.Text = "Matricula";
            this.Titulo.Click += new System.EventHandler(this.Titulo_Click);
            // 
            // btnReporteMatriculas
            // 
            this.btnReporteMatriculas.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnReporteMatriculas.FlatAppearance.BorderSize = 0;
            this.btnReporteMatriculas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporteMatriculas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporteMatriculas.Location = new System.Drawing.Point(665, 566);
            this.btnReporteMatriculas.Margin = new System.Windows.Forms.Padding(2);
            this.btnReporteMatriculas.Name = "btnReporteMatriculas";
            this.btnReporteMatriculas.Size = new System.Drawing.Size(257, 41);
            this.btnReporteMatriculas.TabIndex = 41;
            this.btnReporteMatriculas.Text = "Reporte Matriculas";
            this.btnReporteMatriculas.UseVisualStyleBackColor = false;
            this.btnReporteMatriculas.Click += new System.EventHandler(this.btnReporteMatriculaes_Click);
            // 
            // btnCargarDatos
            // 
            this.btnCargarDatos.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCargarDatos.FlatAppearance.BorderSize = 0;
            this.btnCargarDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarDatos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarDatos.Location = new System.Drawing.Point(715, 76);
            this.btnCargarDatos.Margin = new System.Windows.Forms.Padding(2);
            this.btnCargarDatos.Name = "btnCargarDatos";
            this.btnCargarDatos.Size = new System.Drawing.Size(208, 41);
            this.btnCargarDatos.TabIndex = 40;
            this.btnCargarDatos.Text = "Cargar Datos";
            this.btnCargarDatos.UseVisualStyleBackColor = false;
            this.btnCargarDatos.Click += new System.EventHandler(this.btnCargarDatos_Click);
            // 
            // cbxMatriculas
            // 
            this.cbxMatriculas.FormattingEnabled = true;
            this.cbxMatriculas.Location = new System.Drawing.Point(547, 95);
            this.cbxMatriculas.Margin = new System.Windows.Forms.Padding(2);
            this.cbxMatriculas.Name = "cbxMatriculas";
            this.cbxMatriculas.Size = new System.Drawing.Size(164, 21);
            this.cbxMatriculas.TabIndex = 39;
            this.cbxMatriculas.SelectedIndexChanged += new System.EventHandler(this.cbxMatricula_SelectedIndexChanged);
            // 
            // dgvMatriculas
            // 
            this.dgvMatriculas.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgvMatriculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatriculas.Location = new System.Drawing.Point(365, 128);
            this.dgvMatriculas.Margin = new System.Windows.Forms.Padding(2);
            this.dgvMatriculas.Name = "dgvMatriculas";
            this.dgvMatriculas.RowHeadersWidth = 51;
            this.dgvMatriculas.RowTemplate.Height = 24;
            this.dgvMatriculas.Size = new System.Drawing.Size(557, 422);
            this.dgvMatriculas.TabIndex = 38;
            this.dgvMatriculas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMatriculaes_CellClick);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(209, 423);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(134, 41);
            this.btnModificar.TabIndex = 37;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnMatricula_Insertar
            // 
            this.btnMatricula_Insertar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnMatricula_Insertar.FlatAppearance.BorderSize = 0;
            this.btnMatricula_Insertar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMatricula_Insertar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMatricula_Insertar.Location = new System.Drawing.Point(50, 486);
            this.btnMatricula_Insertar.Margin = new System.Windows.Forms.Padding(2);
            this.btnMatricula_Insertar.Name = "btnMatricula_Insertar";
            this.btnMatricula_Insertar.Size = new System.Drawing.Size(140, 41);
            this.btnMatricula_Insertar.TabIndex = 36;
            this.btnMatricula_Insertar.Text = "Insertar";
            this.btnMatricula_Insertar.UseVisualStyleBackColor = false;
            this.btnMatricula_Insertar.Click += new System.EventHandler(this.btnMatricula_Insertar_Click);
            // 
            // txtMatricula_comprobante
            // 
            this.txtMatricula_comprobante.Location = new System.Drawing.Point(164, 377);
            this.txtMatricula_comprobante.Margin = new System.Windows.Forms.Padding(2);
            this.txtMatricula_comprobante.MaxLength = 100;
            this.txtMatricula_comprobante.Name = "txtMatricula_comprobante";
            this.txtMatricula_comprobante.Size = new System.Drawing.Size(179, 20);
            this.txtMatricula_comprobante.TabIndex = 34;
            this.txtMatricula_comprobante.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMatricula_comprobante_KeyPress);
            // 
            // lblMatricula_comprobante
            // 
            this.lblMatricula_comprobante.AutoSize = true;
            this.lblMatricula_comprobante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatricula_comprobante.Location = new System.Drawing.Point(40, 374);
            this.lblMatricula_comprobante.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMatricula_comprobante.Name = "lblMatricula_comprobante";
            this.lblMatricula_comprobante.Size = new System.Drawing.Size(110, 20);
            this.lblMatricula_comprobante.TabIndex = 27;
            this.lblMatricula_comprobante.Text = "Comprobante:";
            // 
            // lblHorario_id
            // 
            this.lblHorario_id.AutoSize = true;
            this.lblHorario_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorario_id.Location = new System.Drawing.Point(47, 312);
            this.lblHorario_id.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHorario_id.Name = "lblHorario_id";
            this.lblHorario_id.Size = new System.Drawing.Size(65, 20);
            this.lblHorario_id.TabIndex = 26;
            this.lblHorario_id.Text = "Horario:";
            // 
            // lblProfesor_id
            // 
            this.lblProfesor_id.AutoSize = true;
            this.lblProfesor_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfesor_id.Location = new System.Drawing.Point(47, 274);
            this.lblProfesor_id.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProfesor_id.Name = "lblProfesor_id";
            this.lblProfesor_id.Size = new System.Drawing.Size(73, 20);
            this.lblProfesor_id.TabIndex = 25;
            this.lblProfesor_id.Text = "Profesor:";
            // 
            // lblCurso_id
            // 
            this.lblCurso_id.AutoSize = true;
            this.lblCurso_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurso_id.Location = new System.Drawing.Point(47, 233);
            this.lblCurso_id.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCurso_id.Name = "lblCurso_id";
            this.lblCurso_id.Size = new System.Drawing.Size(55, 20);
            this.lblCurso_id.TabIndex = 24;
            this.lblCurso_id.Text = "Curso:";
            // 
            // lblGrupo_id
            // 
            this.lblGrupo_id.AutoSize = true;
            this.lblGrupo_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrupo_id.Location = new System.Drawing.Point(46, 197);
            this.lblGrupo_id.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGrupo_id.Name = "lblGrupo_id";
            this.lblGrupo_id.Size = new System.Drawing.Size(58, 20);
            this.lblGrupo_id.TabIndex = 23;
            this.lblGrupo_id.Text = "Grupo:";
            // 
            // lblEstudiante_id
            // 
            this.lblEstudiante_id.AutoSize = true;
            this.lblEstudiante_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstudiante_id.Location = new System.Drawing.Point(46, 160);
            this.lblEstudiante_id.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEstudiante_id.Name = "lblEstudiante_id";
            this.lblEstudiante_id.Size = new System.Drawing.Size(90, 20);
            this.lblEstudiante_id.TabIndex = 22;
            this.lblEstudiante_id.Text = "Estudiante:";
            // 
            // lblAula_id
            // 
            this.lblAula_id.AutoSize = true;
            this.lblAula_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAula_id.Location = new System.Drawing.Point(47, 344);
            this.lblAula_id.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAula_id.Name = "lblAula_id";
            this.lblAula_id.Size = new System.Drawing.Size(45, 20);
            this.lblAula_id.TabIndex = 44;
            this.lblAula_id.Text = "Aula:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(50, 26);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(50, 540);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(140, 41);
            this.btnEliminar.TabIndex = 47;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // cbxEstudiante
            // 
            this.cbxEstudiante.FormattingEnabled = true;
            this.cbxEstudiante.Location = new System.Drawing.Point(164, 163);
            this.cbxEstudiante.Name = "cbxEstudiante";
            this.cbxEstudiante.Size = new System.Drawing.Size(179, 21);
            this.cbxEstudiante.TabIndex = 48;
            this.cbxEstudiante.SelectedIndexChanged += new System.EventHandler(this.cbxEstudiante_SelectedIndexChanged);
            // 
            // cbxGrupo
            // 
            this.cbxGrupo.FormattingEnabled = true;
            this.cbxGrupo.Location = new System.Drawing.Point(164, 200);
            this.cbxGrupo.Name = "cbxGrupo";
            this.cbxGrupo.Size = new System.Drawing.Size(179, 21);
            this.cbxGrupo.TabIndex = 49;
            this.cbxGrupo.SelectedIndexChanged += new System.EventHandler(this.cbxGrupo_SelectedIndexChanged);
            // 
            // cbxProfesor
            // 
            this.cbxProfesor.FormattingEnabled = true;
            this.cbxProfesor.Location = new System.Drawing.Point(164, 273);
            this.cbxProfesor.Name = "cbxProfesor";
            this.cbxProfesor.Size = new System.Drawing.Size(179, 21);
            this.cbxProfesor.TabIndex = 51;
            this.cbxProfesor.SelectedIndexChanged += new System.EventHandler(this.cbxProfesor_SelectedIndexChanged);
            // 
            // cbxCurso
            // 
            this.cbxCurso.FormattingEnabled = true;
            this.cbxCurso.Location = new System.Drawing.Point(164, 236);
            this.cbxCurso.Name = "cbxCurso";
            this.cbxCurso.Size = new System.Drawing.Size(179, 21);
            this.cbxCurso.TabIndex = 50;
            this.cbxCurso.SelectedIndexChanged += new System.EventHandler(this.cbxCurso_SelectedIndexChanged);
            // 
            // cbxAula
            // 
            this.cbxAula.FormattingEnabled = true;
            this.cbxAula.Location = new System.Drawing.Point(164, 346);
            this.cbxAula.Name = "cbxAula";
            this.cbxAula.Size = new System.Drawing.Size(179, 21);
            this.cbxAula.TabIndex = 53;
            this.cbxAula.SelectedIndexChanged += new System.EventHandler(this.cbxAula_SelectedIndexChanged);
            // 
            // cbxHorario
            // 
            this.cbxHorario.FormattingEnabled = true;
            this.cbxHorario.Location = new System.Drawing.Point(164, 314);
            this.cbxHorario.Name = "cbxHorario";
            this.cbxHorario.Size = new System.Drawing.Size(179, 21);
            this.cbxHorario.TabIndex = 52;
            this.cbxHorario.SelectedIndexChanged += new System.EventHandler(this.cbxHorario_SelectedIndexChanged);
            // 
            // chkbxMostrarEliminados
            // 
            this.chkbxMostrarEliminados.AutoSize = true;
            this.chkbxMostrarEliminados.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbxMostrarEliminados.Location = new System.Drawing.Point(365, 95);
            this.chkbxMostrarEliminados.Name = "chkbxMostrarEliminados";
            this.chkbxMostrarEliminados.Size = new System.Drawing.Size(173, 25);
            this.chkbxMostrarEliminados.TabIndex = 55;
            this.chkbxMostrarEliminados.Text = "Mostrar Eliminados";
            this.chkbxMostrarEliminados.UseVisualStyleBackColor = true;
            this.chkbxMostrarEliminados.CheckedChanged += new System.EventHandler(this.chkbxMostrarEliminados_CheckedChanged);
            // 
            // btnActivarEliminado
            // 
            this.btnActivarEliminado.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnActivarEliminado.FlatAppearance.BorderSize = 0;
            this.btnActivarEliminado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActivarEliminado.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActivarEliminado.Location = new System.Drawing.Point(209, 468);
            this.btnActivarEliminado.Margin = new System.Windows.Forms.Padding(2);
            this.btnActivarEliminado.Name = "btnActivarEliminado";
            this.btnActivarEliminado.Size = new System.Drawing.Size(134, 67);
            this.btnActivarEliminado.TabIndex = 54;
            this.btnActivarEliminado.Text = "Activar \r\nEliminado";
            this.btnActivarEliminado.UseVisualStyleBackColor = false;
            this.btnActivarEliminado.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // formMatricula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 629);
            this.Controls.Add(this.chkbxMostrarEliminados);
            this.Controls.Add(this.btnActivarEliminado);
            this.Controls.Add(this.cbxAula);
            this.Controls.Add(this.cbxHorario);
            this.Controls.Add(this.cbxProfesor);
            this.Controls.Add(this.cbxCurso);
            this.Controls.Add(this.cbxGrupo);
            this.Controls.Add(this.cbxEstudiante);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblAula_id);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.btnReporteMatriculas);
            this.Controls.Add(this.btnCargarDatos);
            this.Controls.Add(this.cbxMatriculas);
            this.Controls.Add(this.dgvMatriculas);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnMatricula_Insertar);
            this.Controls.Add(this.txtMatricula_comprobante);
            this.Controls.Add(this.lblMatricula_comprobante);
            this.Controls.Add(this.lblHorario_id);
            this.Controls.Add(this.lblProfesor_id);
            this.Controls.Add(this.lblCurso_id);
            this.Controls.Add(this.lblGrupo_id);
            this.Controls.Add(this.lblEstudiante_id);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "formMatricula";
            this.Text = "Sistema Matricula = Modulo Matricula";
            this.Load += new System.EventHandler(this.formMatricula_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriculas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Button btnReporteMatriculas;
        private System.Windows.Forms.Button btnCargarDatos;
        private System.Windows.Forms.ComboBox cbxMatriculas;
        private System.Windows.Forms.DataGridView dgvMatriculas;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnMatricula_Insertar;
        private System.Windows.Forms.TextBox txtMatricula_comprobante;
        private System.Windows.Forms.Label lblMatricula_comprobante;
        private System.Windows.Forms.Label lblHorario_id;
        private System.Windows.Forms.Label lblProfesor_id;
        private System.Windows.Forms.Label lblCurso_id;
        private System.Windows.Forms.Label lblGrupo_id;
        private System.Windows.Forms.Label lblEstudiante_id;
        private System.Windows.Forms.Label lblAula_id;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ComboBox cbxEstudiante;
        private System.Windows.Forms.ComboBox cbxGrupo;
        private System.Windows.Forms.ComboBox cbxProfesor;
        private System.Windows.Forms.ComboBox cbxCurso;
        private System.Windows.Forms.ComboBox cbxAula;
        private System.Windows.Forms.ComboBox cbxHorario;
        private System.Windows.Forms.CheckBox chkbxMostrarEliminados;
        private System.Windows.Forms.Button btnActivarEliminado;
    }
}