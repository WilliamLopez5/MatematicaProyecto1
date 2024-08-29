using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MatematicaProyecto1.Models;

namespace MatematicaProyecto1.Functions;

//Clase utilizada para las funciones de Matrices

public class FuncMatrizBase
{
    //Matrices bases utilizadas para codificar/decodificar
    private int[,] arrCodificadora;
    private int[,] arrDecodificadora;
    public FuncMatrizBase()
    {
        arrCodificadora = new int[,] {
                                        { 1, 2 },
                                        { 2, 5 }
                                     };

        arrDecodificadora = new int[,] {
                                        {  5, 27 },
                                        { 27,  1 }
                                     };

    }

    public RespCodDecodBase CodificarDecodificar(int valor1, int valor2, bool codificar)
    {
        MarcaClase marcaClase = new MarcaClase();
        RespCodDecodBase respCodDecodBase = new RespCodDecodBase();

        try
        {
            int[,] arrAuxiliar;
            if (codificar)
            {
                arrAuxiliar = arrCodificadora;
            }
            else
            {
                arrAuxiliar = arrDecodificadora;

            }
            respCodDecodBase.Valor1 = arrAuxiliar[0, 0] * valor1 + arrAuxiliar[0, 1] * valor2;
            respCodDecodBase.Valor2 = arrAuxiliar[1, 0] * valor1 + arrAuxiliar[1, 1] * valor2;

            respCodDecodBase.Valor1 = marcaClase.CalcularEquivalenciaClase(respCodDecodBase.Valor1);
            respCodDecodBase.Valor2 = marcaClase.CalcularEquivalenciaClase(respCodDecodBase.Valor2);

        }
        catch
        {

        }

        return respCodDecodBase;

    }


}
