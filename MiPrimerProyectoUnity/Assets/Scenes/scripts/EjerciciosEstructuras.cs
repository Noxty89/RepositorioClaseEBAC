using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjerciciosEstructuras : MonoBehaviour
{
    List<int> milista = new List<int>();
    HashSet<int> miListaHash = new HashSet<int>();
    Queue<string> miQueue = new Queue<string>();
    Stack<string> mistack = new Stack<string>();
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {

    }
    //    //Crea una función que reciba como parámetros tres números, llene una lista de
    //    //números aleatorios del tamaño del primer número y los rangos de los números
    //    //aleatorios estén dados por el segundo y tercer parámetro, la firma de la función
    //    //será algo similar a: public List<int> miFuncion(int tamaño, int rangoInferior, int
    //    //rangoSuperior)
    public void punto1(int primerParametro, int segundoParametro, int tercerParametro)
    {
        punto1(10, 5, 10);

        for (int i = 0; i <= primerParametro; i++)
        {

            milista.Add(Random.Range(tercerParametro, segundoParametro));
            i++;

        }
        foreach (var numero in milista)
        {
            Debug.Log(numero);
        }
    }
    //Crea una función que reciba como entrada un arreglo de enteros, y regrese un
    //arreglo con los mismos números pero ordenados de manera descendente.
    public List<int> punto2()
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
        return (milista);
    }
    ////    //Crea una función que reciba una lista previamente llena de números o strings
    ////    //que contenga elementos repetidos, y de salida regresa un hashset sin elementos
    ////    //repetidos, puedes usar la función contains o linq para simplificar esto.
    public HashSet<int> punto3()
    {
        List<int> listaconrepetidos = new List<int>();
        for (int i = 0; i <= 10; i++)
            listaconrepetidos.Add(i);

        var listaSinRepetidos = new HashSet<int>(listaconrepetidos);
        foreach (var num in listaSinRepetidos)
        {
            Debug.Log(num);
        }
        return (listaSinRepetidos);
    }
    //Crea una función que reciba una pila de strings, imprime sus contenidos y llena
    //con ellos una cola de strings y ahora imprime los elementos de la cola utilizando
    //los métodos respectivos de cada estructura(push, pop, queue, dequeue y peek), 
    //puedes copiar los elementos de la pila a la cola en el mismo uso del peek, esta
    //función no retornará nada, solo imprimirá los valores en la consola.
    public void queueDqueuePeek()
    {
        miQueue.Enqueue("aldeano 1");
        miQueue.Enqueue("aldeano 2");
        miQueue.Enqueue("aldeano 3");
        miQueue.Enqueue("aldeano 4");
        miQueue.Enqueue("aldeano 5");
        Debug.Log(miQueue.Peek());
        miQueue.Dequeue();
        Debug.Log(miQueue.Peek());
        miQueue.Dequeue();
        Debug.Log(miQueue.Peek());
        miQueue.Dequeue();
        Debug.Log(miQueue.Peek());
        miQueue.Dequeue();
    }
    public void pushPopPeek()
    {
        mistack.Push("municion 1");
        mistack.Push("municion 2");
        mistack.Push("municion 3");
        mistack.Push("municion 4");
        mistack.Push("municion 5");
        mistack.Push("municion 6");
        Debug.Log(mistack.Peek());
        mistack.Pop();
        Debug.Log(mistack.Peek());
        mistack.Pop();
        Debug.Log(mistack.Peek());
        mistack.Pop();
        Debug.Log(mistack.Peek());
        mistack.Pop();
        Debug.Log(mistack.Peek());
        mistack.Pop();
        Debug.Log(mistack.Peek());
        mistack.Pop();
    }

}

