using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatematicaProyecto1.Models;

//Esta clase se utiliza para devolver la respuesta cuando se envia un texto a codificar/decodificar,
//para poder devolver un Codigo 0 si hubo algun error y un 1 si todo fue satisfactorio
//ademas en el String output, devuelvo notas sobre la conversión
//y en el string resultado devuelvo el valor coificado/decodificado
public class RespuestaGen
{
    public int codigo { get; set; } = 1;
    public string resultado { get; set; } = "";
    public string output { get; set; } = "";

}
