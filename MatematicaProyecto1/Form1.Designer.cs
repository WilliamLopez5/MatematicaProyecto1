namespace MatematicaProyecto1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txtCodificar = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btnCodificarAvanzado = new Button();
            label3 = new Label();
            btnCodificar = new Button();
            txtCodificarOutput = new RichTextBox();
            txtCodificado = new RichTextBox();
            tabPage2 = new TabPage();
            cmdDecodificarAvanzado = new Button();
            label4 = new Label();
            cmdDecodificar = new Button();
            txtDecodificarOutput = new RichTextBox();
            txtDecodificado = new RichTextBox();
            txtDecodificar = new RichTextBox();
            label5 = new Label();
            label6 = new Label();
            tabPage3 = new TabPage();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            cmdGuardarMatriz = new Button();
            label7 = new Label();
            txtMatrizOutput = new RichTextBox();
            txtMatriz = new RichTextBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // txtCodificar
            // 
            txtCodificar.Location = new Point(21, 58);
            txtCodificar.Name = "txtCodificar";
            txtCodificar.Size = new Size(600, 400);
            txtCodificar.TabIndex = 0;
            txtCodificar.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 40);
            label1.Name = "label1";
            label1.Size = new Size(95, 15);
            label1.TabIndex = 2;
            label1.Text = "Texto a Codificar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(694, 40);
            label2.Name = "label2";
            label2.Size = new Size(96, 15);
            label2.TabIndex = 3;
            label2.Text = "Texto Codificado";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1326, 642);
            tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = SystemColors.GradientInactiveCaption;
            tabPage1.Controls.Add(btnCodificarAvanzado);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(btnCodificar);
            tabPage1.Controls.Add(txtCodificarOutput);
            tabPage1.Controls.Add(txtCodificado);
            tabPage1.Controls.Add(txtCodificar);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1318, 614);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Codificar";
            // 
            // btnCodificarAvanzado
            // 
            btnCodificarAvanzado.BackColor = SystemColors.ActiveCaptionText;
            btnCodificarAvanzado.BackgroundImage = Properties.Resources.Play4;
            btnCodificarAvanzado.BackgroundImageLayout = ImageLayout.Stretch;
            btnCodificarAvanzado.FlatAppearance.BorderColor = Color.Black;
            btnCodificarAvanzado.Location = new Point(636, 274);
            btnCodificarAvanzado.Margin = new Padding(0);
            btnCodificarAvanzado.Name = "btnCodificarAvanzado";
            btnCodificarAvanzado.Size = new Size(46, 33);
            btnCodificarAvanzado.TabIndex = 8;
            btnCodificarAvanzado.UseVisualStyleBackColor = false;
            btnCodificarAvanzado.Click += btnCodificarAvanzado_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 461);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 7;
            label3.Text = "Output";
            // 
            // btnCodificar
            // 
            btnCodificar.BackColor = SystemColors.ActiveCaptionText;
            btnCodificar.BackgroundImage = Properties.Resources.Play3;
            btnCodificar.BackgroundImageLayout = ImageLayout.Stretch;
            btnCodificar.FlatAppearance.BorderColor = Color.Black;
            btnCodificar.Location = new Point(636, 218);
            btnCodificar.Margin = new Padding(0);
            btnCodificar.Name = "btnCodificar";
            btnCodificar.Size = new Size(46, 33);
            btnCodificar.TabIndex = 6;
            btnCodificar.UseVisualStyleBackColor = false;
            btnCodificar.Click += btnCodificar_Click;
            // 
            // txtCodificarOutput
            // 
            txtCodificarOutput.BackColor = Color.Black;
            txtCodificarOutput.ForeColor = Color.Orange;
            txtCodificarOutput.Location = new Point(21, 479);
            txtCodificarOutput.Name = "txtCodificarOutput";
            txtCodificarOutput.Size = new Size(1273, 126);
            txtCodificarOutput.TabIndex = 5;
            txtCodificarOutput.Text = "";
            // 
            // txtCodificado
            // 
            txtCodificado.Location = new Point(694, 58);
            txtCodificado.Name = "txtCodificado";
            txtCodificado.Size = new Size(600, 400);
            txtCodificado.TabIndex = 4;
            txtCodificado.Text = "";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = SystemColors.GradientInactiveCaption;
            tabPage2.Controls.Add(cmdDecodificarAvanzado);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(cmdDecodificar);
            tabPage2.Controls.Add(txtDecodificarOutput);
            tabPage2.Controls.Add(txtDecodificado);
            tabPage2.Controls.Add(txtDecodificar);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label6);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1318, 614);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Decodificar";
            // 
            // cmdDecodificarAvanzado
            // 
            cmdDecodificarAvanzado.BackColor = SystemColors.ActiveCaptionText;
            cmdDecodificarAvanzado.BackgroundImage = Properties.Resources.Play4;
            cmdDecodificarAvanzado.BackgroundImageLayout = ImageLayout.Stretch;
            cmdDecodificarAvanzado.FlatAppearance.BorderColor = Color.Black;
            cmdDecodificarAvanzado.Location = new Point(636, 260);
            cmdDecodificarAvanzado.Margin = new Padding(0);
            cmdDecodificarAvanzado.Name = "cmdDecodificarAvanzado";
            cmdDecodificarAvanzado.Size = new Size(46, 33);
            cmdDecodificarAvanzado.TabIndex = 15;
            cmdDecodificarAvanzado.UseVisualStyleBackColor = false;
            cmdDecodificarAvanzado.Click += cmdDecodificarAvanzado_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 446);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 14;
            label4.Text = "Output";
            // 
            // cmdDecodificar
            // 
            cmdDecodificar.BackColor = SystemColors.ActiveCaptionText;
            cmdDecodificar.BackgroundImage = Properties.Resources.Play3;
            cmdDecodificar.BackgroundImageLayout = ImageLayout.Stretch;
            cmdDecodificar.FlatAppearance.BorderColor = Color.Black;
            cmdDecodificar.Location = new Point(636, 199);
            cmdDecodificar.Margin = new Padding(0);
            cmdDecodificar.Name = "cmdDecodificar";
            cmdDecodificar.Size = new Size(46, 33);
            cmdDecodificar.TabIndex = 13;
            cmdDecodificar.UseVisualStyleBackColor = false;
            cmdDecodificar.Click += cmdDecodificar_Click;
            // 
            // txtDecodificarOutput
            // 
            txtDecodificarOutput.BackColor = Color.Black;
            txtDecodificarOutput.ForeColor = Color.Orange;
            txtDecodificarOutput.Location = new Point(23, 464);
            txtDecodificarOutput.Name = "txtDecodificarOutput";
            txtDecodificarOutput.Size = new Size(1273, 126);
            txtDecodificarOutput.TabIndex = 12;
            txtDecodificarOutput.Text = "";
            // 
            // txtDecodificado
            // 
            txtDecodificado.Location = new Point(696, 43);
            txtDecodificado.Name = "txtDecodificado";
            txtDecodificado.Size = new Size(600, 400);
            txtDecodificado.TabIndex = 11;
            txtDecodificado.Text = "";
            // 
            // txtDecodificar
            // 
            txtDecodificar.Location = new Point(23, 43);
            txtDecodificar.Name = "txtDecodificar";
            txtDecodificar.Size = new Size(600, 400);
            txtDecodificar.TabIndex = 8;
            txtDecodificar.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(696, 25);
            label5.Name = "label5";
            label5.Size = new Size(108, 15);
            label5.TabIndex = 10;
            label5.Text = "Texto Decodificado";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 25);
            label6.Name = "label6";
            label6.Size = new Size(107, 15);
            label6.TabIndex = 9;
            label6.Text = "Texto a Decodificar";
            // 
            // tabPage3
            // 
            tabPage3.BackColor = SystemColors.ControlLight;
            tabPage3.Controls.Add(label11);
            tabPage3.Controls.Add(label10);
            tabPage3.Controls.Add(label9);
            tabPage3.Controls.Add(label8);
            tabPage3.Controls.Add(cmdGuardarMatriz);
            tabPage3.Controls.Add(label7);
            tabPage3.Controls.Add(txtMatrizOutput);
            tabPage3.Controls.Add(txtMatriz);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1318, 614);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Configuración";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label11.Location = new Point(864, 35);
            label11.Name = "label11";
            label11.Size = new Size(228, 15);
            label11.TabIndex = 14;
            label11.Text = "Caracteristicas de la matriz a configurar:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(540, 19);
            label10.Name = "label10";
            label10.Size = new Size(228, 15);
            label10.TabIndex = 13;
            label10.Text = "Matriz a configurar para codificar el Texto:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(794, 70);
            label9.Name = "label9";
            label9.Size = new Size(0, 15);
            label9.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(860, 56);
            label8.Name = "label8";
            label8.Size = new Size(359, 195);
            label8.TabIndex = 11;
            label8.Text = resources.GetString("label8.Text");
            // 
            // cmdGuardarMatriz
            // 
            cmdGuardarMatriz.Location = new Point(612, 363);
            cmdGuardarMatriz.Name = "cmdGuardarMatriz";
            cmdGuardarMatriz.Size = new Size(75, 23);
            cmdGuardarMatriz.TabIndex = 10;
            cmdGuardarMatriz.Text = "Guardar";
            cmdGuardarMatriz.UseVisualStyleBackColor = true;
            cmdGuardarMatriz.Click += cmdGuardarMatriz_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(23, 462);
            label7.Name = "label7";
            label7.Size = new Size(45, 15);
            label7.TabIndex = 9;
            label7.Text = "Output";
            // 
            // txtMatrizOutput
            // 
            txtMatrizOutput.BackColor = Color.Black;
            txtMatrizOutput.ForeColor = Color.Orange;
            txtMatrizOutput.Location = new Point(23, 480);
            txtMatrizOutput.Name = "txtMatrizOutput";
            txtMatrizOutput.Size = new Size(1273, 126);
            txtMatrizOutput.TabIndex = 8;
            txtMatrizOutput.Text = "";
            // 
            // txtMatriz
            // 
            txtMatriz.Location = new Point(430, 37);
            txtMatriz.Name = "txtMatriz";
            txtMatriz.Size = new Size(424, 320);
            txtMatriz.TabIndex = 0;
            txtMatriz.Text = "2,7,3\n2,3,2\n3,1,2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1350, 654);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox txtCodificar;
        private Label label1;
        private Label label2;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private RichTextBox txtCodificado;
        private TabPage tabPage3;
        private RichTextBox txtCodificarOutput;
        private Button btnCodificar;
        private Label label3;
        private Label label4;
        private Button cmdDecodificar;
        private RichTextBox txtDecodificarOutput;
        private RichTextBox txtDecodificado;
        private RichTextBox txtDecodificar;
        private Label label5;
        private Label label6;
        private Button btnCodificarAvanzado;
        private Button cmdDecodificarAvanzado;
        private Label label8;
        private Button cmdGuardarMatriz;
        private Label label7;
        private RichTextBox txtMatrizOutput;
        private RichTextBox txtMatriz;
        private Label label10;
        private Label label9;
        private Label label11;
    }
}
