
namespace CalculadoraMatrices
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
            this.Fila1 = new System.Windows.Forms.TextBox();
            this.Columna2 = new System.Windows.Forms.TextBox();
            this.Fila2 = new System.Windows.Forms.TextBox();
            this.Columna1 = new System.Windows.Forms.TextBox();
            this.Matriz1 = new System.Windows.Forms.GroupBox();
            this.Matriz2 = new System.Windows.Forms.GroupBox();
            this.BtM1 = new System.Windows.Forms.Button();
            this.Agregar = new System.Windows.Forms.Button();
            this.ResultadoM3 = new System.Windows.Forms.GroupBox();
            this.btSuma = new System.Windows.Forms.Button();
            this.btResta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btProd = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btIgual = new System.Windows.Forms.Panel();
            this.btIgua = new System.Windows.Forms.Button();
            this.txtIgual = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.btIgual.SuspendLayout();
            this.SuspendLayout();
            // 
            // Fila1
            // 
            this.Fila1.Location = new System.Drawing.Point(71, 37);
            this.Fila1.Name = "Fila1";
            this.Fila1.Size = new System.Drawing.Size(49, 20);
            this.Fila1.TabIndex = 0;
            this.Fila1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Fila1_KeyPress);
            // 
            // Columna2
            // 
            this.Columna2.Location = new System.Drawing.Point(148, 79);
            this.Columna2.Name = "Columna2";
            this.Columna2.Size = new System.Drawing.Size(49, 20);
            this.Columna2.TabIndex = 4;
            this.Columna2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Columna2_KeyPress);
            // 
            // Fila2
            // 
            this.Fila2.Location = new System.Drawing.Point(71, 79);
            this.Fila2.Name = "Fila2";
            this.Fila2.Size = new System.Drawing.Size(49, 20);
            this.Fila2.TabIndex = 3;
            this.Fila2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Fila2_KeyPress);
            // 
            // Columna1
            // 
            this.Columna1.Location = new System.Drawing.Point(148, 37);
            this.Columna1.Name = "Columna1";
            this.Columna1.Size = new System.Drawing.Size(49, 20);
            this.Columna1.TabIndex = 1;
            this.Columna1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Columna1_KeyPress);
            // 
            // Matriz1
            // 
            this.Matriz1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Matriz1.ForeColor = System.Drawing.Color.Lime;
            this.Matriz1.Location = new System.Drawing.Point(12, 18);
            this.Matriz1.Name = "Matriz1";
            this.Matriz1.Size = new System.Drawing.Size(207, 172);
            this.Matriz1.TabIndex = 6;
            this.Matriz1.TabStop = false;
            this.Matriz1.Text = "Matriz 1";
            // 
            // Matriz2
            // 
            this.Matriz2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Matriz2.ForeColor = System.Drawing.Color.Lime;
            this.Matriz2.Location = new System.Drawing.Point(273, 18);
            this.Matriz2.Name = "Matriz2";
            this.Matriz2.Size = new System.Drawing.Size(200, 172);
            this.Matriz2.TabIndex = 7;
            this.Matriz2.TabStop = false;
            this.Matriz2.Text = "Matriz 2";
            // 
            // BtM1
            // 
            this.BtM1.Location = new System.Drawing.Point(224, 35);
            this.BtM1.Name = "BtM1";
            this.BtM1.Size = new System.Drawing.Size(75, 23);
            this.BtM1.TabIndex = 2;
            this.BtM1.Text = "Agregar";
            this.BtM1.UseVisualStyleBackColor = true;
            this.BtM1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Agregar
            // 
            this.Agregar.Location = new System.Drawing.Point(224, 77);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(75, 23);
            this.Agregar.TabIndex = 5;
            this.Agregar.TabStop = false;
            this.Agregar.Text = "Agregar";
            this.Agregar.UseVisualStyleBackColor = true;
            this.Agregar.Click += new System.EventHandler(this.button2_Click);
            // 
            // ResultadoM3
            // 
            this.ResultadoM3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultadoM3.ForeColor = System.Drawing.Color.Lime;
            this.ResultadoM3.Location = new System.Drawing.Point(520, 18);
            this.ResultadoM3.Name = "ResultadoM3";
            this.ResultadoM3.Size = new System.Drawing.Size(200, 172);
            this.ResultadoM3.TabIndex = 6;
            this.ResultadoM3.TabStop = false;
            this.ResultadoM3.Text = "Resultado";
            // 
            // btSuma
            // 
            this.btSuma.Location = new System.Drawing.Point(225, 35);
            this.btSuma.Name = "btSuma";
            this.btSuma.Size = new System.Drawing.Size(42, 23);
            this.btSuma.TabIndex = 8;
            this.btSuma.Text = "+";
            this.btSuma.UseVisualStyleBackColor = true;
            this.btSuma.Click += new System.EventHandler(this.btSuma_Click);
            // 
            // btResta
            // 
            this.btResta.Location = new System.Drawing.Point(224, 93);
            this.btResta.Name = "btResta";
            this.btResta.Size = new System.Drawing.Size(42, 23);
            this.btResta.TabIndex = 9;
            this.btResta.Text = "-";
            this.btResta.UseVisualStyleBackColor = true;
            this.btResta.Click += new System.EventHandler(this.btResta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(126, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(126, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(9, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Matriz 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Lime;
            this.label4.Location = new System.Drawing.Point(9, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Matriz 2";
            // 
            // btProd
            // 
            this.btProd.Location = new System.Drawing.Point(224, 152);
            this.btProd.Name = "btProd";
            this.btProd.Size = new System.Drawing.Size(42, 23);
            this.btProd.TabIndex = 10;
            this.btProd.Text = "x";
            this.btProd.UseVisualStyleBackColor = true;
            this.btProd.Click += new System.EventHandler(this.btProd_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Fila1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Columna2);
            this.panel1.Controls.Add(this.Fila2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Columna1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BtM1);
            this.panel1.Controls.Add(this.Agregar);
            this.panel1.Location = new System.Drawing.Point(33, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(314, 116);
            this.panel1.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Lime;
            this.label7.Location = new System.Drawing.Point(145, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Columnas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Lime;
            this.label6.Location = new System.Drawing.Point(68, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Filas";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Matriz1);
            this.panel2.Controls.Add(this.Matriz2);
            this.panel2.Controls.Add(this.btProd);
            this.panel2.Controls.Add(this.ResultadoM3);
            this.panel2.Controls.Add(this.btResta);
            this.panel2.Controls.Add(this.btSuma);
            this.panel2.Location = new System.Drawing.Point(33, 147);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(737, 211);
            this.panel2.TabIndex = 16;
            // 
            // btIgual
            // 
            this.btIgual.Controls.Add(this.label8);
            this.btIgual.Controls.Add(this.btIgua);
            this.btIgual.Controls.Add(this.txtIgual);
            this.btIgual.Controls.Add(this.label5);
            this.btIgual.Location = new System.Drawing.Point(459, 12);
            this.btIgual.Name = "btIgual";
            this.btIgual.Size = new System.Drawing.Size(311, 116);
            this.btIgual.TabIndex = 17;
            // 
            // btIgua
            // 
            this.btIgua.Location = new System.Drawing.Point(169, 16);
            this.btIgua.Name = "btIgua";
            this.btIgua.Size = new System.Drawing.Size(39, 23);
            this.btIgua.TabIndex = 2;
            this.btIgua.Text = "=";
            this.btIgua.UseVisualStyleBackColor = true;
            this.btIgua.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtIgual
            // 
            this.txtIgual.Location = new System.Drawing.Point(117, 17);
            this.txtIgual.Name = "txtIgual";
            this.txtIgual.Size = new System.Drawing.Size(46, 20);
            this.txtIgual.TabIndex = 1;
            this.txtIgual.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIgual_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Lime;
            this.label5.Location = new System.Drawing.Point(23, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Multiplicar por";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Lime;
            this.label8.Location = new System.Drawing.Point(23, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Matriz Traspuesta";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btIgual);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Calculadora de matrices";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.btIgual.ResumeLayout(false);
            this.btIgual.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox Fila1;
        private System.Windows.Forms.TextBox Columna2;
        private System.Windows.Forms.TextBox Fila2;
        private System.Windows.Forms.TextBox Columna1;
        private System.Windows.Forms.GroupBox Matriz1;
        private System.Windows.Forms.GroupBox Matriz2;
        private System.Windows.Forms.Button BtM1;
        private System.Windows.Forms.Button Agregar;
        private System.Windows.Forms.GroupBox ResultadoM3;
        private System.Windows.Forms.Button btSuma;
        private System.Windows.Forms.Button btResta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btProd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel btIgual;
        private System.Windows.Forms.Button btIgua;
        private System.Windows.Forms.TextBox txtIgual;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
    }
}

