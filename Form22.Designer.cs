namespace PROYECTO_FINAL_FÍSICA
{
    partial class Form22
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form22));
            btsalir = new Button();
            comElegir1 = new ComboBox();
            btatras = new Button();
            btlimpiar = new Button();
            btcalcular = new Button();
            txt4 = new TextBox();
            lbl4 = new Label();
            txt3 = new TextBox();
            txt2 = new TextBox();
            txt1 = new TextBox();
            lbl3 = new Label();
            lbl2 = new Label();
            lbl1 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // btsalir
            // 
            btsalir.BackgroundImage = Properties.Resources.PDFproyectoBotones6;
            btsalir.FlatStyle = FlatStyle.Flat;
            btsalir.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btsalir.ForeColor = SystemColors.ButtonHighlight;
            btsalir.Location = new Point(543, 396);
            btsalir.Name = "btsalir";
            btsalir.Size = new Size(129, 30);
            btsalir.TabIndex = 21;
            btsalir.Text = "Salir";
            btsalir.UseVisualStyleBackColor = true;
            btsalir.Click += btsalir_Click;
            // 
            // comElegir1
            // 
            comElegir1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            comElegir1.FormattingEnabled = true;
            comElegir1.Items.AddRange(new object[] { "Altura km", "Velocidad Inicial km/h", "Velocidad Final km/h", "Tiempo h", "Gravedad m/s" });
            comElegir1.Location = new Point(587, 200);
            comElegir1.Name = "comElegir1";
            comElegir1.Size = new Size(151, 31);
            comElegir1.TabIndex = 20;
            comElegir1.Text = "Caída Libre";
            comElegir1.SelectedIndexChanged += comElegir1_SelectedIndexChanged;
            // 
            // btatras
            // 
            btatras.BackColor = Color.Aqua;
            btatras.BackgroundImage = Properties.Resources.PDFproyectoBotones7;
            btatras.FlatStyle = FlatStyle.Flat;
            btatras.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btatras.ForeColor = SystemColors.ButtonHighlight;
            btatras.Location = new Point(138, 396);
            btatras.Name = "btatras";
            btatras.Size = new Size(129, 30);
            btatras.TabIndex = 19;
            btatras.Text = "Volver Atras";
            btatras.UseVisualStyleBackColor = false;
            btatras.Click += btatras_Click;
            // 
            // btlimpiar
            // 
            btlimpiar.BackColor = Color.Aqua;
            btlimpiar.BackgroundImage = Properties.Resources.PDFproyectoBotones8;
            btlimpiar.FlatStyle = FlatStyle.Flat;
            btlimpiar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btlimpiar.ForeColor = SystemColors.ButtonHighlight;
            btlimpiar.Location = new Point(408, 396);
            btlimpiar.Name = "btlimpiar";
            btlimpiar.Size = new Size(129, 30);
            btlimpiar.TabIndex = 18;
            btlimpiar.Text = "Limpiar";
            btlimpiar.UseVisualStyleBackColor = false;
            btlimpiar.Click += btlimpiar_Click;
            // 
            // btcalcular
            // 
            btcalcular.BackColor = Color.Cyan;
            btcalcular.BackgroundImage = Properties.Resources.PDFproyectoBotones9;
            btcalcular.FlatStyle = FlatStyle.Flat;
            btcalcular.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btcalcular.ForeColor = SystemColors.ButtonHighlight;
            btcalcular.Location = new Point(273, 396);
            btcalcular.Name = "btcalcular";
            btcalcular.Size = new Size(129, 30);
            btcalcular.TabIndex = 17;
            btcalcular.Text = "Calcular";
            btcalcular.UseVisualStyleBackColor = false;
            btcalcular.Click += btcalcular_Click;
            // 
            // txt4
            // 
            txt4.Location = new Point(339, 295);
            txt4.Name = "txt4";
            txt4.Size = new Size(159, 27);
            txt4.TabIndex = 29;
            // 
            // lbl4
            // 
            lbl4.AutoSize = true;
            lbl4.BackColor = Color.Transparent;
            lbl4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            lbl4.Location = new Point(81, 299);
            lbl4.Name = "lbl4";
            lbl4.Size = new Size(23, 18);
            lbl4.TabIndex = 28;
            lbl4.Text = "...";
            // 
            // txt3
            // 
            txt3.Location = new Point(339, 262);
            txt3.Name = "txt3";
            txt3.Size = new Size(159, 27);
            txt3.TabIndex = 27;
            // 
            // txt2
            // 
            txt2.Location = new Point(339, 229);
            txt2.Name = "txt2";
            txt2.Size = new Size(159, 27);
            txt2.TabIndex = 26;
            // 
            // txt1
            // 
            txt1.Location = new Point(339, 196);
            txt1.Name = "txt1";
            txt1.Size = new Size(159, 27);
            txt1.TabIndex = 25;
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.BackColor = Color.Transparent;
            lbl3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            lbl3.Location = new Point(81, 266);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(23, 18);
            lbl3.TabIndex = 24;
            lbl3.Text = "...";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.BackColor = Color.Transparent;
            lbl2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            lbl2.Location = new Point(81, 228);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(23, 18);
            lbl2.TabIndex = 23;
            lbl2.Text = "...";
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.BackColor = Color.Transparent;
            lbl1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            lbl1.Location = new Point(81, 200);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(23, 18);
            lbl1.TabIndex = 22;
            lbl1.Text = "...";
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 9);
            label4.Name = "label4";
            label4.Size = new Size(763, 113);
            label4.TabIndex = 30;
            label4.Text = resources.GetString("label4.Text");
            // 
            // Form22
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.TiroVCL5;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(txt4);
            Controls.Add(lbl4);
            Controls.Add(txt3);
            Controls.Add(txt2);
            Controls.Add(txt1);
            Controls.Add(lbl3);
            Controls.Add(lbl2);
            Controls.Add(lbl1);
            Controls.Add(btsalir);
            Controls.Add(comElegir1);
            Controls.Add(btatras);
            Controls.Add(btlimpiar);
            Controls.Add(btcalcular);
            Name = "Form22";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form22";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btsalir;
        private ComboBox comElegir1;
        private Button btatras;
        private Button btlimpiar;
        private Button btcalcular;
        private TextBox txt4;
        private Label lbl4;
        private TextBox txt3;
        private TextBox txt2;
        private TextBox txt1;
        private Label lbl3;
        private Label lbl2;
        private Label lbl1;
        private Label label4;
    }
}