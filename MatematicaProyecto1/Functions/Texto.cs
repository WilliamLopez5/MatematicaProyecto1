using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using MatematicaProyecto1.Models;

namespace MatematicaProyecto1.Functions;

public class Texto
{
    private string[] arrAbecedario;

    public Texto()
    {
        arrAbecedario = new string[] { " ", "A", "B", "C", "D",
                                    "E", "F", "G", "H", "I",
                                    "J", "K", "L", "M", "N",
                                    "O", "P", "Q", "R", "S",
                                    "T", "U", "V", "W", "X",
                                    "Y", "Z", ".", ","
        };
    }

    public RespuestaGen Codificar_DecodificarTexto(string strInput, bool codificar)
    {
        RespuestaGen respuesta = new RespuestaGen();
        FuncMatrizBase funcMatrizBase = new FuncMatrizBase();
        RespCodDecodBase respCodDecodBase = new RespCodDecodBase();
        int valor1 = 0;
        int valor2 = 0;
        string textoAnaliar = "";
        strInput = strInput.ToUpper();

        int i = 1;
        int index = -1;
        //Recorrer el texto a codificar/Decodificar para identificar caracteres no validos
        foreach (char letra in strInput)
        {
            // Obtener el índice de cada elemento que forma el mensaje a codificar/Decodificar
            index = Array.IndexOf(arrAbecedario, letra.ToString());

            // Si la letra existe  (índice mayor o igual a 0)
            if (index >= 0)
            {
                textoAnaliar += letra.ToString();
            }
            else
            {
                respuesta.codigo = 0;
                respuesta.output += $"El simbolo: {letra}, Índice: {i} no existe en el contexto \n";
            }
            i++;
        }

        if ((textoAnaliar.Length % 2) != 0)
        {
            textoAnaliar += " ";
        }

        i = 1;
        index = -1;
        //Recorrer el texto a codificar/Decodificar
        foreach (char letra in textoAnaliar)
        {
            // Obtener el índice de cada elemento que forma el mensaje a codificar/Decodificar
            index = Array.IndexOf(arrAbecedario, letra.ToString());

            // Si la letra existe  (índice mayor o igual a 0)
            if (index >= 0)
            {
                //si se juntan el valor de dos letras, se envia a codificar
                if (i%2 == 0)
                {
                    valor2 = index;
                    respCodDecodBase = funcMatrizBase.CodificarDecodificar(valor1, valor2, codificar);
                    respuesta.resultado += arrAbecedario[respCodDecodBase.Valor1] + arrAbecedario[respCodDecodBase.Valor2];
                }
                else
                {
                    valor1 = index;
                }
            }
            i++;
        }
        return respuesta;

    }



}
