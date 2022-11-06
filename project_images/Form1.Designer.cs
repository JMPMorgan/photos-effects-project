namespace project_images
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_CargarImg = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_Grises = new System.Windows.Forms.Button();
            this.btn_Invertido = new System.Windows.Forms.Button();
            this.btn_Rojo = new System.Windows.Forms.Button();
            this.btn_Brillo = new System.Windows.Forms.Button();
            this.btn_Binario = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.btn_GuardarImg = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.btn_GuardarImagenNoEffect = new System.Windows.Forms.Button();
            this.btn_CargarVideo = new System.Windows.Forms.Button();
            this.counterPerson_lbl = new System.Windows.Forms.Label();
            this.histogramBox1 = new Emgu.CV.UI.HistogramBox();
            this.histogramBox2 = new Emgu.CV.UI.HistogramBox();
            this.histogramBox3 = new Emgu.CV.UI.HistogramBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.histogramBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.histogramBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.histogramBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_CargarImg
            // 
            this.btn_CargarImg.BackColor = System.Drawing.Color.Gray;
            this.btn_CargarImg.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_CargarImg.FlatAppearance.BorderSize = 2;
            this.btn_CargarImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CargarImg.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_CargarImg.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_CargarImg.Location = new System.Drawing.Point(12, 12);
            this.btn_CargarImg.Name = "btn_CargarImg";
            this.btn_CargarImg.Size = new System.Drawing.Size(138, 36);
            this.btn_CargarImg.TabIndex = 0;
            this.btn_CargarImg.Text = "Cargar Imagen";
            this.btn_CargarImg.UseVisualStyleBackColor = false;
            this.btn_CargarImg.Click += new System.EventHandler(this.btn_CargarImg_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(222, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(584, 527);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(840, 73);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(584, 527);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // btn_Grises
            // 
            this.btn_Grises.BackColor = System.Drawing.Color.Gray;
            this.btn_Grises.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Grises.FlatAppearance.BorderSize = 2;
            this.btn_Grises.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Grises.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Grises.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Grises.Location = new System.Drawing.Point(12, 166);
            this.btn_Grises.Name = "btn_Grises";
            this.btn_Grises.Size = new System.Drawing.Size(138, 36);
            this.btn_Grises.TabIndex = 14;
            this.btn_Grises.Text = "Efecto 1";
            this.btn_Grises.UseVisualStyleBackColor = false;
            this.btn_Grises.Click += new System.EventHandler(this.btn_Grises_Click);
            // 
            // btn_Invertido
            // 
            this.btn_Invertido.BackColor = System.Drawing.Color.Gray;
            this.btn_Invertido.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Invertido.FlatAppearance.BorderSize = 2;
            this.btn_Invertido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Invertido.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Invertido.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Invertido.Location = new System.Drawing.Point(12, 219);
            this.btn_Invertido.Name = "btn_Invertido";
            this.btn_Invertido.Size = new System.Drawing.Size(138, 36);
            this.btn_Invertido.TabIndex = 15;
            this.btn_Invertido.Text = "Efecto 2";
            this.btn_Invertido.UseVisualStyleBackColor = false;
            this.btn_Invertido.Click += new System.EventHandler(this.btn_Invertido_Click);
            // 
            // btn_Rojo
            // 
            this.btn_Rojo.BackColor = System.Drawing.Color.Gray;
            this.btn_Rojo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Rojo.FlatAppearance.BorderSize = 2;
            this.btn_Rojo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Rojo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Rojo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Rojo.Location = new System.Drawing.Point(12, 273);
            this.btn_Rojo.Name = "btn_Rojo";
            this.btn_Rojo.Size = new System.Drawing.Size(138, 36);
            this.btn_Rojo.TabIndex = 16;
            this.btn_Rojo.Text = "Efecto 3";
            this.btn_Rojo.UseVisualStyleBackColor = false;
            this.btn_Rojo.Click += new System.EventHandler(this.btn_Rojo_Click);
            // 
            // btn_Brillo
            // 
            this.btn_Brillo.BackColor = System.Drawing.Color.Gray;
            this.btn_Brillo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Brillo.FlatAppearance.BorderSize = 2;
            this.btn_Brillo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Brillo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Brillo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Brillo.Location = new System.Drawing.Point(12, 324);
            this.btn_Brillo.Name = "btn_Brillo";
            this.btn_Brillo.Size = new System.Drawing.Size(138, 36);
            this.btn_Brillo.TabIndex = 17;
            this.btn_Brillo.Text = "Efecto 4";
            this.btn_Brillo.UseVisualStyleBackColor = false;
            this.btn_Brillo.Click += new System.EventHandler(this.btn_Brillo_Click);
            // 
            // btn_Binario
            // 
            this.btn_Binario.BackColor = System.Drawing.Color.Gray;
            this.btn_Binario.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Binario.FlatAppearance.BorderSize = 2;
            this.btn_Binario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Binario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Binario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Binario.Location = new System.Drawing.Point(12, 376);
            this.btn_Binario.Name = "btn_Binario";
            this.btn_Binario.Size = new System.Drawing.Size(138, 36);
            this.btn_Binario.TabIndex = 18;
            this.btn_Binario.Text = "Efecto 5";
            this.btn_Binario.UseVisualStyleBackColor = false;
            this.btn_Binario.Click += new System.EventHandler(this.btn_Binario_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Gray;
            this.button10.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button10.FlatAppearance.BorderSize = 2;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button10.Location = new System.Drawing.Point(12, 594);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(138, 36);
            this.button10.TabIndex = 19;
            this.button10.Text = "Salir";
            this.button10.UseVisualStyleBackColor = false;
            // 
            // btn_GuardarImg
            // 
            this.btn_GuardarImg.BackColor = System.Drawing.Color.Gray;
            this.btn_GuardarImg.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_GuardarImg.FlatAppearance.BorderSize = 2;
            this.btn_GuardarImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GuardarImg.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_GuardarImg.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_GuardarImg.Location = new System.Drawing.Point(1286, 12);
            this.btn_GuardarImg.Name = "btn_GuardarImg";
            this.btn_GuardarImg.Size = new System.Drawing.Size(138, 36);
            this.btn_GuardarImg.TabIndex = 20;
            this.btn_GuardarImg.Text = "Guardar Imagen";
            this.btn_GuardarImg.UseVisualStyleBackColor = false;
            this.btn_GuardarImg.Click += new System.EventHandler(this.btn_GuardarImg_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Gray;
            this.button8.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button8.FlatAppearance.BorderSize = 2;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button8.Location = new System.Drawing.Point(1556, 594);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(138, 36);
            this.button8.TabIndex = 21;
            this.button8.Text = "Manual";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // btn_GuardarImagenNoEffect
            // 
            this.btn_GuardarImagenNoEffect.BackColor = System.Drawing.Color.Gray;
            this.btn_GuardarImagenNoEffect.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_GuardarImagenNoEffect.FlatAppearance.BorderSize = 2;
            this.btn_GuardarImagenNoEffect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GuardarImagenNoEffect.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_GuardarImagenNoEffect.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_GuardarImagenNoEffect.Location = new System.Drawing.Point(222, 12);
            this.btn_GuardarImagenNoEffect.Name = "btn_GuardarImagenNoEffect";
            this.btn_GuardarImagenNoEffect.Size = new System.Drawing.Size(225, 36);
            this.btn_GuardarImagenNoEffect.TabIndex = 22;
            this.btn_GuardarImagenNoEffect.Text = "Guardar Imagen Sin Efecto";
            this.btn_GuardarImagenNoEffect.UseVisualStyleBackColor = false;
            this.btn_GuardarImagenNoEffect.Click += new System.EventHandler(this.btn_GuardarImagenNoEffect_Click);
            // 
            // btn_CargarVideo
            // 
            this.btn_CargarVideo.BackColor = System.Drawing.Color.Gray;
            this.btn_CargarVideo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_CargarVideo.FlatAppearance.BorderSize = 2;
            this.btn_CargarVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CargarVideo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_CargarVideo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_CargarVideo.Location = new System.Drawing.Point(12, 54);
            this.btn_CargarVideo.Name = "btn_CargarVideo";
            this.btn_CargarVideo.Size = new System.Drawing.Size(138, 36);
            this.btn_CargarVideo.TabIndex = 23;
            this.btn_CargarVideo.Text = "Cargar Video";
            this.btn_CargarVideo.UseVisualStyleBackColor = false;
            this.btn_CargarVideo.Click += new System.EventHandler(this.btn_CargarVideo_Click);
            // 
            // counterPerson_lbl
            // 
            this.counterPerson_lbl.AutoSize = true;
            this.counterPerson_lbl.Location = new System.Drawing.Point(222, 605);
            this.counterPerson_lbl.Name = "counterPerson_lbl";
            this.counterPerson_lbl.Size = new System.Drawing.Size(38, 15);
            this.counterPerson_lbl.TabIndex = 24;
            this.counterPerson_lbl.Text = "label1";
            // 
            // histogramBox1
            // 
            this.histogramBox1.Location = new System.Drawing.Point(1452, 73);
            this.histogramBox1.Name = "histogramBox1";
            this.histogramBox1.Size = new System.Drawing.Size(242, 160);
            this.histogramBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.histogramBox1.TabIndex = 2;
            this.histogramBox1.TabStop = false;
            // 
            // histogramBox2
            // 
            this.histogramBox2.Location = new System.Drawing.Point(1452, 239);
            this.histogramBox2.Name = "histogramBox2";
            this.histogramBox2.Size = new System.Drawing.Size(242, 157);
            this.histogramBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.histogramBox2.TabIndex = 25;
            this.histogramBox2.TabStop = false;
            // 
            // histogramBox3
            // 
            this.histogramBox3.Location = new System.Drawing.Point(1452, 412);
            this.histogramBox3.Name = "histogramBox3";
            this.histogramBox3.Size = new System.Drawing.Size(242, 157);
            this.histogramBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.histogramBox3.TabIndex = 26;
            this.histogramBox3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1706, 652);
            this.Controls.Add(this.histogramBox3);
            this.Controls.Add(this.histogramBox2);
            this.Controls.Add(this.histogramBox1);
            this.Controls.Add(this.counterPerson_lbl);
            this.Controls.Add(this.btn_CargarVideo);
            this.Controls.Add(this.btn_GuardarImagenNoEffect);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.btn_GuardarImg);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.btn_Binario);
            this.Controls.Add(this.btn_Brillo);
            this.Controls.Add(this.btn_Rojo);
            this.Controls.Add(this.btn_Invertido);
            this.Controls.Add(this.btn_Grises);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_CargarImg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.histogramBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.histogramBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.histogramBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_CargarImg;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button btn_Grises;
        private Button btn_Invertido;
        private Button btn_Rojo;
        private Button btn_Brillo;
        private Button btn_Binario;
        private Button button10;
        private Button btn_GuardarImg;
        private Button button8;
        private Button btn_GuardarImagenNoEffect;
        private Button btn_CargarVideo;
        private Label counterPerson_lbl;
        private Emgu.CV.UI.HistogramBox histogramBox1;
        private Emgu.CV.UI.HistogramBox histogramBox2;
        private Emgu.CV.UI.HistogramBox histogramBox3;
    }
}