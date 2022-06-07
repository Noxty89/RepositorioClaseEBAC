using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjerciciosEstructuras : MonoBehaviour
{
    public List<int> milista = new List<int>();

    // Start is called before the first frame update
    //        Crea una función que reciba como parámetros tres números, llene una lista de
//números aleatorios del tamaño del primer número y los rangos de los números
//aleatorios estén dados por el segundo y tercer parámetro, la firma de la función
//será algo similar a: public List<int> miFuncion(int tamaño, int rangoInferior, int
//rangoSuperior)
     void Start()
    {
        int primerParamtero = 10;
        int segundoParametro = 1;
        int tercerParametro = 5;

        for (int i = 0; i <= primerParamtero; i++)
        {
            milista.Add(Random.Range(tercerParametro, segundoParametro));
            i++;
            
        }
        foreach (var numero in milista)
        {
            Debug.Log(numero);
        }
       
        
                   

        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
