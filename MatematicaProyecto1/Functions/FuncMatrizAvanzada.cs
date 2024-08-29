using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MatematicaProyecto1.Models;

namespace MatematicaProyecto1.Functions;

public class FuncMatrizAvanzada
{
    //Matrices bases utilizadas para codificar/decodificar
    private int[,] arrCodificadora;
    private int[,] arrDecodificadora;
    public FuncMatrizAvanzada()
    {
        CargarMatrices();

    }

    private void CargarMatrices()
    {
        //ToDo
        //Leer el archivo donde se guarda la matriz configurada y asignarla a la matriz para codificar/decodificar
    }

    public RespCodDecodBase CodificarDecodificar(string textoCodificar, bool codificar)
    {
        MarcaClase marcaClase = new MarcaClase();
        RespCodDecodBase respCodDecodBase = new RespCodDecodBase();

        try
        {
            //ToDo
            //utilizar la matriz corresondiente para codificar/decodificar el textoCodificar
        }
        catch
        {

        }

        return respCodDecodBase;

    }

}
