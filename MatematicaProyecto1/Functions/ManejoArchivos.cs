using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MatematicaProyecto1.Models;

namespace MatematicaProyecto1.Functions;

public class ManejoArchivos
{

    public RespuestaGen GuardarArchivoMatricesPersonalizadas(string matriz, string matrizInversa)
    {
        RespuestaGen respuestaGen = new RespuestaGen();
        string textoGuardar = "<Config>\n<Matriz>" + matriz + "</Matriz>\n<MatrizInversa>" + matrizInversa + "</MatrizInversa>\n</Config>";
        string rutaArchivo = "ConfigMatematicaPj1.txt";

        try
        {
            // Usar StreamWriter para escribir en el archivo, sobrescribiendo si ya existe
            using (StreamWriter escritor = new StreamWriter(rutaArchivo, false))  // 'false' indica sobrescribir
            {
                escritor.WriteLine(textoGuardar);
            }
            respuestaGen.resultado = "Texto guardado con éxito";
            respuestaGen.output = "Texto guardado con éxito";
        }
        catch (Exception ex)
        {
            respuestaGen.codigo = 0;
            respuestaGen.resultado = "Error al guardar el texto";
            respuestaGen.resultado = "Error al guardar el texto: " + ex.Message + "\n" + ex.Source + "\n" + ex.StackTrace;
        }
        return respuestaGen;

    }
}
