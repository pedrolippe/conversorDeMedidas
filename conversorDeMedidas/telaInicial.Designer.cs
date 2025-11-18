namespace conversorDeMedidas
{
    partial class telaInicial
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
            label1 = new Label();
            cbConversao = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            lblResultado = new Label();
            btnConverter = new Button();
            tbValor = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ControlDarkDark;
            label1.Font = new Font("Segoe UI Semilight", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(-2, 0);
            label1.Name = "label1";
            label1.Size = new Size(515, 82);
            label1.TabIndex = 0;
            label1.Text = "Conversor de Medidas";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cbConversao
            // 
            cbConversao.Cursor = Cursors.Hand;
            cbConversao.Font = new Font("Segoe UI Semilight", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbConversao.FormattingEnabled = true;
            cbConversao.Items.AddRange(new object[] { "Quilômetros para Milhas", "Quilômetros para Metros", "Quilômetros para Centímetros", "Milhas para Quilômetros", "Milhas para Metros", "Milhas para Centímetros", "Celsius para Fahrenheit", "Fahrenheit para Celsius", "Km/h para M/s" });
            cbConversao.Location = new Point(12, 141);
            cbConversao.Name = "cbConversao";
            cbConversao.Size = new Size(487, 45);
            cbConversao.TabIndex = 1;
            cbConversao.SelectedIndexChanged += cbConversao_SelectedIndexChanged;
            cbConversao.Click += cbConversao_Click;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semilight", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 101);
            label2.Name = "label2";
            label2.Size = new Size(215, 37);
            label2.TabIndex = 2;
            label2.Text = "Tipo de Conversão";
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semilight", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 215);
            label3.Name = "label3";
            label3.Size = new Size(269, 37);
            label3.TabIndex = 3;
            label3.Text = "Valor a ser Convertido";
            // 
            // label5
            // 
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Semilight", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 543);
            label5.Name = "label5";
            label5.Size = new Size(269, 37);
            label5.TabIndex = 5;
            label5.Text = "Resultado";
            // 
            // lblResultado
            // 
            lblResultado.BackColor = Color.Silver;
            lblResultado.BorderStyle = BorderStyle.FixedSingle;
            lblResultado.Location = new Point(12, 580);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(487, 68);
            lblResultado.TabIndex = 6;
            lblResultado.TextAlign = ContentAlignment.MiddleCenter;
            lblResultado.Click += lblResultado_Click;
            // 
            // btnConverter
            // 
            btnConverter.BackColor = Color.Green;
            btnConverter.Cursor = Cursors.Hand;
            btnConverter.Font = new Font("Segoe UI Semilight", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConverter.Location = new Point(230, 340);
            btnConverter.Name = "btnConverter";
            btnConverter.Size = new Size(269, 89);
            btnConverter.TabIndex = 7;
            btnConverter.Text = "Converter";
            btnConverter.UseVisualStyleBackColor = false;
            btnConverter.Click += btnConverter_Click;
            // 
            // tbValor
            // 
            tbValor.BackColor = Color.Silver;
            tbValor.Cursor = Cursors.IBeam;
            tbValor.Font = new Font("Segoe UI Semilight", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbValor.Location = new Point(12, 255);
            tbValor.Name = "tbValor";
            tbValor.Size = new Size(487, 43);
            tbValor.TabIndex = 8;
            tbValor.TextAlign = HorizontalAlignment.Center;
            tbValor.TextChanged += tbValor_TextChanged;
            tbValor.KeyDown += tbValor_KeyDown;
            // 
            // telaInicial
            // 
            AutoScaleDimensions = new SizeF(22F, 54F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(511, 657);
            Controls.Add(tbValor);
            Controls.Add(btnConverter);
            Controls.Add(lblResultado);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cbConversao);
            Controls.Add(label1);
            Font = new Font("Segoe UI Semilight", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(8);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "telaInicial";
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Conversor de Medidas";
            Load += telaInicial_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cbConversao;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label lblResultado;
        private Button btnConverter;
        private TextBox tbValor;
    }
}
