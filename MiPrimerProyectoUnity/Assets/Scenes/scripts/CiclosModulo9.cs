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

        //int[] MisEnteros = new int[5] {'1', '2', '3', '4', '5'};


        //for (int i = 0; i < MisEnteros.Length; i++)
        //{
        //          Debug.Log("valor de i" + " " + MisEnteros[i]);

        //}
        //int[] MisEnteros1 = new int[5] { '1', '2', '3', '4', '5' };
        //for (int i = 0 ; i < MisEnteros1.Length; i++)
        //{
        //    Debug.Log("valor de k"+ " " + MisEnteros1[i]);
        //}
        //int[] MisEnteros2 = new int[] { '1', '2', '3', '4', '5','6','7','8','9',};
        //int j = 0;
        //for (int i = 0; i < MisEnteros2.Length; i++)
        //{
        //    MisEnteros2[j] = MisEnteros[i]+ MisEnteros1[i];
        //    j++;
        //    MisEnteros2[j] = MisEnteros[i] + MisEnteros1[i];
        //    j++;

        //string Arr3 = " ";
        //foreach (int num in MisEnteros2)
        //{
        //    Arr3 = Arr3 + " " + num;
        //}
        //Debug.Log(Arr3);

        //}
        //{

        //}
        //        Crea un arreglo de strings y llena cada elemento con una palabra de una oración, 
        //después utilizando un ciclo foreach concatena sus elementos e imprime la oración
        //completa en la consola en un solo string.


        string[] Palabras = new string[5] { "hola", "Como", "te", "sientes", "hoy" };

        string OraCompleta = " ";
        foreach (string text in Palabras)
        {
            OraCompleta = OraCompleta + " " + text;

            
        }
        Debug.Log(OraCompleta);






        //for (int i = 0; i < 10; i++)
        //{
        //    Debug.Log(i);
        //}
        //while (Contador < 10)
        //{
        //    Contador++;
        //    Debug.Log("hola");
        //}




    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
}
