﻿
using System;
using System.Windows.Forms;

namespace CapaPresentacion
{
    partial class frmProfesor
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProfesor));
            this.lblProfesor_cedula = new System.Windows.Forms.Label();
            this.lblProfesor_nombre = new System.Windows.Forms.Label();
            this.lblProfesor_primerApellido = new System.Windows.Forms.Label();
            this.lblProfesor_correoElectronico = new System.Windows.Forms.Label();
            this.lblProfesor_telefono = new System.Windows.Forms.Label();
            this.lblProfesor_segundoApellido = new System.Windows.Forms.Label();
            this.lblProfesor_direccion = new System.Windows.Forms.Label();
            this.txtProfesor_cedula = new System.Windows.Forms.TextBox();
            this.txtProfesor_nombre = new System.Windows.Forms.TextBox();
            this.txtProfesor_segundoApellido = new System.Windows.Forms.TextBox();
            this.txtProfesor_primerApellido = new System.Windows.Forms.TextBox();
            this.txtProfesor_correoElectronico = new System.Windows.Forms.TextBox();
            this.txtProfesor_telefono = new System.Windows.Forms.TextBox();
            this.txtProfesor_direccion = new System.Windows.Forms.TextBox();
            this.btnProfesor_Insertar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.dgvProfesores = new System.Windows.Forms.DataGridView();
            this.cbxProfesor = new System.Windows.Forms.ComboBox();
            this.btnCargarDatos = new System.Windows.Forms.Button();
            this.btnReporteProfesores = new System.Windows.Forms.Button();
            this.Titulo = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnReporteCursosProfesor = new System.Windows.Forms.Button();
            this.btnActivarEliminado = new System.Windows.Forms.Button();
            this.chkbxMostrarEliminados = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfesores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProfesor_cedula
            // 
            this.lblProfesor_cedula.AutoSize = true;
            this.lblProfesor_cedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfesor_cedula.Location = new System.Drawing.Point(15, 107);
            this.lblProfesor_cedula.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProfesor_cedula.Name = "lblProfesor_cedula";
            this.lblProfesor_cedula.Size = new System.Drawing.Size(63, 20);
            this.lblProfesor_cedula.TabIndex = 0;
            this.lblProfesor_cedula.Text = "Cédula:";
            // 
            // lblProfesor_nombre
            // 
            this.lblProfesor_nombre.AutoSize = true;
            this.lblProfesor_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfesor_nombre.Location = new System.Drawing.Point(15, 142);
            this.lblProfesor_nombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProfesor_nombre.Name = "lblProfesor_nombre";
            this.lblProfesor_nombre.Size = new System.Drawing.Size(69, 20);
            this.lblProfesor_nombre.TabIndex = 1;
            this.lblProfesor_nombre.Text = "Nombre:";
            // 
            // lblProfesor_primerApellido
            // 
            this.lblProfesor_primerApellido.AutoSize = true;
            this.lblProfesor_primerApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfesor_primerApellido.Location = new System.Drawing.Point(15, 177);
            this.lblProfesor_primerApellido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProfesor_primerApellido.Name = "lblProfesor_primerApellido";
            this.lblProfesor_primerApellido.Size = new System.Drawing.Size(118, 20);
            this.lblProfesor_primerApellido.TabIndex = 2;
            this.lblProfesor_primerApellido.Text = "Primer Apellido:";
            // 
            // lblProfesor_correoElectronico
            // 
            this.lblProfesor_correoElectronico.AutoSize = true;
            this.lblProfesor_correoElectronico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfesor_correoElectronico.Location = new System.Drawing.Point(15, 333);
            this.lblProfesor_correoElectronico.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProfesor_correoElectronico.Name = "lblProfesor_correoElectronico";
            this.lblProfesor_correoElectronico.Size = new System.Drawing.Size(144, 20);
            this.lblProfesor_correoElectronico.TabIndex = 5;
            this.lblProfesor_correoElectronico.Text = "Correo Electronico:";
            // 
            // lblProfesor_telefono
            // 
            this.lblProfesor_telefono.AutoSize = true;
            this.lblProfesor_telefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfesor_telefono.Location = new System.Drawing.Point(15, 294);
            this.lblProfesor_telefono.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProfesor_telefono.Name = "lblProfesor_telefono";
            this.lblProfesor_telefono.Size = new System.Drawing.Size(75, 20);
            this.lblProfesor_telefono.TabIndex = 4;
            this.lblProfesor_telefono.Text = "Telefono:";
            // 
            // lblProfesor_segundoApellido
            // 
            this.lblProfesor_segundoApellido.AutoSize = true;
            this.lblProfesor_segundoApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfesor_segundoApellido.Location = new System.Drawing.Point(15, 233);
            this.lblProfesor_segundoApellido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProfesor_segundoApellido.Name = "lblProfesor_segundoApellido";
            this.lblProfesor_segundoApellido.Size = new System.Drawing.Size(138, 20);
            this.lblProfesor_segundoApellido.TabIndex = 3;
            this.lblProfesor_segundoApellido.Text = "Segundo Apellido:";
            // 
            // lblProfesor_direccion
            // 
            this.lblProfesor_direccion.AutoSize = true;
            this.lblProfesor_direccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfesor_direccion.Location = new System.Drawing.Point(15, 377);
            this.lblProfesor_direccion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProfesor_direccion.Name = "lblProfesor_direccion";
            this.lblProfesor_direccion.Size = new System.Drawing.Size(79, 20);
            this.lblProfesor_direccion.TabIndex = 6;
            this.lblProfesor_direccion.Text = "Direccion:";
            // 
            // txtProfesor_cedula
            // 
            this.txtProfesor_cedula.Location = new System.Drawing.Point(88, 107);
            this.txtProfesor_cedula.Margin = new System.Windows.Forms.Padding(2);
            this.txtProfesor_cedula.MaxLength = 50;
            this.txtProfesor_cedula.Name = "txtProfesor_cedula";
            this.txtProfesor_cedula.Size = new System.Drawing.Size(187, 20);
            this.txtProfesor_cedula.TabIndex = 7;
            this.txtProfesor_cedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProfesor_cedula_KeyPress);
            // 
            // txtProfesor_nombre
            // 
            this.txtProfesor_nombre.Location = new System.Drawing.Point(88, 145);
            this.txtProfesor_nombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtProfesor_nombre.MaxLength = 50;
            this.txtProfesor_nombre.Name = "txtProfesor_nombre";
            this.txtProfesor_nombre.Size = new System.Drawing.Size(187, 20);
            this.txtProfesor_nombre.TabIndex = 8;
            this.txtProfesor_nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProfesor_nombre_KeyPress);
            // 
            // txtProfesor_segundoApellido
            // 
            this.txtProfesor_segundoApellido.Location = new System.Drawing.Point(19, 259);
            this.txtProfesor_segundoApellido.Margin = new System.Windows.Forms.Padding(2);
            this.txtProfesor_segundoApellido.MaxLength = 50;
            this.txtProfesor_segundoApellido.Name = "txtProfesor_segundoApellido";
            this.txtProfesor_segundoApellido.Size = new System.Drawing.Size(256, 20);
            this.txtProfesor_segundoApellido.TabIndex = 10;
            this.txtProfesor_segundoApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProfesor_segundoApellido_KeyPress);
            // 
            // txtProfesor_primerApellido
            // 
            this.txtProfesor_primerApellido.Location = new System.Drawing.Point(19, 202);
            this.txtProfesor_primerApellido.Margin = new System.Windows.Forms.Padding(2);
            this.txtProfesor_primerApellido.MaxLength = 50;
            this.txtProfesor_primerApellido.Name = "txtProfesor_primerApellido";
            this.txtProfesor_primerApellido.Size = new System.Drawing.Size(256, 20);
            this.txtProfesor_primerApellido.TabIndex = 9;
            this.txtProfesor_primerApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProfesor_primerApellido_KeyPress);
            // 
            // txtProfesor_correoElectronico
            // 
            this.txtProfesor_correoElectronico.Location = new System.Drawing.Point(19, 355);
            this.txtProfesor_correoElectronico.Margin = new System.Windows.Forms.Padding(2);
            this.txtProfesor_correoElectronico.MaxLength = 50;
            this.txtProfesor_correoElectronico.Name = "txtProfesor_correoElectronico";
            this.txtProfesor_correoElectronico.Size = new System.Drawing.Size(256, 20);
            this.txtProfesor_correoElectronico.TabIndex = 12;
            // 
            // txtProfesor_telefono
            // 
            this.txtProfesor_telefono.Location = new System.Drawing.Point(88, 297);
            this.txtProfesor_telefono.Margin = new System.Windows.Forms.Padding(2);
            this.txtProfesor_telefono.MaxLength = 20;
            this.txtProfesor_telefono.Name = "txtProfesor_telefono";
            this.txtProfesor_telefono.Size = new System.Drawing.Size(187, 20);
            this.txtProfesor_telefono.TabIndex = 11;
            this.txtProfesor_telefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProfesor_telefono_KeyPress);
            // 
            // txtProfesor_direccion
            // 
            this.txtProfesor_direccion.Location = new System.Drawing.Point(19, 400);
            this.txtProfesor_direccion.Margin = new System.Windows.Forms.Padding(2);
            this.txtProfesor_direccion.MaxLength = 50;
            this.txtProfesor_direccion.Name = "txtProfesor_direccion";
            this.txtProfesor_direccion.Size = new System.Drawing.Size(256, 20);
            this.txtProfesor_direccion.TabIndex = 13;
            // 
            // btnProfesor_Insertar
            // 
            this.btnProfesor_Insertar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnProfesor_Insertar.FlatAppearance.BorderSize = 0;
            this.btnProfesor_Insertar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfesor_Insertar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfesor_Insertar.Location = new System.Drawing.Point(17, 503);
            this.btnProfesor_Insertar.Margin = new System.Windows.Forms.Padding(2);
            this.btnProfesor_Insertar.Name = "btnProfesor_Insertar";
            this.btnProfesor_Insertar.Size = new System.Drawing.Size(244, 50);
            this.btnProfesor_Insertar.TabIndex = 14;
            this.btnProfesor_Insertar.Text = "Insertar";
            this.btnProfesor_Insertar.UseVisualStyleBackColor = false;
            this.btnProfesor_Insertar.Click += new System.EventHandler(this.btnProfesor_Insertar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(147, 436);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(114, 49);
            this.btnModificar.TabIndex = 15;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // dgvProfesores
            // 
            this.dgvProfesores.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgvProfesores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProfesores.Location = new System.Drawing.Point(294, 91);
            this.dgvProfesores.Margin = new System.Windows.Forms.Padding(2);
            this.dgvProfesores.Name = "dgvProfesores";
            this.dgvProfesores.RowHeadersWidth = 51;
            this.dgvProfesores.RowTemplate.Height = 24;
            this.dgvProfesores.Size = new System.Drawing.Size(654, 449);
            this.dgvProfesores.TabIndex = 16;
            this.dgvProfesores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProfesores_CellClick);
            this.dgvProfesores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProfesores_CellContentClick);
            // 
            // cbxProfesor
            // 
            this.cbxProfesor.FormattingEnabled = true;
            this.cbxProfesor.Location = new System.Drawing.Point(512, 59);
            this.cbxProfesor.Margin = new System.Windows.Forms.Padding(2);
            this.cbxProfesor.Name = "cbxProfesor";
            this.cbxProfesor.Size = new System.Drawing.Size(207, 21);
            this.cbxProfesor.TabIndex = 17;
            this.cbxProfesor.SelectedIndexChanged += new System.EventHandler(this.cbxProfesor_SelectedIndexChanged);
            // 
            // btnCargarDatos
            // 
            this.btnCargarDatos.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCargarDatos.FlatAppearance.BorderSize = 0;
            this.btnCargarDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarDatos.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarDatos.Location = new System.Drawing.Point(723, 31);
            this.btnCargarDatos.Margin = new System.Windows.Forms.Padding(2);
            this.btnCargarDatos.Name = "btnCargarDatos";
            this.btnCargarDatos.Size = new System.Drawing.Size(225, 50);
            this.btnCargarDatos.TabIndex = 18;
            this.btnCargarDatos.Text = "Cargar Datos";
            this.btnCargarDatos.UseVisualStyleBackColor = false;
            this.btnCargarDatos.Click += new System.EventHandler(this.btnCargarDatos_Click);
            // 
            // btnReporteProfesores
            // 
            this.btnReporteProfesores.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnReporteProfesores.FlatAppearance.BorderSize = 0;
            this.btnReporteProfesores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporteProfesores.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporteProfesores.Location = new System.Drawing.Point(747, 553);
            this.btnReporteProfesores.Margin = new System.Windows.Forms.Padding(2);
            this.btnReporteProfesores.Name = "btnReporteProfesores";
            this.btnReporteProfesores.Size = new System.Drawing.Size(201, 65);
            this.btnReporteProfesores.TabIndex = 19;
            this.btnReporteProfesores.Text = "Reporte Profesores";
            this.btnReporteProfesores.UseVisualStyleBackColor = false;
            this.btnReporteProfesores.Click += new System.EventHandler(this.btnReporteProfesores_Click);
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.BackColor = System.Drawing.SystemColors.Control;
            this.Titulo.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.Titulo.Location = new System.Drawing.Point(123, 7);
            this.Titulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(138, 38);
            this.Titulo.TabIndex = 20;
            this.Titulo.Text = "Profesor";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(19, 436);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(114, 50);
            this.btnLimpiar.TabIndex = 21;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(19, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(17, 569);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(244, 51);
            this.btnEliminar.TabIndex = 23;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnReporteCursosProfesor
            // 
            this.btnReporteCursosProfesor.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnReporteCursosProfesor.FlatAppearance.BorderSize = 0;
            this.btnReporteCursosProfesor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporteCursosProfesor.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporteCursosProfesor.Location = new System.Drawing.Point(488, 553);
            this.btnReporteCursosProfesor.Margin = new System.Windows.Forms.Padding(2);
            this.btnReporteCursosProfesor.Name = "btnReporteCursosProfesor";
            this.btnReporteCursosProfesor.Size = new System.Drawing.Size(231, 67);
            this.btnReporteCursosProfesor.TabIndex = 24;
            this.btnReporteCursosProfesor.Text = "Reporte Cursos \r\n Profesor";
            this.btnReporteCursosProfesor.UseVisualStyleBackColor = false;
            this.btnReporteCursosProfesor.Click += new System.EventHandler(this.btnReporteCursosProfesor_Click);
            // 
            // btnActivarEliminado
            // 
            this.btnActivarEliminado.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnActivarEliminado.FlatAppearance.BorderSize = 0;
            this.btnActivarEliminado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActivarEliminado.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActivarEliminado.Location = new System.Drawing.Point(294, 553);
            this.btnActivarEliminado.Margin = new System.Windows.Forms.Padding(2);
            this.btnActivarEliminado.Name = "btnActivarEliminado";
            this.btnActivarEliminado.Size = new System.Drawing.Size(155, 67);
            this.btnActivarEliminado.TabIndex = 25;
            this.btnActivarEliminado.Text = "Activar \r\nEliminado";
            this.btnActivarEliminado.UseVisualStyleBackColor = false;
            this.btnActivarEliminado.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // chkbxMostrarEliminados
            // 
            this.chkbxMostrarEliminados.AutoSize = true;
            this.chkbxMostrarEliminados.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbxMostrarEliminados.Location = new System.Drawing.Point(294, 59);
            this.chkbxMostrarEliminados.Name = "chkbxMostrarEliminados";
            this.chkbxMostrarEliminados.Size = new System.Drawing.Size(173, 25);
            this.chkbxMostrarEliminados.TabIndex = 26;
            this.chkbxMostrarEliminados.Text = "Mostrar Eliminados";
            this.chkbxMostrarEliminados.UseVisualStyleBackColor = true;
            this.chkbxMostrarEliminados.CheckedChanged += new System.EventHandler(this.chkbxMostrarEliminados_CheckedChanged);
            // 
            // frmProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 629);
            this.Controls.Add(this.chkbxMostrarEliminados);
            this.Controls.Add(this.btnActivarEliminado);
            this.Controls.Add(this.btnReporteCursosProfesor);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.btnReporteProfesores);
            this.Controls.Add(this.btnCargarDatos);
            this.Controls.Add(this.cbxProfesor);
            this.Controls.Add(this.dgvProfesores);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnProfesor_Insertar);
            this.Controls.Add(this.txtProfesor_direccion);
            this.Controls.Add(this.txtProfesor_correoElectronico);
            this.Controls.Add(this.txtProfesor_telefono);
            this.Controls.Add(this.txtProfesor_segundoApellido);
            this.Controls.Add(this.txtProfesor_primerApellido);
            this.Controls.Add(this.txtProfesor_nombre);
            this.Controls.Add(this.txtProfesor_cedula);
            this.Controls.Add(this.lblProfesor_direccion);
            this.Controls.Add(this.lblProfesor_correoElectronico);
            this.Controls.Add(this.lblProfesor_telefono);
            this.Controls.Add(this.lblProfesor_segundoApellido);
            this.Controls.Add(this.lblProfesor_primerApellido);
            this.Controls.Add(this.lblProfesor_nombre);
            this.Controls.Add(this.lblProfesor_cedula);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmProfesor";
            this.Text = "Sistema Matricula = Modulo Profesor";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfesores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void dgvProfesores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        #endregion

        private System.Windows.Forms.Label lblProfesor_cedula;
        private System.Windows.Forms.Label lblProfesor_nombre;
        private System.Windows.Forms.Label lblProfesor_primerApellido;
        private System.Windows.Forms.Label lblProfesor_correoElectronico;
        private System.Windows.Forms.Label lblProfesor_telefono;
        private System.Windows.Forms.Label lblProfesor_segundoApellido;
        private System.Windows.Forms.Label lblProfesor_direccion;
        private System.Windows.Forms.TextBox txtProfesor_cedula;
        private System.Windows.Forms.TextBox txtProfesor_nombre;
        private System.Windows.Forms.TextBox txtProfesor_segundoApellido;
        private System.Windows.Forms.TextBox txtProfesor_primerApellido;
        private System.Windows.Forms.TextBox txtProfesor_correoElectronico;
        private System.Windows.Forms.TextBox txtProfesor_telefono;
        private System.Windows.Forms.TextBox txtProfesor_direccion;
        private System.Windows.Forms.Button btnProfesor_Insertar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.DataGridView dgvProfesores;
        private System.Windows.Forms.ComboBox cbxProfesor;
        private System.Windows.Forms.Button btnCargarDatos;
        private Button btnReporteProfesores;
        private Label Titulo;
        private Button btnLimpiar;
        private PictureBox pictureBox1;
        private Button btnEliminar;
        private Button btnReporteCursosProfesor;
        private Button btnActivarEliminado;
        private CheckBox chkbxMostrarEliminados;
    }
}

