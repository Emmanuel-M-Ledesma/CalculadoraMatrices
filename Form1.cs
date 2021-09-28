using System;
using System.Windows.Forms;


namespace CalculadoraMatrices
{

    public partial class Form1 : Form
    {
        private TextBox[,] M1;
        private TextBox[,] M2;
        private TextBox[,] Resultado;
        private TextBox[,] Ma;
        private TextBox[,] Mb;
        int filasM1;
        int filasM2;
        int colM1;
        int colM2;
        double RES1, RES2, RES3;
        Calculos calculos = new Calculos();
        bool Numeros = true;


        public Form1()
        {
            InitializeComponent();
            btSuma.Enabled = false;
            btResta.Enabled = false;
            btProd.Enabled = false;
            btIgua.Enabled = false;
        }
        #region Eventos

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(Fila1.Text == "" || Columna1.Text == ""))
            {
                ConfigA();
                MatrizA();
                btSuma.Enabled = true;
                btResta.Enabled = true;
                btProd.Enabled = true;
                btIgua.Enabled = true;
            }
            else
            {
                MessageBox.Show("Debe agregar la cantidad de filas y columnas para la matriz 1", "Error");
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (!(Fila2.Text == "" || Columna2.Text == ""))
            {
                ConfigB();
                MatrizB();
                btSuma.Enabled = true;
                btResta.Enabled = true;
                btProd.Enabled = true;
            }
            else
            {
                MessageBox.Show("Debe agregar la cantidad de filas y columnas para la matriz 2", "Error");
            }

        }
        private void btSuma_Click(object sender, EventArgs e)
        {
            if (colM1 == colM2 && filasM1 == filasM2)
            {
                ResultadoM3.Controls.Clear();
                Resultado = new TextBox[filasM1, colM1];
                MatrizResultado();
                calculos.Suma(RES1, RES2, RES3, M1, M2, Resultado);
            }
            else
            {
                MessageBox.Show("Para sumar las matrices deben ser del mismo orden");
            }
        }
        private void btResta_Click(object sender, EventArgs e)
        {
            if (colM1 == colM2 && filasM1 == filasM2)
            {
                ResultadoM3.Controls.Clear();
                Resultado = new TextBox[filasM1, colM1];
                MatrizResultado();
                calculos.Resta(RES1, RES2, RES3, M1, M2, Resultado);
            }
            else
            {
                MessageBox.Show("Para restar las matrices deben ser del mismo orden");
            }

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            ResultadoM3.Controls.Clear();
            Matriz2.Controls.Clear();
            Resultado = new TextBox[filasM1, colM1];
            MatrizResultado();
            MultiplicacionEscalar();
        }
        private void btProd_Click(object sender, EventArgs e)
        {
            if (colM1 == filasM2)
            {
                ResultadoM3.Controls.Clear();
                Resultado = new TextBox[filasM1, colM2];
                ProdResultado();

                if (Numeros)
                {
                    calculos.Multiplicacion(M1, M2, Resultado);
                }
                else
                {
                    Numeros = true;
                }
            }
            else
            {
                MessageBox.Show("El número de columnas de la primera matriz debe coincidir con el número de filas de la segunda matriz.");
                Numeros = false;
            }


        }
        private void label8_Click(object sender, EventArgs e)
        {
            if (!(filasM1 == 0 || colM1 == 0))
            {
                ResultadoM3.Controls.Clear();
                Resultado = new TextBox[colM1, filasM1];
                MatrizTraspuesta();
                calculos.traspuesta(M1, Resultado);
            }
            else
            {
                MessageBox.Show("Debe tener una matriz cargada en el espacio de Matriz 1", "Error");
            }

        }

        

        #endregion

        #region EventosKeyPress

