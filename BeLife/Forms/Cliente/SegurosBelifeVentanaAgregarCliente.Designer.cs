namespace BeLife
{
    partial class VentanaAgregarCliente
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaAgregarCliente));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.TxtRut = new System.Windows.Forms.TextBox();
            this.TxtApellidos = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.Fecha = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.RadioM = new System.Windows.Forms.RadioButton();
            this.RadioF = new System.Windows.Forms.RadioButton();
            this.LblSexo = new System.Windows.Forms.Label();
            this.LblECivil = new System.Windows.Forms.Label();
            this.RadioViudo = new System.Windows.Forms.RadioButton();
            this.RadioCasado = new System.Windows.Forms.RadioButton();
            this.errorRut = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorNombre = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorApellidos = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorFecha = new System.Windows.Forms.ErrorProvider(this.components);
            this.RadiosSexo = new System.Windows.Forms.GroupBox();
            this.RadioDivorciado = new System.Windows.Forms.RadioButton();
            this.RadioSoltero = new System.Windows.Forms.RadioButton();
            this.RadiosEcivil = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnEliminarCliente = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.BtnListadoClientes = new System.Windows.Forms.Button();
            this.btnActualizarCliente = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnRegistrar = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorRut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorApellidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorFecha)).BeginInit();
            this.RadiosSexo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtRut
            // 
            this.TxtRut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtRut.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRut.Location = new System.Drawing.Point(371, 195);
            this.TxtRut.Margin = new System.Windows.Forms.Padding(2);
            this.TxtRut.Name = "TxtRut";
            this.TxtRut.Size = new System.Drawing.Size(334, 28);
            this.TxtRut.TabIndex = 1;
            // 
            // TxtApellidos
            // 
            this.TxtApellidos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtApellidos.Location = new System.Drawing.Point(371, 294);
            this.TxtApellidos.Margin = new System.Windows.Forms.Padding(2);
            this.TxtApellidos.Name = "TxtApellidos";
            this.TxtApellidos.Size = new System.Drawing.Size(334, 28);
            this.TxtApellidos.TabIndex = 3;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.Location = new System.Drawing.Point(371, 245);
            this.TxtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(334, 28);
            this.TxtNombre.TabIndex = 2;
            // 
            // Fecha
            // 
            this.Fecha.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fecha.Location = new System.Drawing.Point(371, 344);
            this.Fecha.Margin = new System.Windows.Forms.Padding(2);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(334, 29);
            this.Fecha.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(186, 195);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "RUT                 :";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(186, 245);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 24);
            this.label2.TabIndex = 18;
            this.label2.Text = "Nombre           :";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(186, 294);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 24);
            this.label3.TabIndex = 19;
            this.label3.Text = "Apellidos         :";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(186, 348);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Fec. Nacimiento   :";
            // 
            // RadioM
            // 
            this.RadioM.AutoSize = true;
            this.RadioM.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioM.Location = new System.Drawing.Point(12, 10);
            this.RadioM.Margin = new System.Windows.Forms.Padding(2);
            this.RadioM.Name = "RadioM";
            this.RadioM.Size = new System.Drawing.Size(114, 28);
            this.RadioM.TabIndex = 22;
            this.RadioM.TabStop = true;
            this.RadioM.Text = "Masculino";
            this.RadioM.UseVisualStyleBackColor = true;
            // 
            // RadioF
            // 
            this.RadioF.AutoSize = true;
            this.RadioF.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioF.Location = new System.Drawing.Point(204, 11);
            this.RadioF.Margin = new System.Windows.Forms.Padding(2);
            this.RadioF.Name = "RadioF";
            this.RadioF.Size = new System.Drawing.Size(115, 28);
            this.RadioF.TabIndex = 23;
            this.RadioF.TabStop = true;
            this.RadioF.Text = "Femenino";
            this.RadioF.UseVisualStyleBackColor = true;
            this.RadioF.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // LblSexo
            // 
            this.LblSexo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblSexo.AutoSize = true;
            this.LblSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSexo.Location = new System.Drawing.Point(186, 387);
            this.LblSexo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblSexo.Name = "LblSexo";
            this.LblSexo.Size = new System.Drawing.Size(160, 24);
            this.LblSexo.TabIndex = 24;
            this.LblSexo.Text = "Sexo                :";
            // 
            // LblECivil
            // 
            this.LblECivil.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblECivil.AutoSize = true;
            this.LblECivil.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblECivil.Location = new System.Drawing.Point(186, 434);
            this.LblECivil.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblECivil.Name = "LblECivil";
            this.LblECivil.Size = new System.Drawing.Size(161, 24);
            this.LblECivil.TabIndex = 25;
            this.LblECivil.Text = "Estado Civil      :";
            // 
            // RadioViudo
            // 
            this.RadioViudo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RadioViudo.AutoSize = true;
            this.RadioViudo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioViudo.Location = new System.Drawing.Point(565, 489);
            this.RadioViudo.Margin = new System.Windows.Forms.Padding(2);
            this.RadioViudo.Name = "RadioViudo";
            this.RadioViudo.Size = new System.Drawing.Size(78, 28);
            this.RadioViudo.TabIndex = 27;
            this.RadioViudo.TabStop = true;
            this.RadioViudo.Text = "Viudo";
            this.RadioViudo.UseVisualStyleBackColor = true;
            // 
            // RadioCasado
            // 
            this.RadioCasado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RadioCasado.AutoSize = true;
            this.RadioCasado.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioCasado.Location = new System.Drawing.Point(565, 446);
            this.RadioCasado.Margin = new System.Windows.Forms.Padding(2);
            this.RadioCasado.Name = "RadioCasado";
            this.RadioCasado.Size = new System.Drawing.Size(92, 28);
            this.RadioCasado.TabIndex = 29;
            this.RadioCasado.TabStop = true;
            this.RadioCasado.Text = "Casado";
            this.RadioCasado.UseVisualStyleBackColor = true;
            // 
            // errorRut
            // 
            this.errorRut.ContainerControl = this;
            // 
            // errorNombre
            // 
            this.errorNombre.ContainerControl = this;
            // 
            // errorApellidos
            // 
            this.errorApellidos.ContainerControl = this;
            // 
            // errorFecha
            // 
            this.errorFecha.ContainerControl = this;
            // 
            // RadiosSexo
            // 
            this.RadiosSexo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RadiosSexo.Controls.Add(this.RadioF);
            this.RadiosSexo.Controls.Add(this.RadioM);
            this.RadiosSexo.Location = new System.Drawing.Point(360, 387);
            this.RadiosSexo.Margin = new System.Windows.Forms.Padding(2);
            this.RadiosSexo.Name = "RadiosSexo";
            this.RadiosSexo.Padding = new System.Windows.Forms.Padding(2);
            this.RadiosSexo.Size = new System.Drawing.Size(345, 159);
            this.RadiosSexo.TabIndex = 5;
            this.RadiosSexo.TabStop = false;
            // 
            // RadioDivorciado
            // 
            this.RadioDivorciado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RadioDivorciado.AutoSize = true;
            this.RadioDivorciado.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioDivorciado.Location = new System.Drawing.Point(371, 489);
            this.RadioDivorciado.Margin = new System.Windows.Forms.Padding(2);
            this.RadioDivorciado.Name = "RadioDivorciado";
            this.RadioDivorciado.Size = new System.Drawing.Size(117, 28);
            this.RadioDivorciado.TabIndex = 26;
            this.RadioDivorciado.TabStop = true;
            this.RadioDivorciado.Text = "Divorciado";
            this.RadioDivorciado.UseVisualStyleBackColor = true;
            // 
            // RadioSoltero
            // 
            this.RadioSoltero.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RadioSoltero.AutoSize = true;
            this.RadioSoltero.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioSoltero.Location = new System.Drawing.Point(371, 444);
            this.RadioSoltero.Margin = new System.Windows.Forms.Padding(2);
            this.RadioSoltero.Name = "RadioSoltero";
            this.RadioSoltero.Size = new System.Drawing.Size(87, 28);
            this.RadioSoltero.TabIndex = 28;
            this.RadioSoltero.TabStop = true;
            this.RadioSoltero.Text = "Soltero";
            this.RadioSoltero.UseVisualStyleBackColor = true;
            // 
            // RadiosEcivil
            // 
            this.RadiosEcivil.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RadiosEcivil.Location = new System.Drawing.Point(360, 444);
            this.RadiosEcivil.Margin = new System.Windows.Forms.Padding(2);
            this.RadiosEcivil.Name = "RadiosEcivil";
            this.RadiosEcivil.Padding = new System.Windows.Forms.Padding(2);
            this.RadiosEcivil.Size = new System.Drawing.Size(110, 106);
            this.RadiosEcivil.TabIndex = 6;
            this.RadiosEcivil.TabStop = false;
            this.RadiosEcivil.Text = "groupBox1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(122, 722);
            this.panel1.TabIndex = 30;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label20);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.btnEliminarCliente);
            this.panel2.Controls.Add(this.btnHome);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.btnBuscarCliente);
            this.panel2.Controls.Add(this.BtnListadoClientes);
            this.panel2.Controls.Add(this.btnActualizarCliente);
            this.panel2.Location = new System.Drawing.Point(15, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(100, 691);
            this.panel2.TabIndex = 57;
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(26, 652);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(37, 13);
            this.label20.TabIndex = 48;
            this.label20.Text = "Volver";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::BeLife.Properties.Resources.arrow1;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(12, 597);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 52);
            this.button1.TabIndex = 10;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(26, 66);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(47, 13);
            this.label19.TabIndex = 47;
            this.label19.Text = "Principal";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(3, 404);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 14);
            this.label7.TabIndex = 55;
            this.label7.Text = "Lista de Clientes";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(6, 517);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 14);
            this.label8.TabIndex = 54;
            this.label8.Text = "Eliminar Cliente";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(3, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 14);
            this.label6.TabIndex = 56;
            this.label6.Text = "Actualizar Cliente";
            // 
            // btnEliminarCliente
            // 
            this.btnEliminarCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarCliente.BackgroundImage = global::BeLife.Properties.Resources.ClientDelete;
            this.btnEliminarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminarCliente.FlatAppearance.BorderSize = 0;
            this.btnEliminarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarCliente.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEliminarCliente.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnEliminarCliente.Location = new System.Drawing.Point(6, 458);
            this.btnEliminarCliente.Name = "btnEliminarCliente";
            this.btnEliminarCliente.Size = new System.Drawing.Size(79, 56);
            this.btnEliminarCliente.TabIndex = 14;
            this.btnEliminarCliente.UseVisualStyleBackColor = true;
            this.btnEliminarCliente.Click += new System.EventHandler(this.btnEliminarCliente_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackgroundImage = global::BeLife.Properties.Resources.home;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHome.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnHome.Location = new System.Drawing.Point(19, 20);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(54, 43);
            this.btnHome.TabIndex = 4;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(6, 171);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 14);
            this.label9.TabIndex = 53;
            this.label9.Text = "Buscar Cliente";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarCliente.BackgroundImage = global::BeLife.Properties.Resources.ClientSearch;
            this.btnBuscarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarCliente.FlatAppearance.BorderSize = 0;
            this.btnBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCliente.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBuscarCliente.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscarCliente.Location = new System.Drawing.Point(14, 107);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(77, 61);
            this.btnBuscarCliente.TabIndex = 15;
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // BtnListadoClientes
            // 
            this.BtnListadoClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnListadoClientes.BackgroundImage = global::BeLife.Properties.Resources.ListClient;
            this.BtnListadoClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnListadoClientes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnListadoClientes.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnListadoClientes.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnListadoClientes.Location = new System.Drawing.Point(12, 337);
            this.BtnListadoClientes.Margin = new System.Windows.Forms.Padding(2);
            this.BtnListadoClientes.Name = "BtnListadoClientes";
            this.BtnListadoClientes.Size = new System.Drawing.Size(84, 65);
            this.BtnListadoClientes.TabIndex = 21;
            this.BtnListadoClientes.UseVisualStyleBackColor = true;
            this.BtnListadoClientes.Click += new System.EventHandler(this.BtnListadoClientes_Click);
            // 
            // btnActualizarCliente
            // 
            this.btnActualizarCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizarCliente.BackgroundImage = global::BeLife.Properties.Resources.ClientUpdate;
            this.btnActualizarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnActualizarCliente.FlatAppearance.BorderSize = 0;
            this.btnActualizarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarCliente.ForeColor = System.Drawing.SystemColors.Control;
            this.btnActualizarCliente.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnActualizarCliente.Location = new System.Drawing.Point(12, 225);
            this.btnActualizarCliente.Name = "btnActualizarCliente";
            this.btnActualizarCliente.Size = new System.Drawing.Size(76, 61);
            this.btnActualizarCliente.TabIndex = 16;
            this.btnActualizarCliente.UseVisualStyleBackColor = true;
            this.btnActualizarCliente.Click += new System.EventHandler(this.btnActualizarCliente_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(374, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(237, 42);
            this.label5.TabIndex = 33;
            this.label5.Text = "Crear Cliente";
            // 
            // BtnRegistrar
            // 
            this.BtnRegistrar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRegistrar.BackColor = System.Drawing.Color.BlueViolet;
            this.BtnRegistrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegistrar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnRegistrar.Location = new System.Drawing.Point(451, 582);
            this.BtnRegistrar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.Size = new System.Drawing.Size(107, 35);
            this.BtnRegistrar.TabIndex = 21;
            this.BtnRegistrar.Text = "Registrar";
            this.BtnRegistrar.UseVisualStyleBackColor = false;
            this.BtnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::BeLife.Properties.Resources.Linea1;
            this.pictureBox2.Location = new System.Drawing.Point(121, 69);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(505, 10);
            this.pictureBox2.TabIndex = 34;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::BeLife.Properties.Resources.Logo_BeLifes_sin_fondo1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(324, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::BeLife.Properties.Resources.Linea1;
            this.pictureBox3.Location = new System.Drawing.Point(329, 69);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(505, 10);
            this.pictureBox3.TabIndex = 35;
            this.pictureBox3.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(121, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(713, 66);
            this.panel3.TabIndex = 36;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(187, 148);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(155, 13);
            this.label10.TabIndex = 37;
            this.label10.Text = "Debe ingresar datos de Cliente:";
            // 
            // VentanaAgregarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 722);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.RadioDivorciado);
            this.Controls.Add(this.RadioSoltero);
            this.Controls.Add(this.RadioCasado);
            this.Controls.Add(this.RadioViudo);
            this.Controls.Add(this.LblECivil);
            this.Controls.Add(this.LblSexo);
            this.Controls.Add(this.BtnRegistrar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Fecha);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.TxtApellidos);
            this.Controls.Add(this.TxtRut);
            this.Controls.Add(this.RadiosSexo);
            this.Controls.Add(this.RadiosEcivil);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VentanaAgregarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Cliente";
            this.Load += new System.EventHandler(this.VentanaAgregarCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorRut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorApellidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorFecha)).EndInit();
            this.RadiosSexo.ResumeLayout(false);
            this.RadiosSexo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox TxtRut;
        private System.Windows.Forms.TextBox TxtApellidos;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.DateTimePicker Fecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton RadioM;
        private System.Windows.Forms.RadioButton RadioF;
        private System.Windows.Forms.Label LblSexo;
        private System.Windows.Forms.Label LblECivil;
        private System.Windows.Forms.RadioButton RadioViudo;
        private System.Windows.Forms.RadioButton RadioCasado;
        private System.Windows.Forms.ErrorProvider errorRut;
        private System.Windows.Forms.ErrorProvider errorNombre;
        private System.Windows.Forms.ErrorProvider errorApellidos;
        private System.Windows.Forms.ErrorProvider errorFecha;
        private System.Windows.Forms.GroupBox RadiosSexo;
        private System.Windows.Forms.RadioButton RadioDivorciado;
        private System.Windows.Forms.RadioButton RadioSoltero;
        private System.Windows.Forms.GroupBox RadiosEcivil;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnListadoClientes;
        private System.Windows.Forms.Button btnEliminarCliente;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Button btnActualizarCliente;
        private System.Windows.Forms.Button BtnRegistrar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label10;
    }
}