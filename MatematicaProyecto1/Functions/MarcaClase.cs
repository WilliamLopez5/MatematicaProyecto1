using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatematicaProyecto1.Functions;

public class MarcaClase
{
    private int intBase;

    public MarcaClase()
    {
        intBase = 29;
    }

    //metodo utilizado para calcular la equivalencia de clase y que el valor siempre este entre los valores 0 y 29
    public int CalcularEquivalenciaClase(int valor)
    {
        int respuesta = 0;
        try
        {
            if (valor < 0)
            {
                valor += intBase;
                return CalcularEquivalenciaClase(valor);
            }
            respuesta = valor % intBase; 
        }
        catch (Exception ex)
        {

        }
        return respuesta;
    }

}