        private void txtIgual_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != ',') && (e.KeyChar != '-') && (e.KeyChar != 'e') && (e.KeyChar != '/'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '/') && ((sender as TextBox).Text.IndexOf('/') > -1))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == 'e') && ((sender as TextBox).Text.IndexOf('e') > -1))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '-') && ((sender as TextBox).Text.IndexOf('-') > -1))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }
        private void Fila1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }
        private void Columna1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }
        private void Fila2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }
        private void Columna2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        #endregion

        #region Metodos



        private void ConfigA()
        {
            filasM1 = System.Convert.ToInt32(Fila1.Text);
            colM1 = System.Convert.ToInt32(Columna1.Text);
            Matriz1.Controls.Clear();
            ResultadoM3.Controls.Clear();
            M1 = new TextBox[filasM1, colM1];
        }
        private void MatrizA()
        {
            int columna = Matriz1.Width / colM1;
            for (int F = 0; F < M1.GetLength(0); F++)
            {
                for (int C = 0; C < M1.GetLength(1); C++)
                {
                    M1[F, C] = new TextBox();
                    M1[F, C].Text = "0";
                    M1[F, C].Top = (F * M1[F, C].Height) + 20;
                    M1[F, C].Left = C * columna;
                    M1[F, C].Width = columna;
                    Matriz1.Controls.Add(M1[F, C]);
                }

            }
        }
        private void ConfigB()
        {
            filasM2 = System.Convert.ToInt32(Fila2.Text);
            colM2 = System.Convert.ToInt32(Columna2.Text);
            Matriz2.Controls.Clear();
            ResultadoM3.Controls.Clear();
            M2 = new TextBox[filasM2, colM2];
        }
        private void MatrizB()
        {
            int columna2 = Matriz2.Width / colM2;
            for (int F = 0; F < M2.GetLength(0); F++)
            {
                for (int C = 0; C < M2.GetLength(1); C++)
                {
                    M2[F, C] = new TextBox();
                    M2[F, C].Text = "0"; 
                    M2[F, C].Top = (F * M2[F, C].Height) + 20;
                    M2[F, C].Left = C * columna2;
                    M2[F, C].Width = columna2;
                    Matriz2.Controls.Add(M2[F, C]);
                }

            }
        }
        private void MatrizResultado()
        {

            int columna2 = ResultadoM3.Width / colM1;
            for (int F = 0; F < M1.GetLength(0); F++)
            {
                for (int C = 0; C < M1.GetLength(1); C++)
                {
                    Resultado[F, C] = new TextBox();
                    Resultado[F, C].Text = "0";
                    Resultado[F, C].Top = (F * Resultado[F, C].Height) + 20;
                    Resultado[F, C].Left = C * columna2;
                    Resultado[F, C].Width = columna2;
                    ResultadoM3.Controls.Add(Resultado[F, C]);
                }

            }
        }
        private void MatrizTraspuesta()
        {
            int columna2 = ResultadoM3.Width / filasM1;
            for (int F = 0; F < M1.GetLength(1); F++)
            {
                for (int C = 0; C < M1.GetLength(0); C++)
                {
                    Resultado[F, C] = new TextBox();
                    Resultado[F, C].Text = "0";
                    Resultado[F, C].Top = (F * Resultado[F, C].Height) + 20;
                    Resultado[F, C].Left = C * columna2;
                    Resultado[F, C].Width = columna2;
                    ResultadoM3.Controls.Add(Resultado[F, C]);
                }

            }
        }
        private void ProdResultado()
        {
            if (M1.GetLength(1) != M2.GetLength(0))
            {
                MessageBox.Show("El número de columnas de la primera matriz debe coincidir con el número de filas de la segunda matriz.");
                Numeros = false;
            }
            else
            {
                int columna2 = ResultadoM3.Width / colM2;
                for (int F = 0; F < filasM1; F++)
                {
                    for (int C = 0; C < colM2; C++)
                    {
                        Resultado[F, C] = new TextBox();
                        Resultado[F, C].Text = "";
                        Resultado[F, C].Top = (F * Resultado[F, C].Height) + 20;
                        Resultado[F, C].Left = C * columna2;
                        Resultado[F, C].Width = columna2;
                        ResultadoM3.Controls.Add(Resultado[F, C]);
                    }

                }
            }

        }
        private void MultiplicacionEscalar()
        {
            if (txtIgual.Text != "")
            {
                for (int x = 0; x < Resultado.GetLength(0); x++)
                {
                    for (int y = 0; y < Resultado.GetLength(1); y++)
                    {
                        if (txtIgual.Text.Contains("/"))
                        {

                            double Result;
                            string dividir = "";
                            string dividir2 = "";

                            string[] division = txtIgual.Text.Split('/');
                            for (int i = 0; i < division.Length; i++)
                            {

                                if (i == 0)
                                {
                                    dividir = division[i];
                                }
                                else
                                {
                                    dividir2 = division[i];
                                }
                            }
                            Result = Convert.ToDouble(dividir) / Convert.ToDouble(dividir2);
                            txtIgual.Text = Convert.ToString(Result);
                        }
                        if (M1[x, y].Text.Contains("/"))
                        {

                            double Result;
                            string dividir = "";
                            string dividir2 = "";

                            string[] division = M1[x, y].Text.Split('/');
                            for (int i = 0; i < division.Length; i++)
                            {

                                if (i == 0)
                                {
                                    dividir = division[i];
                                }
                                else
                                {
                                    dividir2 = division[i];
                                }
                            }
                            Result = Convert.ToDouble(dividir) / Convert.ToDouble(dividir2);
                            M1[x, y].Text = Convert.ToString(Result);
                        }
                        RES1 = System.Convert.ToDouble(M1[x, y].Text);
                        if (txtIgual.Text== "e")
                        {
                            string con;
                            con = Convert.ToString(RES1);
                            Resultado[x, y].Text = con + txtIgual.Text;
                        }
                        else
                        {
                            RES2 = System.Convert.ToDouble(txtIgual.Text);
                            RES3 = RES1 * RES2;
                            Resultado[x, y].Text = System.Convert.ToString(RES3);
                        }
                        
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe colocar un valor en el campo antes de multiplicar", "Error");
            }
        }


        #endregion

    }
}
