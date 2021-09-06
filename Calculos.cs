using System;
using System.Windows.Forms;

namespace CalculadoraMatrices
{
    public class Calculos
    {
              
        public void Multiplicacion(TextBox[,] Ma, TextBox[,] Mb,TextBox[,] Mr)
        {
            
            int Col1 = Ma.GetLength(1);
            int Col2 = Mb.GetLength(1);
            int Fil1 = Ma.GetLength(0);
            int Fil2 = Mb.GetLength(0);
            double R1, R2, R3;
            float[,] Res;
            if (Col1 != Fil2)
            {
                Res = null;
            }
            else
            {
                Res = new float[Fil1, Col2];
                for (int a = 0; a < Col2; a++)
                {
                    for (int i = 0; i < Fil1; i++)
                    {
                        float sum = 0;
                        for (int j   = 0; j < Col1; j++)
                        {
                            R1 = System.Convert.ToDouble(Ma[i, j].Text);
                            R2 = System.Convert.ToDouble(Mb[j, a].Text);
                            R3 = sum;
                            R3 += R1 * R2;
                            sum = (float)R3;
                        }
                        Res[i, a] = sum;
                        Mr[i, a].Text = System.Convert.ToString(sum);
                    }
                }
            }
           
        }

        public void traspuesta(TextBox[,]Ma, TextBox[,] res)
        {
            for (int x = 0; x < Ma.GetLength(1); x++)
            {
                for (int y = 0; y < Ma.GetLength(0); y++)
                {

                    res[x, y].Text = Ma[y, x].Text;
                }
            }
        }

        public void Suma(double R1, double R2,double R3, TextBox[,] Ma, TextBox[,] Mb, TextBox[,] Res)
        {
            for (int x = 0; x < Res.GetLength(0); x++)
            {
                for (int y = 0; y < Res.GetLength(1); y++)
                {
                    if (!(Ma[x,y].Text.Contains("/")))
                    {
                        R1 = System.Convert.ToDouble(Ma[x, y].Text);
                    }

                    if (!(Mb[x, y].Text.Contains("/")))
                    {
                        R2 = System.Convert.ToDouble(Mb[x, y].Text);
                    }
                    if ((Ma[x,y].Text.Contains("/") || Mb[x,y].Text.Contains("/")))
                    {

                        if (Ma[x, y].Text.Contains("/"))
                        {
                            double Result;
                            string dividir = "";
                            string dividir2 = "";
                            string[] division = Ma[x, y].Text.Split('/');
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
                            R1 = Result;

                        }
                        if (Mb[x, y].Text.Contains("/"))
                        {
                            double Result;
                            string dividir = "";
                            string dividir2 = "";
                            string[] division = Mb[x, y].Text.Split('/');
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
                            R2 = Result;


                        }
                        
                        

                    }
                    System.Convert.ToInt32(Res[x, y].Text);
                    R3 = R1 + R2;
                    Res[x, y].Text = System.Convert.ToString(R3);
                }
            }
        }

        public void Resta(double R1, double R2, double R3, TextBox[,] Ma, TextBox[,] Mb, TextBox[,] Res)
        {
            for (int x = 0; x < Res.GetLength(0); x++)
            {
                for (int y = 0; y < Res.GetLength(1); y++)
                {
                    R1 = System.Convert.ToDouble(Ma[x, y].Text);
                    R2 = System.Convert.ToDouble(Mb[x, y].Text);
                    System.Convert.ToInt32(Res[x, y].Text);
                    R3 = R1 - R2;
                    Res[x, y].Text = System.Convert.ToString(R3);
                }
            }
        }
    }
}
