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

        //int[] MisEnteros = new int[5];
        //for (int i = 0; i < MisEnteros.Length; i++)
        //{
        //    Debug.Log("valor de i" + " " + MisEnteros[i]);

        //}
        //int[] MisEnteros1 = new int[5] { 1, 2, 3, 4, 5 };
        //for (int i = 0; i < MisEnteros1.Length; i++)
        //{
        //    Debug.Log("valor de k" + " " + MisEnteros1[i]);
        //}
        //int[] MisEnteros2 = new int[5] { 1, 2, 3, 4, 5 };
        //for (int i = 0; i < MisEnteros2.Length; i++)
        //{
        //    MisEnteros2[i] = MisEnteros[i] + MisEnteros1[i];
        //    i++;
        //    MisEnteros2[i] = MisEnteros[i] + MisEnteros1[i];

        //}
        //string Arr3 = " ";
        //foreach (int num in MisEnteros2)
        //{
        //    Arr3 = Arr3 + " " + num;
        //}
        //Debug.Log(Arr3);
        //{

        //}
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

        int[,] ArrBi = new int[2, 3] { { 1, 2, 3, }, { 4, 5, 6, } };
        for (int j = 0; j < ArrBi.GetLength(0); j++)
        {
            for (int k = 0; k < ArrBi.GetLength(1); k++)
            {
                int ArrBilleno = ' ';
                foreach (int num in ArrBi)
                    ArrBilleno = ArrBilleno + ' ' + num;
                Debug.Log(ArrBilleno);

                int[] ArrUni = new int[3] { 1, 2, 3, };
                for (int i = 0; i < ArrUni.Length; i++)
                {
                    int Arrunilleno = ' ';
                    foreach (int num in ArrUni)
                        Arrunilleno = Arrunilleno + ' ' + num;

                    Debug.Log(Arrunilleno);
                    //Primero define el array donde se guardaran los datos.//
                    int[] ResultArray = new int[ArrBi.GetLength(0)]; //Array de [2,1] es decir, dos filas una columna

                   //Aqui se harian 3 multiplicaciones//
                    for (int z = 0; z < ArrUni.Length; z++)
                    {
                        for (int w = 0; w < ArrBi.GetLength(0); w++)
                        {
                            //Aqui se repetirian 2 veces la multiplicacion//
                            ResultArray[z] += ResultArray[z] + (ArrBi[j,0] * ArrUni[i]);
                            z++;
                            ResultArray[w] += ResultArray[w] + (ArrBi[k,0] * ArrUni[i]);
                            w++;
                            //primer ciclo con el primer numero del arregloUni tendriamos: ResultArray[0] = 0 + (1 * 7)
                            //segundo ciclo con el primer numero del arregloUni tendriamos: ResultArray[1] = 0 + (4 * 7)                    
                            }
                        }
                    for (int z = 0; z < ArrUni.Length; z++)
                    {
                        for (int w = 0; w < ArrBi.GetLength(0); j++)
                        {
                            ResultArray[z] += ResultArray[z] + (ArrBi[z, w] * ArrUni[i]);
                            ResultArray[w] += ResultArray[w] + (ArrBi[z, w] * ArrUni[i]);

                            Debug.Log(ResultArray[0]);
                            Debug.Log(ResultArray[1]);
                            //primer ciclo con el tercer numero del arregloUni tendriamos: ResultArray[0] = 23 + (3 * 9)
                            //segundo ciclo con el tercer numero del arregloUni tendriamos: ResultArray[1] = 68 + (6 * 9)
                        }
                      
                    }
                
                            //primer ciclo con el segundo numero del arregloUni tendriamos: ResultArray[0] = 7 + (2 * 8)
                            //segundo ciclo con el segundo numero del arregloUni tendriamos: ResultArray[1] = 28 + (5 * 8)
                        }
                    }
                }
        }

    // Update is called once per frame
    void Update()
    {
        
        
    }
}
