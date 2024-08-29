using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MatematicaProyecto1.Models;

namespace MatematicaProyecto1.Functions;

public class FuncMatriz
{

    public RespuestaGen ValidarMatrizCuadrada(string matriz)
    {
        RespuestaGen respuestaGen = new RespuestaGen();
        try
        {
            //Aplicar split por salto de línea "\n"
            string[] lineas = matriz.Split('\n');

            respuestaGen.output = $"Cantidad de Filas de la matriz: {lineas.Length} \n";

            int i = 1;
            // Recorrer cada línea
            foreach (string linea in lineas)
            {
                //Aplicar split por coma "," para recorrer los valores de las columnas
                string[] columnas = linea.Split(',');

                respuestaGen.output += $"La fila # {i} tiene: {columnas.Length} Columnas \n";

                if (columnas.Length != lineas.Length)
                {
                    respuestaGen.codigo = 0;
                    respuestaGen.output += $"La cantidad de filas y Columnas no coinciden para la fila: {i} \n";
                    respuestaGen.output += "La Matriz no es Cuadrada \n";
                }
                i++;
            }
            if(respuestaGen.codigo==0)
            {
                respuestaGen.output += $"La matriz a configurar no es cuadrada \n";
            }
        }
        catch (Exception ex) {
            respuestaGen.codigo = 0;
            respuestaGen.output = ex.Message;
        }
        return respuestaGen;
    }

    public RespuestaGen ValidarNumerosEnteros(string matriz)
    {
        RespuestaGen respuestaGen = new RespuestaGen();
        try
        {
            //Aplicar split por salto de línea "\n"
            string[] lineas = matriz.Split('\n');
            int i = 1;
            // Recorrer cada línea
            foreach (string linea in lineas)
            {
                //Aplicar split por coma "," para recorrer los valores de las columnas
                string[] columnas = linea.Split(',');
                int j = 1;
                foreach (string valor in columnas)
                {
                    int valorEntero = 0;
                    if(!int.TryParse(valor, out valorEntero))
                    {
                        respuestaGen.codigo = 0;
                        respuestaGen.output += $"El valor: {valor} no es un numero entero, fila: {i}, Columna: {j} \n";
                    }
                    if (valorEntero < 0 || 28 < valorEntero)
                    {
                        respuestaGen.codigo = 0;
                        respuestaGen.output += $"El valor: {valor} no esta en el rango de valores validos de 0-28, fila: {i}, Columna: {j}  \n";
                    }

                    j++;
                }
                i++;
            }
        }
        catch (Exception ex)
        {
            respuestaGen.codigo = 0;
            respuestaGen.output = ex.Message;
        }
        return respuestaGen;
    }

    public RespuestaGen CalcularDeterminante(string matriz)
    {
        RespuestaGen respuestaGen = new RespuestaGen();

        try
        {
            string[] lineas = matriz.Split('\n');
            if (lineas.Length == 1)
            {
                string[] fila1 = lineas[0].Split(',');

                if (fila1.Length == 1 )
                {
                    int determinante = 0;
                    determinante = int.Parse(fila1[0]);
                    respuestaGen.resultado = determinante.ToString();

                }
                else
                {
                    respuestaGen.codigo = 0;
                    respuestaGen.output += $"La cantidad de columnas deben de ser 1 para cada fila, Fila1:{fila1.Length}";
                }
            }
            else
            {
                int valorDeterminante=0;
                string matrizAux = "";
                string[] columnasPivot = lineas[0].Split(',');

                int i = 0;
                //valor utilizado para alternar el signo -
                int cambio = 1;
                foreach (string columnaPivot in columnasPivot)
                {
                    matrizAux = "";
                    bool isPrimerLinea = true;
                    string filaSubMatriz="";
                    foreach (string linea in lineas)
                    {
                        filaSubMatriz = "";
                        if (isPrimerLinea)
                        {
                            isPrimerLinea=false;
                            continue;
                        }
                        string[] columnas = linea.Split(',');
                        int j = 0;
                        foreach (string columna in columnas)
                        {
                            if (i != j)
                            {
                                if (!filaSubMatriz.Equals(""))
                                {
                                    filaSubMatriz += ",";
                                }
                                filaSubMatriz += columna;
                            }
                            j++;
                        }
                        if (!matrizAux.Equals(""))
                        {
                            matrizAux += "\n";
                        }
                        matrizAux += filaSubMatriz;
                    }

                    RespuestaGen respuestaGenAux = new RespuestaGen();
                    respuestaGenAux = CalcularDeterminante(matrizAux);
                    //Si hubo algu error, no continuar con la ejecución
                    if (respuestaGenAux.codigo == 0)
                    {
                        return respuestaGenAux;
                    }
                    valorDeterminante += cambio * int.Parse(columnaPivot) * int.Parse(respuestaGenAux.resultado);
                    cambio *= -1;
                    i++;
                }
                respuestaGen.resultado = valorDeterminante.ToString();
                
            }

        }
        catch (Exception ex)
        {
            respuestaGen.codigo = 0;
            respuestaGen.output += ex.Message + "\n" + ex.Source + "\n" + ex.StackTrace;
        }

        return respuestaGen;

    }

