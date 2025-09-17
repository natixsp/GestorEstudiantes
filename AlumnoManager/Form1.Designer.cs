namespace AlumnoManager
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle64 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle65 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle66 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabRegistro = new System.Windows.Forms.TabPage();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.grpActividdades = new System.Windows.Forms.GroupBox();
            this.chkArte = new System.Windows.Forms.CheckBox();
            this.chkMusica = new System.Windows.Forms.CheckBox();
            this.chkDeportes = new System.Windows.Forms.CheckBox();
            this.grpGenero = new System.Windows.Forms.GroupBox();
            this.rdoFemenino = new System.Windows.Forms.RadioButton();
            this.rdoMasculino = new System.Windows.Forms.RadioButton();
            this.grpDatosPersonales = new System.Windows.Forms.GroupBox();
            this.txtNota3 = new System.Windows.Forms.TextBox();
            this.txtNota2 = new System.Windows.Forms.TextBox();
            this.txtNota1 = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabVisualizacion = new System.Windows.Forms.TabPage();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblNota3 = new System.Windows.Forms.Label();
            this.lblNota2 = new System.Windows.Forms.Label();
            this.lblNota1 = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.picEstado = new System.Windows.Forms.PictureBox();
            this.lstNombres = new System.Windows.Forms.ListBox();
            this.dgvEstudiantes = new System.Windows.Forms.DataGridView();
            this.tabCorreo = new System.Windows.Forms.TabPage();
            this.lstEstudiantesCorreo = new System.Windows.Forms.ListBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.btnEnviarCorreo = new System.Windows.Forms.Button();
            this.txtEmailDestino = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnRecibirCorreo = new System.Windows.Forms.Button();
            this.lstCorreosRecibidos = new System.Windows.Forms.ListBox();
            this.label15 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControlMain.SuspendLayout();
            this.tabRegistro.SuspendLayout();
            this.grpActividdades.SuspendLayout();
            this.grpGenero.SuspendLayout();
            this.grpDatosPersonales.SuspendLayout();
            this.tabVisualizacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEstado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiantes)).BeginInit();
            this.tabCorreo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabRegistro);
            this.tabControlMain.Controls.Add(this.tabVisualizacion);
            this.tabControlMain.Controls.Add(this.tabCorreo);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(961, 675);
            this.tabControlMain.TabIndex = 0;
            this.tabControlMain.SelectedIndexChanged += new System.EventHandler(this.tabControlMain_SelectedIndexChanged);
            // 
            // tabRegistro
            // 
            this.tabRegistro.BackColor = System.Drawing.Color.LavenderBlush;
            this.tabRegistro.Controls.Add(this.btnRegistrar);
            this.tabRegistro.Controls.Add(this.grpActividdades);
            this.tabRegistro.Controls.Add(this.grpGenero);
            this.tabRegistro.Controls.Add(this.grpDatosPersonales);
            this.tabRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabRegistro.Location = new System.Drawing.Point(4, 31);
            this.tabRegistro.Name = "tabRegistro";
            this.tabRegistro.Padding = new System.Windows.Forms.Padding(3);
            this.tabRegistro.Size = new System.Drawing.Size(953, 640);
            this.tabRegistro.TabIndex = 0;
            this.tabRegistro.Text = "Registro de Estudiantes";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegistrar.BackColor = System.Drawing.Color.LightPink;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Location = new System.Drawing.Point(389, 536);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(188, 36);
            this.btnRegistrar.TabIndex = 3;
            this.btnRegistrar.Text = "Registrar Estudiante";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            this.btnRegistrar.MouseEnter += new System.EventHandler(this.btnRegistrar_MouseEnter);
            this.btnRegistrar.MouseLeave += new System.EventHandler(this.btnRegistrar_MouseLeave);
            // 
            // grpActividdades
            // 
            this.grpActividdades.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpActividdades.Controls.Add(this.chkArte);
            this.grpActividdades.Controls.Add(this.chkMusica);
            this.grpActividdades.Controls.Add(this.chkDeportes);
            this.grpActividdades.Location = new System.Drawing.Point(663, 288);
            this.grpActividdades.Name = "grpActividdades";
            this.grpActividdades.Size = new System.Drawing.Size(210, 187);
            this.grpActividdades.TabIndex = 2;
            this.grpActividdades.TabStop = false;
            this.grpActividdades.Text = "Actividades";
            // 
            // chkArte
            // 
            this.chkArte.AutoSize = true;
            this.chkArte.Location = new System.Drawing.Point(55, 131);
            this.chkArte.Name = "chkArte";
            this.chkArte.Size = new System.Drawing.Size(70, 29);
            this.chkArte.TabIndex = 2;
            this.chkArte.Text = "Arte";
            this.chkArte.UseVisualStyleBackColor = true;
            // 
            // chkMusica
            // 
            this.chkMusica.AutoSize = true;
            this.chkMusica.Location = new System.Drawing.Point(55, 88);
            this.chkMusica.Name = "chkMusica";
            this.chkMusica.Size = new System.Drawing.Size(97, 29);
            this.chkMusica.TabIndex = 1;
            this.chkMusica.Text = "Música";
            this.chkMusica.UseVisualStyleBackColor = true;
            // 
            // chkDeportes
            // 
            this.chkDeportes.AutoSize = true;
            this.chkDeportes.Location = new System.Drawing.Point(55, 46);
            this.chkDeportes.Name = "chkDeportes";
            this.chkDeportes.Size = new System.Drawing.Size(113, 29);
            this.chkDeportes.TabIndex = 0;
            this.chkDeportes.Text = "Deportes";
            this.chkDeportes.UseVisualStyleBackColor = true;
            // 
            // grpGenero
            // 
            this.grpGenero.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpGenero.Controls.Add(this.rdoFemenino);
            this.grpGenero.Controls.Add(this.rdoMasculino);
            this.grpGenero.Location = new System.Drawing.Point(675, 78);
            this.grpGenero.Name = "grpGenero";
            this.grpGenero.Size = new System.Drawing.Size(183, 154);
            this.grpGenero.TabIndex = 1;
            this.grpGenero.TabStop = false;
            this.grpGenero.Text = "Género";
            // 
            // rdoFemenino
            // 
            this.rdoFemenino.AutoSize = true;
            this.rdoFemenino.Location = new System.Drawing.Point(38, 85);
            this.rdoFemenino.Name = "rdoFemenino";
            this.rdoFemenino.Size = new System.Drawing.Size(120, 29);
            this.rdoFemenino.TabIndex = 1;
            this.rdoFemenino.TabStop = true;
            this.rdoFemenino.Text = "Femenino";
            this.rdoFemenino.UseVisualStyleBackColor = true;
            // 
            // rdoMasculino
            // 
            this.rdoMasculino.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdoMasculino.AutoSize = true;
            this.rdoMasculino.Location = new System.Drawing.Point(38, 43);
            this.rdoMasculino.Name = "rdoMasculino";
            this.rdoMasculino.Size = new System.Drawing.Size(122, 29);
            this.rdoMasculino.TabIndex = 0;
            this.rdoMasculino.TabStop = true;
            this.rdoMasculino.Text = "Masculino";
            this.rdoMasculino.UseVisualStyleBackColor = true;
            // 
            // grpDatosPersonales
            // 
            this.grpDatosPersonales.Controls.Add(this.txtNota3);
            this.grpDatosPersonales.Controls.Add(this.txtNota2);
            this.grpDatosPersonales.Controls.Add(this.txtNota1);
            this.grpDatosPersonales.Controls.Add(this.txtEdad);
            this.grpDatosPersonales.Controls.Add(this.txtNombre);
            this.grpDatosPersonales.Controls.Add(this.label5);
            this.grpDatosPersonales.Controls.Add(this.label4);
            this.grpDatosPersonales.Controls.Add(this.label3);
            this.grpDatosPersonales.Controls.Add(this.label2);
            this.grpDatosPersonales.Controls.Add(this.label1);
            this.grpDatosPersonales.Location = new System.Drawing.Point(91, 121);
            this.grpDatosPersonales.Name = "grpDatosPersonales";
            this.grpDatosPersonales.Size = new System.Drawing.Size(472, 300);
            this.grpDatosPersonales.TabIndex = 0;
            this.grpDatosPersonales.TabStop = false;
            this.grpDatosPersonales.Text = "Datos Personales";
            // 
            // txtNota3
            // 
            this.txtNota3.Location = new System.Drawing.Point(331, 209);
            this.txtNota3.Name = "txtNota3";
            this.txtNota3.Size = new System.Drawing.Size(100, 30);
            this.txtNota3.TabIndex = 9;
            this.txtNota3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNota3.Enter += new System.EventHandler(this.txtNota3_Enter);
            this.txtNota3.Leave += new System.EventHandler(this.txtNota3_Leave);
            // 
            // txtNota2
            // 
            this.txtNota2.Location = new System.Drawing.Point(188, 209);
            this.txtNota2.Name = "txtNota2";
            this.txtNota2.Size = new System.Drawing.Size(100, 30);
            this.txtNota2.TabIndex = 8;
            this.txtNota2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNota2.Enter += new System.EventHandler(this.txtNota2_Enter);
            this.txtNota2.Leave += new System.EventHandler(this.txtNota2_Leave);
            // 
            // txtNota1
            // 
            this.txtNota1.Location = new System.Drawing.Point(38, 209);
            this.txtNota1.Name = "txtNota1";
            this.txtNota1.Size = new System.Drawing.Size(100, 30);
            this.txtNota1.TabIndex = 7;
            this.txtNota1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNota1.Enter += new System.EventHandler(this.txtNota1_Enter);
            this.txtNota1.Leave += new System.EventHandler(this.txtNota1_Leave);
            // 
            // txtEdad
            // 
            this.txtEdad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEdad.Location = new System.Drawing.Point(160, 105);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(100, 30);
            this.txtEdad.TabIndex = 6;
            this.txtEdad.TextChanged += new System.EventHandler(this.txtEdad_TextChanged);
            this.txtEdad.Enter += new System.EventHandler(this.txtEdad_Enter);
            this.txtEdad.Leave += new System.EventHandler(this.txtEdad_Leave);
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.Location = new System.Drawing.Point(160, 65);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(162, 30);
            this.txtNombre.TabIndex = 5;
            this.txtNombre.Enter += new System.EventHandler(this.txtNombre_Enter);
            this.txtNombre.Leave += new System.EventHandler(this.txtNombre_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(346, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nota 3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(202, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nota 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nota 1";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Edad";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // tabVisualizacion
            // 
            this.tabVisualizacion.BackColor = System.Drawing.Color.LavenderBlush;
            this.tabVisualizacion.Controls.Add(this.label13);
            this.tabVisualizacion.Controls.Add(this.label12);
            this.tabVisualizacion.Controls.Add(this.label11);
            this.tabVisualizacion.Controls.Add(this.label10);
            this.tabVisualizacion.Controls.Add(this.label9);
            this.tabVisualizacion.Controls.Add(this.label8);
            this.tabVisualizacion.Controls.Add(this.btnBuscar);
            this.tabVisualizacion.Controls.Add(this.txtBuscar);
            this.tabVisualizacion.Controls.Add(this.label6);
            this.tabVisualizacion.Controls.Add(this.lblNota3);
            this.tabVisualizacion.Controls.Add(this.lblNota2);
            this.tabVisualizacion.Controls.Add(this.lblNota1);
            this.tabVisualizacion.Controls.Add(this.lblEdad);
            this.tabVisualizacion.Controls.Add(this.lblNombre);
            this.tabVisualizacion.Controls.Add(this.picEstado);
            this.tabVisualizacion.Controls.Add(this.lstNombres);
            this.tabVisualizacion.Controls.Add(this.dgvEstudiantes);
            this.tabVisualizacion.Location = new System.Drawing.Point(4, 31);
            this.tabVisualizacion.Name = "tabVisualizacion";
            this.tabVisualizacion.Padding = new System.Windows.Forms.Padding(3);
            this.tabVisualizacion.Size = new System.Drawing.Size(953, 640);
            this.tabVisualizacion.TabIndex = 1;
            this.tabVisualizacion.Text = "Visualización";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.BackColor = System.Drawing.Color.LightPink;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Location = new System.Drawing.Point(708, 434);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(88, 42);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            this.btnBuscar.MouseEnter += new System.EventHandler(this.btnBuscar_MouseEnter);
            this.btnBuscar.MouseLeave += new System.EventHandler(this.btnBuscar_MouseLeave);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscar.Location = new System.Drawing.Point(665, 390);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(174, 28);
            this.txtBuscar.TabIndex = 9;
            this.txtBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBuscar.Enter += new System.EventHandler(this.txtBuscar_Enter);
            this.txtBuscar.Leave += new System.EventHandler(this.txtBuscar_Leave);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(369, 323);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(199, 22);
            this.label6.TabIndex = 8;
            this.label6.Text = "Detalles del Estudiante:";
            // 
            // lblNota3
            // 
            this.lblNota3.AutoSize = true;
            this.lblNota3.Location = new System.Drawing.Point(463, 454);
            this.lblNota3.Name = "lblNota3";
            this.lblNota3.Size = new System.Drawing.Size(0, 22);
            this.lblNota3.TabIndex = 7;
            // 
            // lblNota2
            // 
            this.lblNota2.AutoSize = true;
            this.lblNota2.Location = new System.Drawing.Point(463, 432);
            this.lblNota2.Name = "lblNota2";
            this.lblNota2.Size = new System.Drawing.Size(0, 22);
            this.lblNota2.TabIndex = 6;
            // 
            // lblNota1
            // 
            this.lblNota1.AutoSize = true;
            this.lblNota1.Location = new System.Drawing.Point(463, 410);
            this.lblNota1.Name = "lblNota1";
            this.lblNota1.Size = new System.Drawing.Size(0, 22);
            this.lblNota1.TabIndex = 5;
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(463, 388);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(0, 22);
            this.lblEdad.TabIndex = 4;
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(463, 366);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(0, 22);
            this.lblNombre.TabIndex = 3;
            // 
            // picEstado
            // 
            this.picEstado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.picEstado.Location = new System.Drawing.Point(358, 486);
            this.picEstado.Name = "picEstado";
            this.picEstado.Size = new System.Drawing.Size(168, 123);
            this.picEstado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEstado.TabIndex = 2;
            this.picEstado.TabStop = false;
            // 
            // lstNombres
            // 
            this.lstNombres.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lstNombres.FormattingEnabled = true;
            this.lstNombres.ItemHeight = 22;
            this.lstNombres.Location = new System.Drawing.Point(3, 281);
            this.lstNombres.Name = "lstNombres";
            this.lstNombres.Size = new System.Drawing.Size(249, 356);
            this.lstNombres.TabIndex = 1;
            this.lstNombres.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lstNombres_DrawItem);
            this.lstNombres.SelectedIndexChanged += new System.EventHandler(this.lstNombres_SelectedIndexChanged);
            // 
            // dgvEstudiantes
            // 
            dataGridViewCellStyle64.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle64.SelectionBackColor = System.Drawing.Color.LightPink;
            dataGridViewCellStyle64.SelectionForeColor = System.Drawing.SystemColors.Window;
            this.dgvEstudiantes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle64;
            this.dgvEstudiantes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEstudiantes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvEstudiantes.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvEstudiantes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle65.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle65.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle65.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle65.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle65.SelectionBackColor = System.Drawing.Color.LightPink;
            dataGridViewCellStyle65.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle65.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEstudiantes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle65;
            this.dgvEstudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle66.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle66.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle66.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle66.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle66.SelectionBackColor = System.Drawing.Color.LightPink;
            dataGridViewCellStyle66.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle66.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEstudiantes.DefaultCellStyle = dataGridViewCellStyle66;
            this.dgvEstudiantes.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvEstudiantes.Location = new System.Drawing.Point(3, 3);
            this.dgvEstudiantes.Name = "dgvEstudiantes";
            this.dgvEstudiantes.ReadOnly = true;
            this.dgvEstudiantes.RowHeadersVisible = false;
            this.dgvEstudiantes.RowHeadersWidth = 51;
            this.dgvEstudiantes.RowTemplate.Height = 24;
            this.dgvEstudiantes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEstudiantes.Size = new System.Drawing.Size(947, 254);
            this.dgvEstudiantes.TabIndex = 0;
            this.dgvEstudiantes.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEstudiantes_CellContentDoubleClick);
            // 
            // tabCorreo
            // 
            this.tabCorreo.BackColor = System.Drawing.Color.LavenderBlush;
            this.tabCorreo.Controls.Add(this.panel2);
            this.tabCorreo.Controls.Add(this.panel1);
            this.tabCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabCorreo.Location = new System.Drawing.Point(4, 31);
            this.tabCorreo.Name = "tabCorreo";
            this.tabCorreo.Padding = new System.Windows.Forms.Padding(3);
            this.tabCorreo.Size = new System.Drawing.Size(953, 640);
            this.tabCorreo.TabIndex = 2;
            this.tabCorreo.Text = "Correo";
            // 
            // lstEstudiantesCorreo
            // 
            this.lstEstudiantesCorreo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lstEstudiantesCorreo.BackColor = System.Drawing.SystemColors.Window;
            this.lstEstudiantesCorreo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstEstudiantesCorreo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lstEstudiantesCorreo.FormattingEnabled = true;
            this.lstEstudiantesCorreo.ItemHeight = 25;
            this.lstEstudiantesCorreo.Location = new System.Drawing.Point(107, 262);
            this.lstEstudiantesCorreo.Name = "lstEstudiantesCorreo";
            this.lstEstudiantesCorreo.Size = new System.Drawing.Size(228, 177);
            this.lstEstudiantesCorreo.TabIndex = 4;
            this.lstEstudiantesCorreo.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lstEstudiantesCorreo_DrawItem);
            this.lstEstudiantesCorreo.SelectedIndexChanged += new System.EventHandler(this.lstEstudiantesCorreo_SelectedIndexChanged);
            // 
            // lblEstado
            // 
            this.lblEstado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(155, 67);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(190, 22);
            this.lblEstado.TabIndex = 3;
            this.lblEstado.Text = "Recepción de correos:";
            // 
            // btnEnviarCorreo
            // 
            this.btnEnviarCorreo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnviarCorreo.BackColor = System.Drawing.Color.LightPink;
            this.btnEnviarCorreo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviarCorreo.Location = new System.Drawing.Point(107, 507);
            this.btnEnviarCorreo.Name = "btnEnviarCorreo";
            this.btnEnviarCorreo.Size = new System.Drawing.Size(228, 41);
            this.btnEnviarCorreo.TabIndex = 2;
            this.btnEnviarCorreo.Text = "Enviar Correo";
            this.btnEnviarCorreo.UseVisualStyleBackColor = false;
            this.btnEnviarCorreo.Click += new System.EventHandler(this.btnEnviarCorreo_Click);
            this.btnEnviarCorreo.MouseEnter += new System.EventHandler(this.btnEnviarCorreo_MouseEnter);
            this.btnEnviarCorreo.MouseLeave += new System.EventHandler(this.btnEnviarCorreo_MouseLeave);
            // 
            // txtEmailDestino
            // 
            this.txtEmailDestino.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmailDestino.Location = new System.Drawing.Point(78, 105);
            this.txtEmailDestino.Name = "txtEmailDestino";
            this.txtEmailDestino.Size = new System.Drawing.Size(283, 28);
            this.txtEmailDestino.TabIndex = 1;
            this.txtEmailDestino.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEmailDestino.Enter += new System.EventHandler(this.txtEmailDestino_Enter);
            this.txtEmailDestino.Leave += new System.EventHandler(this.txtEmailDestino_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(125, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(238, 22);
            this.label7.TabIndex = 0;
            this.label7.Text = "Escribe el correo de destino:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(379, 366);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 22);
            this.label8.TabIndex = 11;
            this.label8.Text = "Nombre:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(379, 388);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 22);
            this.label9.TabIndex = 12;
            this.label9.Text = "Edad:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(379, 411);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 22);
            this.label10.TabIndex = 13;
            this.label10.Text = "Nota 1:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(379, 432);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 22);
            this.label11.TabIndex = 14;
            this.label11.Text = "Nota 2:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(379, 454);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 22);
            this.label12.TabIndex = 15;
            this.label12.Text = "Nota 3:";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(645, 365);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(255, 22);
            this.label13.TabIndex = 16;
            this.label13.Text = "Buscar estudiante por nombre:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(140, 170);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(210, 22);
            this.label14.TabIndex = 5;
            this.label14.Text = "Selecciona el estudiante:";
            // 
            // btnRecibirCorreo
            // 
            this.btnRecibirCorreo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRecibirCorreo.BackColor = System.Drawing.Color.LightPink;
            this.btnRecibirCorreo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecibirCorreo.Location = new System.Drawing.Point(191, 136);
            this.btnRecibirCorreo.Name = "btnRecibirCorreo";
            this.btnRecibirCorreo.Size = new System.Drawing.Size(93, 41);
            this.btnRecibirCorreo.TabIndex = 6;
            this.btnRecibirCorreo.Text = "Ver";
            this.btnRecibirCorreo.UseVisualStyleBackColor = false;
            this.btnRecibirCorreo.Click += new System.EventHandler(this.btnRecibirCorreo_Click);
            this.btnRecibirCorreo.MouseEnter += new System.EventHandler(this.btnRecibirCorreo_MouseEnter);
            this.btnRecibirCorreo.MouseLeave += new System.EventHandler(this.btnRecibirCorreo_MouseLeave);
            // 
            // lstCorreosRecibidos
            // 
            this.lstCorreosRecibidos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lstCorreosRecibidos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstCorreosRecibidos.FormattingEnabled = true;
            this.lstCorreosRecibidos.HorizontalScrollbar = true;
            this.lstCorreosRecibidos.ItemHeight = 22;
            this.lstCorreosRecibidos.Location = new System.Drawing.Point(83, 302);
            this.lstCorreosRecibidos.Name = "lstCorreosRecibidos";
            this.lstCorreosRecibidos.Size = new System.Drawing.Size(300, 134);
            this.lstCorreosRecibidos.TabIndex = 7;
            this.lstCorreosRecibidos.DoubleClick += new System.EventHandler(this.lstCorreosRecibidos_DoubleClick);
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(95, 237);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(324, 22);
            this.label15.TabIndex = 8;
            this.label15.Text = "Lista de los ultimos 5 correos recibidos:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblEstado);
            this.panel1.Controls.Add(this.lstCorreosRecibidos);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.btnRecibirCorreo);
            this.panel1.Location = new System.Drawing.Point(482, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(468, 634);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtEmailDestino);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.btnEnviarCorreo);
            this.panel2.Controls.Add(this.lstEstudiantesCorreo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(450, 634);
            this.panel2.TabIndex = 10;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(961, 675);
            this.Controls.Add(this.tabControlMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GESTIÓN DE ESTUDIANTES";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControlMain.ResumeLayout(false);
            this.tabRegistro.ResumeLayout(false);
            this.grpActividdades.ResumeLayout(false);
            this.grpActividdades.PerformLayout();
            this.grpGenero.ResumeLayout(false);
            this.grpGenero.PerformLayout();
            this.grpDatosPersonales.ResumeLayout(false);
            this.grpDatosPersonales.PerformLayout();
            this.tabVisualizacion.ResumeLayout(false);
            this.tabVisualizacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEstado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiantes)).EndInit();
            this.tabCorreo.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabRegistro;
        private System.Windows.Forms.TabPage tabVisualizacion;
        private System.Windows.Forms.TabPage tabCorreo;
        private System.Windows.Forms.GroupBox grpDatosPersonales;
        private System.Windows.Forms.TextBox txtNota3;
        private System.Windows.Forms.TextBox txtNota2;
        private System.Windows.Forms.TextBox txtNota1;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpGenero;
        private System.Windows.Forms.GroupBox grpActividdades;
        private System.Windows.Forms.CheckBox chkArte;
        private System.Windows.Forms.CheckBox chkMusica;
        private System.Windows.Forms.CheckBox chkDeportes;
        private System.Windows.Forms.RadioButton rdoFemenino;
        private System.Windows.Forms.RadioButton rdoMasculino;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.DataGridView dgvEstudiantes;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.PictureBox picEstado;
        private System.Windows.Forms.ListBox lstNombres;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Button btnEnviarCorreo;
        private System.Windows.Forms.TextBox txtEmailDestino;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblNota3;
        private System.Windows.Forms.Label lblNota2;
        private System.Windows.Forms.Label lblNota1;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.ListBox lstEstudiantesCorreo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ListBox lstCorreosRecibidos;
        private System.Windows.Forms.Button btnRecibirCorreo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel2;
    }
}

