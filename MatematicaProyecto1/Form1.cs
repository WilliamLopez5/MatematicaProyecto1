using MatematicaProyecto1.Functions;
using MatematicaProyecto1.Models;

namespace MatematicaProyecto1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCodificar_Click(object sender, EventArgs e)
        {
            Texto texto = new Texto();
            try
            {
                if (string.IsNullOrEmpty(txtCodificar.Text))
                {
                    txtCodificarOutput.Text = "Debe ingresar un texto a codificar";
                    return;
                }

                RespuestaGen respuesta;
                //Analizar texto
                respuesta = texto.Codificar_DecodificarTexto(txtCodificar.Text, true);

                //Mostrar resultados
                txtCodificado.Text = respuesta.resultado;
                if (respuesta.codigo == 0)
                {
                    txtCodificarOutput.Text = "Ejecución terminada con errores, código: ";
                }
                else
                {
                    txtCodificarOutput.Text = "Ejecución terminada con éxito, código: ";
                }
                txtCodificarOutput.Text += respuesta.codigo + "\n";
                txtCodificarOutput.Text += respuesta.output;

            }
            catch (Exception ex)
            {
                txtCodificarOutput.Text = "Error durante la codificación" + ex.Message + " " + ex.StackTrace;

            }
        }


        private void cmdDecodificar_Click(object sender, EventArgs e)
        {
            Texto texto = new Texto();
            try
            {
                if (string.IsNullOrEmpty(txtDecodificar.Text))
                {
                    txtDecodificarOutput.Text = "Debe ingresar un texto a decodificar";
                    return;
                }

                RespuestaGen respuesta;
                //Analizar texto
                respuesta = texto.Codificar_DecodificarTexto(txtDecodificar.Text, false);

                //Mostrar resultados
                txtDecodificado.Text = respuesta.resultado;
                if (respuesta.codigo == 0)
                {
                    txtDecodificarOutput.Text = "Ejecución terminada con errores, código: ";
                }
                else
                {
                    txtDecodificarOutput.Text = "Ejecución terminada con éxito, código: ";
                }
                txtDecodificarOutput.Text += respuesta.codigo + "\n";
                txtDecodificarOutput.Text += respuesta.output;

            }
            catch (Exception ex)
            {
                txtDecodificarOutput.Text = "Error durante la decodificación" + ex.Message + " " + ex.StackTrace;

            }

        }

        private void btnCodificarAvanzado_Click(object sender, EventArgs e)
        {
            TextoAvanzado texto = new TextoAvanzado();
            try
            {
                if (string.IsNullOrEmpty(txtCodificar.Text))
                {
                    txtCodificarOutput.Text = "Debe ingresar un texto a codificar";
                    return;
                }

                RespuestaGen respuesta;
                //Analizar texto
                respuesta = texto.Codificar_DecodificarTexto(txtCodificar.Text, true);

                //Mostrar resultados
                txtCodificado.Text = respuesta.resultado;
                if (respuesta.codigo == 0)
                {
                    txtCodificarOutput.Text = "Ejecución terminada con errores, código: ";
                }
                else
                {
                    txtCodificarOutput.Text = "Ejecución terminada con éxito, código: ";
                }
                txtCodificarOutput.Text += respuesta.codigo + "\n";
                txtCodificarOutput.Text += respuesta.output;

            }
            catch (Exception ex)
            {
                txtCodificarOutput.Text = "Error durante la codificación" + ex.Message + " " + ex.StackTrace;

            }

        }

        private void cmdDecodificarAvanzado_Click(object sender, EventArgs e)
        {
            TextoAvanzado texto = new TextoAvanzado();
            try
            {
                if (string.IsNullOrEmpty(txtDecodificar.Text))
                {
                    txtDecodificarOutput.Text = "Debe ingresar un texto a decodificar";
                    return;
                }

                RespuestaGen respuesta;
                //Analizar texto
                respuesta = texto.Codificar_DecodificarTexto(txtDecodificar.Text, false);

                //Mostrar resultados
                txtDecodificado.Text = respuesta.resultado;
                if (respuesta.codigo == 0)
                {
                    txtDecodificarOutput.Text = "Ejecución terminada con errores, código: ";
                }
                else
                {
                    txtDecodificarOutput.Text = "Ejecución terminada con éxito, código: ";
                }
                txtDecodificarOutput.Text += respuesta.codigo + "\n";
                txtDecodificarOutput.Text += respuesta.output;

            }
            catch (Exception ex)
            {
                txtDecodificarOutput.Text = "Error durante la decodificación" + ex.Message + " " + ex.StackTrace;

            }

        }

        private void cmdGuardarMatriz_Click(object sender, EventArgs e)
        {
            try
            {
                FuncMatriz funcMatriz = new FuncMatriz();
                RespuestaGen respuestaGen = new RespuestaGen();
                ManejoArchivos manejoArchivos = new ManejoArchivos();
                string textoMatiz = txtMatriz.Text;
                txtMatrizOutput.Text = "";
                if (string.IsNullOrEmpty(textoMatiz))
                {
                    txtMatrizOutput.Text += "Debe de ingresar la matriz a configurar";
                    return;
                }
                respuestaGen = funcMatriz.ValidarMatrizCuadrada(textoMatiz);
                txtMatrizOutput.Text += respuestaGen.output;
                if (respuestaGen.codigo == 0)
                {
                    return;
                }

                respuestaGen = funcMatriz.ValidarNumerosEnteros(textoMatiz);
                txtMatrizOutput.Text += respuestaGen.output;
                if (respuestaGen.codigo == 0)
                {
                    return;
                }

                respuestaGen = funcMatriz.CalcularDeterminante(textoMatiz);
                txtMatrizOutput.Text += respuestaGen.output;
                if (respuestaGen.codigo == 0)
                {
                    return;
                }

                txtMatrizOutput.Text += $"El determinante es: {respuestaGen.resultado} \n";
                if (!(respuestaGen.resultado.Equals("1") || respuestaGen.resultado.Equals("-1")))
                {
                    txtMatrizOutput.Text += $"El determinante debe ser 1 ó -1";
                    return;
                }

                respuestaGen = funcMatriz.CalcularAdjunta(textoMatiz, int.Parse(respuestaGen.resultado));
                txtMatrizOutput.Text += respuestaGen.output;
                if (respuestaGen.codigo == 0)
                {
                    return;
                }

                respuestaGen = manejoArchivos.GuardarArchivoMatricesPersonalizadas(textoMatiz, respuestaGen.resultado);
                txtMatrizOutput.Text += respuestaGen.output;
                if (respuestaGen.codigo == 0)
                {
                    return;
                }

            }
            catch (Exception ex)
            {

            }
        }


    }
}