    public RespuestaGen CalcularAdjunta(string matriz, int determinante)
    {
        RespuestaGen respuestaGen = new RespuestaGen();
        MarcaClase marcaClase = new MarcaClase();

        try
        {
            string[] filas = matriz.Split('\n');
            string matrizCofactores = "";
            string filaCofactores = "";

            string matrizAux = "";
            string filaSubMatriz = "";

            int i = 0;
            int j = 0;
            int cambioFila = 1;
            int cambioCol = 1;
            foreach (string fila in filas)
            {
                string[] columnas = fila.Split(',');
                filaCofactores = "";
                cambioCol = 1;
                j = 0;
                foreach (string columna in columnas)
                {
                    int k = 0;
                    int l = 0;
                    matrizAux = "";
                    string[] filasSub = matriz.Split('\n');
                    foreach (string filaSub in filasSub)
                    {
                        filaSubMatriz = "";
                        if (k != i)
                        {
                            l = 0;
                            string[] columnasSub = filaSub.Split(',');
                            foreach (string columnaSub in columnasSub)
                            {
                                if (j != l)
                                {
                                    if (!filaSubMatriz.Equals(""))
                                    {
                                        filaSubMatriz += ",";
                                    }
                                    filaSubMatriz += columnaSub;
                                }
                                l++;
                            }
                            if (!matrizAux.Equals(""))
                            {
                                matrizAux += "\n";
                            }
                            matrizAux += filaSubMatriz;
                        }
                        k++;
                    }


                    RespuestaGen respuestaGenAux = new RespuestaGen();
                    //respuestaGen.output += $"SubMatriz {columna}: \n {matrizAux}\n";
                    respuestaGenAux = CalcularDeterminante(matrizAux);
                    //Si hubo algu error, no continuar con la ejecución
                    if (respuestaGenAux.codigo == 0)
                    {
                        return respuestaGenAux;
                    }

                    //respuestaGen.output += $"Determinante de {columna}: {respuestaGenAux.resultado}\n";
                    //respuestaGen.output += $"Cambio de Fila: {cambioFila} \n";
                    //respuestaGen.output += $"Cambio de Columna: {cambioCol} \n";

                    if (!filaCofactores.Equals(""))
                    {
                        filaCofactores += ",";
                    }

                    //filaCofactores += marcaClase.CalcularEquivalenciaClase(cambioFila * cambioCol * int.Parse(respuestaGenAux.resultado));
                    int valorCofactor = ((cambioFila * cambioCol * int.Parse(respuestaGenAux.resultado)) / determinante);
                    valorCofactor = marcaClase.CalcularEquivalenciaClase(valorCofactor);
                    filaCofactores += valorCofactor.ToString();
                    cambioCol *= -1;
                    j++;
                }

                if (!matrizCofactores.Equals(""))
                {
                    matrizCofactores += "\n";
                }
                matrizCofactores += filaCofactores;

                cambioFila *= -1;
                i++;
            }

            respuestaGen.output += "La matriz de cofactores es: \n" + matrizCofactores + "\n";

            //Calculo de transpuesta a matriz de cofactores
            string[] filasC = matrizCofactores.Split('\n');
            string[] filasT=new string[filasC.Length];
            Array.Fill(filasT, "");
            string matrizT = "";

            foreach (string filaC in filasC)
            {
                int indice = 0;
                string[] columnasC = filaC.Split(',');
                foreach (string columnaC in columnasC)
                {
                    if (!filasT[indice].Equals(""))
                    {
                        filasT[indice] += ",";
                    }
                    filasT[indice] += columnaC;
                    indice++;
                }
            }

            foreach (string filaT in filasT)
            {
                if (!matrizT.Equals(""))
                {
                    matrizT += "\n";
                }
                matrizT += filaT;
            }

            respuestaGen.resultado = matrizT;
            respuestaGen.output += "La matriz de Inversa es: \n" + matrizT + "\n";

        }
        catch (Exception ex)
        {
            respuestaGen.codigo = 0;
            respuestaGen.output += ex.Message + "\n" + ex.Source + "\n" + ex.StackTrace;
        }

        return respuestaGen;

    }

}
