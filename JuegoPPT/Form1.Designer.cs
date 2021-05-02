namespace JuegoPPT
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnPiedra = new System.Windows.Forms.Button();
            this.btnPapel = new System.Windows.Forms.Button();
            this.btnTijera = new System.Windows.Forms.Button();
            this.lblPiedra = new System.Windows.Forms.Label();
            this.lblPapel = new System.Windows.Forms.Label();
            this.lblTijera = new System.Windows.Forms.Label();
            this.lblimg1 = new System.Windows.Forms.Label();
            this.lblM1 = new System.Windows.Forms.Label();
            this.lblPuntajeU = new System.Windows.Forms.Label();
            this.lblPuntajeM = new System.Windows.Forms.Label();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.pnlJuego = new System.Windows.Forms.Panel();
            this.lblInicioM = new System.Windows.Forms.Label();
            this.lblInicioU = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblM3 = new System.Windows.Forms.Label();
            this.lblM2 = new System.Windows.Forms.Label();
            this.lblimg3 = new System.Windows.Forms.Label();
            this.lblimg2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.pnlInicio = new System.Windows.Forms.Panel();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.pnlJuego.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPiedra
            // 
            this.btnPiedra.Image = ((System.Drawing.Image)(resources.GetObject("btnPiedra.Image")));
            this.btnPiedra.Location = new System.Drawing.Point(16, 22);
            this.btnPiedra.Name = "btnPiedra";
            this.btnPiedra.Size = new System.Drawing.Size(80, 90);
            this.btnPiedra.TabIndex = 0;
            this.btnPiedra.UseVisualStyleBackColor = true;
            this.btnPiedra.Click += new System.EventHandler(this.btnPiedra_Click);
            // 
            // btnPapel
            // 
            this.btnPapel.Image = ((System.Drawing.Image)(resources.GetObject("btnPapel.Image")));
            this.btnPapel.Location = new System.Drawing.Point(16, 118);
            this.btnPapel.Name = "btnPapel";
            this.btnPapel.Size = new System.Drawing.Size(80, 90);
            this.btnPapel.TabIndex = 1;
            this.btnPapel.UseVisualStyleBackColor = true;
            this.btnPapel.Click += new System.EventHandler(this.btnPapel_Click);
            // 
            // btnTijera
            // 
            this.btnTijera.Image = ((System.Drawing.Image)(resources.GetObject("btnTijera.Image")));
            this.btnTijera.Location = new System.Drawing.Point(16, 213);
            this.btnTijera.Name = "btnTijera";
            this.btnTijera.Size = new System.Drawing.Size(80, 90);
            this.btnTijera.TabIndex = 2;
            this.btnTijera.UseVisualStyleBackColor = true;
            this.btnTijera.Click += new System.EventHandler(this.btnTijera_Click);
            // 
            // lblPiedra
            // 
            this.lblPiedra.Image = ((System.Drawing.Image)(resources.GetObject("lblPiedra.Image")));
            this.lblPiedra.Location = new System.Drawing.Point(459, 22);
            this.lblPiedra.Name = "lblPiedra";
            this.lblPiedra.Size = new System.Drawing.Size(80, 90);
            this.lblPiedra.TabIndex = 3;
            // 
            // lblPapel
            // 
            this.lblPapel.Image = ((System.Drawing.Image)(resources.GetObject("lblPapel.Image")));
            this.lblPapel.Location = new System.Drawing.Point(459, 112);
            this.lblPapel.Name = "lblPapel";
            this.lblPapel.Size = new System.Drawing.Size(80, 90);
            this.lblPapel.TabIndex = 4;
            // 
            // lblTijera
            // 
            this.lblTijera.Image = ((System.Drawing.Image)(resources.GetObject("lblTijera.Image")));
            this.lblTijera.Location = new System.Drawing.Point(459, 213);
            this.lblTijera.Name = "lblTijera";
            this.lblTijera.Size = new System.Drawing.Size(80, 90);
            this.lblTijera.TabIndex = 5;
            // 
            // lblimg1
            // 
            this.lblimg1.Image = ((System.Drawing.Image)(resources.GetObject("lblimg1.Image")));
            this.lblimg1.Location = new System.Drawing.Point(152, 51);
            this.lblimg1.Name = "lblimg1";
            this.lblimg1.Size = new System.Drawing.Size(80, 90);
            this.lblimg1.TabIndex = 6;
            this.lblimg1.Visible = false;
            // 
            // lblM1
            // 
            this.lblM1.Image = ((System.Drawing.Image)(resources.GetObject("lblM1.Image")));
            this.lblM1.Location = new System.Drawing.Point(319, 51);
            this.lblM1.Name = "lblM1";
            this.lblM1.Size = new System.Drawing.Size(80, 90);
            this.lblM1.TabIndex = 7;
            this.lblM1.Visible = false;
            // 
            // lblPuntajeU
            // 
            this.lblPuntajeU.AutoSize = true;
            this.lblPuntajeU.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntajeU.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblPuntajeU.Location = new System.Drawing.Point(183, 195);
            this.lblPuntajeU.Name = "lblPuntajeU";
            this.lblPuntajeU.Size = new System.Drawing.Size(30, 31);
            this.lblPuntajeU.TabIndex = 8;
            this.lblPuntajeU.Text = "0";
            // 
            // lblPuntajeM
            // 
            this.lblPuntajeM.AutoSize = true;
            this.lblPuntajeM.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntajeM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblPuntajeM.Location = new System.Drawing.Point(357, 195);
            this.lblPuntajeM.Name = "lblPuntajeM";
            this.lblPuntajeM.Size = new System.Drawing.Size(30, 31);
            this.lblPuntajeM.TabIndex = 9;
            this.lblPuntajeM.Text = "0";
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.ForeColor = System.Drawing.Color.Green;
            this.lblMensaje.Location = new System.Drawing.Point(185, 244);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(197, 24);
            this.lblMensaje.TabIndex = 10;
            this.lblMensaje.Text = "¡Que gane el mejor!";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Teal;
            this.btnAgregar.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(49, 12);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(152, 31);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "Agregar Nombre";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNombre.Location = new System.Drawing.Point(210, 20);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(120, 22);
            this.txtNombre.TabIndex = 13;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // pnlJuego
            // 
            this.pnlJuego.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlJuego.Controls.Add(this.lblInicioM);
            this.pnlJuego.Controls.Add(this.lblInicioU);
            this.pnlJuego.Controls.Add(this.button1);
            this.pnlJuego.Controls.Add(this.label4);
            this.pnlJuego.Controls.Add(this.label3);
            this.pnlJuego.Controls.Add(this.lblM3);
            this.pnlJuego.Controls.Add(this.lblM2);
            this.pnlJuego.Controls.Add(this.lblimg3);
            this.pnlJuego.Controls.Add(this.lblimg2);
            this.pnlJuego.Controls.Add(this.label1);
            this.pnlJuego.Controls.Add(this.label2);
            this.pnlJuego.Controls.Add(this.lblNombre);
            this.pnlJuego.Controls.Add(this.btnPiedra);
            this.pnlJuego.Controls.Add(this.btnPapel);
            this.pnlJuego.Controls.Add(this.btnTijera);
            this.pnlJuego.Controls.Add(this.lblTijera);
            this.pnlJuego.Controls.Add(this.lblMensaje);
            this.pnlJuego.Controls.Add(this.lblPapel);
            this.pnlJuego.Controls.Add(this.lblM1);
            this.pnlJuego.Controls.Add(this.lblPiedra);
            this.pnlJuego.Controls.Add(this.lblPuntajeM);
            this.pnlJuego.Controls.Add(this.lblimg1);
            this.pnlJuego.Controls.Add(this.lblPuntajeU);
            this.pnlJuego.Location = new System.Drawing.Point(26, 56);
            this.pnlJuego.Name = "pnlJuego";
            this.pnlJuego.Size = new System.Drawing.Size(551, 308);
            this.pnlJuego.TabIndex = 14;
            this.pnlJuego.Visible = false;
            // 
            // lblInicioM
            // 
            this.lblInicioM.Image = ((System.Drawing.Image)(resources.GetObject("lblInicioM.Image")));
            this.lblInicioM.Location = new System.Drawing.Point(322, 51);
            this.lblInicioM.Name = "lblInicioM";
            this.lblInicioM.Size = new System.Drawing.Size(80, 90);
            this.lblInicioM.TabIndex = 22;
            this.lblInicioM.Visible = false;
            // 
            // lblInicioU
            // 
            this.lblInicioU.Image = ((System.Drawing.Image)(resources.GetObject("lblInicioU.Image")));
            this.lblInicioU.Location = new System.Drawing.Point(155, 51);
            this.lblInicioU.Name = "lblInicioU";
            this.lblInicioU.Size = new System.Drawing.Size(80, 90);
            this.lblInicioU.TabIndex = 21;
            this.lblInicioU.Visible = false;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(403, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 20;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(336, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Puntaje";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(169, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Puntaje";
            // 
            // lblM3
            // 
            this.lblM3.Image = ((System.Drawing.Image)(resources.GetObject("lblM3.Image")));
            this.lblM3.Location = new System.Drawing.Point(319, 51);
            this.lblM3.Name = "lblM3";
            this.lblM3.Size = new System.Drawing.Size(80, 90);
            this.lblM3.TabIndex = 17;
            this.lblM3.Visible = false;
            // 
            // lblM2
            // 
            this.lblM2.Image = ((System.Drawing.Image)(resources.GetObject("lblM2.Image")));
            this.lblM2.Location = new System.Drawing.Point(319, 51);
            this.lblM2.Name = "lblM2";
            this.lblM2.Size = new System.Drawing.Size(80, 90);
            this.lblM2.TabIndex = 16;
            this.lblM2.Visible = false;
            // 
            // lblimg3
            // 
            this.lblimg3.Image = ((System.Drawing.Image)(resources.GetObject("lblimg3.Image")));
            this.lblimg3.Location = new System.Drawing.Point(152, 51);
            this.lblimg3.Name = "lblimg3";
            this.lblimg3.Size = new System.Drawing.Size(80, 90);
            this.lblimg3.TabIndex = 15;
            this.lblimg3.Visible = false;
            // 
            // lblimg2
            // 
            this.lblimg2.Image = ((System.Drawing.Image)(resources.GetObject("lblimg2.Image")));
            this.lblimg2.Location = new System.Drawing.Point(152, 51);
            this.lblimg2.Name = "lblimg2";
            this.lblimg2.Size = new System.Drawing.Size(80, 90);
            this.lblimg2.TabIndex = 14;
            this.lblimg2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(269, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "VS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(336, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Maquina";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.Teal;
            this.lblNombre.Location = new System.Drawing.Point(161, 22);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(71, 20);
            this.lblNombre.TabIndex = 11;
            this.lblNombre.Text = "Usuario";
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Teal;
            this.btnPlay.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.ForeColor = System.Drawing.Color.White;
            this.btnPlay.Location = new System.Drawing.Point(336, 12);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(78, 34);
            this.btnPlay.TabIndex = 15;
            this.btnPlay.Text = "Jugar";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // pnlInicio
            // 
            this.pnlInicio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlInicio.BackgroundImage")));
            this.pnlInicio.Location = new System.Drawing.Point(43, 52);
            this.pnlInicio.Name = "pnlInicio";
            this.pnlInicio.Size = new System.Drawing.Size(500, 250);
            this.pnlInicio.TabIndex = 23;
            this.pnlInicio.Visible = false;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.Teal;
            this.btnNuevo.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Location = new System.Drawing.Point(420, 12);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(126, 34);
            this.btnNuevo.TabIndex = 24;
            this.btnNuevo.Text = "Nuevo Jugador";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 373);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.pnlInicio);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.pnlJuego);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnAgregar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "PiedraPapelTijera";
            this.pnlJuego.ResumeLayout(false);
            this.pnlJuego.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPiedra;
        private System.Windows.Forms.Button btnPapel;
        private System.Windows.Forms.Button btnTijera;
        private System.Windows.Forms.Label lblPiedra;
        private System.Windows.Forms.Label lblPapel;
        private System.Windows.Forms.Label lblTijera;
        private System.Windows.Forms.Label lblimg1;
        private System.Windows.Forms.Label lblM1;
        private System.Windows.Forms.Label lblPuntajeU;
        private System.Windows.Forms.Label lblPuntajeM;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Panel pnlJuego;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblimg2;
        private System.Windows.Forms.Label lblimg3;
        private System.Windows.Forms.Label lblM3;
        private System.Windows.Forms.Label lblM2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblInicioM;
        private System.Windows.Forms.Label lblInicioU;
        private System.Windows.Forms.Panel pnlInicio;
        private System.Windows.Forms.Button btnNuevo;
    }
}

