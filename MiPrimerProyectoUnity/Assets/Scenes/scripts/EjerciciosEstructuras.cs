using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjerciciosEstructuras : MonoBehaviour
{
    public List<int> milista = new List<int>();

    // Start is called before the first frame update

     void Start()
    {
        for (int i = 0; i < 5; i++) 
        {
            milista.Add(Random.Range(1, 20));

        }
        foreach (var num in milista)
        {
            Debug.Log(num);
        }
        milista.Sort();
        foreach (var num in milista)
        {
            Debug.Log("lista ordenada" + " " + num);
        }
        milista.Reverse();
        foreach (var num in milista)
        {
            Debug.Log("lista en reversa" + " " + num);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
        public void punto1()
        {
        ////        Crea una funci�n que reciba como par�metros tres n�meros, llene una lista de
        ////n�meros aleatorios del tama�o del primer n�mero y los rangos de los n�meros
        ////aleatorios est�n dados por el segundo y tercer par�metro, la firma de la funci�n
        ////ser� algo similar a: public List<int> miFuncion(int tama�o, int rangoInferior, int
        ////rangoSuperior)
        //int primerParamtero = 10;
        //int segundoParametro = 1;
        //int tercerParametro = 5;

        //for (int i = 0; i <= primerParamtero; i++)
        //{
        //    milista.Add(Random.Range(tercerParametro, segundoParametro));
        //    i++;

        //}
        //foreach (var numero in milista)
        //{
        //    Debug.Log(numero);
        //}

    }
    public void punto2()
    {
        //        Crea una funci�n que reciba como entrada un arreglo de enteros, y regrese un
        //arreglo con los mismos n�meros pero ordenados de manera descendente.
        for (int i = 0; i < 5; i++)
        {
            milista.Add(Random.Range(1, 20));
           
        }
        foreach(var num in milista)
        {
            Debug.Log(num);
        }
        //aqui juge un poco con querrylinq.
        milista.Reverse();
        foreach (var num in milista)
        {
            Debug.Log("lista en reversa" + " " + num);
        }

        milista.Sort();
        foreach (var num in milista)
        {
            Debug.Log("lista ordenada" + " " + num);
        }

    }
        
    
}
