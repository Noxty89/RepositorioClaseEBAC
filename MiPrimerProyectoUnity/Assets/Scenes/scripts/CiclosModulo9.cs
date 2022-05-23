using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CiclosModulo9 : MonoBehaviour
{
    // for          => sabemos cuantas veces se repitira el ciclo
    // while        => no sabemos cuantas veces se repetira el ciclo
    // do while      => no sabemos cuantas veces se repetira el ciclo almenos se ejecutara una vez
    // arreglos Unidimencionales => [0 , 1, 2, 3, 4,]
    // arreglos multydimencionales =>
    //                              [0, 1, 2,]
    //                              [3, 4, 5,]
    //                              [6, 7, 8,]
    // Jagged                    =>
    //                              [0, 1, 2, 3, 4, 5,]
    //                              [6, 7,]
    //                              [8, 9, 10,]
    //For each
      
    // Start is called before the first frame update
    void Start()
    {
        //        Crea dos arreglos unidimensionales de números enteros y llenalos usando un ciclo y la
        //función Random.Range con números enteros, después crea un tercer arreglo y llénalo
        //con la suma de los elementos de los primeros dos: por ejemplo arr3[5] = arr1[5] + arr[6]

        int[] MisEnteros = new int[5] { '1', '2', '3', '4', '5' };


        for (int i = 0; i < MisEnteros.Length; i++)
        {
            Debug.Log("valor de i" + " " + MisEnteros[i]);

        }
        int[] MisEnteros1 = new int[5] { '1', '2', '3', '4', '5' };
        for (int i = 0; i < MisEnteros1.Length; i++)
        {
            Debug.Log("valor de k" + " " + MisEnteros1[i]);
        }
        int[] MisEnteros2 = new int[] { '1', '2', '3', '4', '5', '6', '7', '8', '9', };
        int j = 0;
        for (int i = 0; i < MisEnteros2.Length; i++)
        {
            MisEnteros2[j] = MisEnteros[i] + MisEnteros1[i];
            j++;
            MisEnteros2[j] = MisEnteros[i] + MisEnteros1[i];
            j++;

            string Arr3 = " ";
            foreach (int num in MisEnteros2)
            {
                Arr3 = Arr3 + " " + num;
            }
            Debug.Log(Arr3);

        }
        {

        }
        //        Crea un arreglo de strings y llena cada elemento con una palabra de una oración, 
        //después utilizando un ciclo foreach concatena sus elementos e imprime la oración
        //completa en la consola en un solo string.


        //string[] Palabras = new string[5] { "hola", "Como", "te", "sientes", "hoy" };

        //string OraCompleta = " ";
        //foreach (string text in Palabras)
        //{
        //    OraCompleta = OraCompleta + " " + text;


        //}
        //Debug.Log(OraCompleta);

        //Crea un arreglo bidimensional de enteros de 2 renglones y 3 columnas al menos y
        //multiplícalo por un arreglo unidimensional de enteros con la cantidad de elementos
        //que se alinee a la cantidad de renglones del arreglo bidimensional de tal manera que
        //la operación sea una multiplicación matriz.

        //int[,] ArrBi = new int[3, 2] { { 1, 2,  }, { 3, 4, }, { 5, 6, } };
        //for (int j = 0; j < ArrBi.GetLength(0); j++)
        //{
        //    for (int k = 0; k < ArrBi.GetLength(1); k++)
        //    {
        //        for (int l = 0; l < ArrBi.GetLength(2); l++)
        //        {

        //        }
        //        int[] ArrUni = new int[3] { 1, 2, 3, };
        //        for (int i = 0; i < ArrUni.Length; i++)
        //        {

        //        }
        //        int[,] Matrismulti = new int[3, 2] { { 1, 2, }, { 3, 4, }, { 5, 6, } };

        //        for (int u = 0; u < Matrismulti.GetLength(0); u++)
        //        {
        //            for (int v = 0; v < Matrismulti.GetLength(1); v++)
        //            {
        //                for (int w = 0; w < Matrismulti.GetLength(2); w++)
        //                {
        //                    Matrismulti[u, v] = ArrBi[j, k] * ArrUni(i);
        //                    u++;
        //                    v+

        //                }
        //            }
        //        }

        //    }
        //}




    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
}
