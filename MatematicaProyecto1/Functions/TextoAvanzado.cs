using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MatematicaProyecto1.Models;

namespace MatematicaProyecto1.Functions;

public class TextoAvanzado
{
    private string[] arrAbecedario;
    public TextoAvanzado()
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

//ToDo
//Falta validar que la longitud del textoAnaliza coincide con un multiplo de las filas/Columnas de la matri a utilizar para codificar
//Falta utilizar la opciones de FuncMatrizAvanzada para codificar el textoAnalizar











        return respuesta;

    }


}
