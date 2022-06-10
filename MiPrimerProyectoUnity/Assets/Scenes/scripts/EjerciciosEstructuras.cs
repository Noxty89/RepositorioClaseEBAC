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
    //    //Crea una funci�n que reciba como par�metros tres n�meros, llene una lista de
    //    //n�meros aleatorios del tama�o del primer n�mero y los rangos de los n�meros
    //    //aleatorios est�n dados por el segundo y tercer par�metro, la firma de la funci�n
    //    //ser� algo similar a: public List<int> miFuncion(int tama�o, int rangoInferior, int
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
    //Crea una funci�n que reciba como entrada un arreglo de enteros, y regrese un
    //arreglo con los mismos n�meros pero ordenados de manera descendente.
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
    ////    //Crea una funci�n que reciba una lista previamente llena de n�meros o strings
    ////    //que contenga elementos repetidos, y de salida regresa un hashset sin elementos
    ////    //repetidos, puedes usar la funci�n contains o linq para simplificar esto.
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
    //Crea una funci�n que reciba una pila de strings, imprime sus contenidos y llena
    //con ellos una cola de strings y ahora imprime los elementos de la cola utilizando
    //los m�todos respectivos de cada estructura(push, pop, queue, dequeue y peek), 
    //puedes copiar los elementos de la pila a la cola en el mismo uso del peek, esta
    //funci�n no retornar� nada, solo imprimir� los valores en la consola.
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

