using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjerciciosVariablesMod8 : MonoBehaviour
{
    private const double v = 0;
    public GameObject GameObject_1;
    public GameObject GameObject_2;
    public GameObject GameObject_3;
    short mishort = 0;
    long milong = 2;
    int miint = 0;
    float mifloat = 0;
  
    

    // Start is called before the first frame update
    void Start()
    {
        //Convertir un numero flotante a string e imprimir 4 posiciones de precisión (decimales).
        char miCaracter1;
        string mystring = "134.4365790132273892";
        float value = float.Parse(mystring);
        Debug.Log(value);
        miCaracter1 = (char)(decimal)mystring[5];//3
        Debug.Log(miCaracter1);
        miCaracter1 = (char)(decimal)mystring[0];//1
        Debug.Log(miCaracter1);
        miCaracter1 = (char)(decimal)mystring[7];//5
        Debug.Log(miCaracter1);
        miCaracter1 = (char)(decimal)mystring[6];//6
        Debug.Log(miCaracter1);


        char micaracter;
        mifloat = (float)v;
        string floatastring = v.ToString(mystring);
        Debug.Log(floatastring);
        micaracter = floatastring[0];
        Debug.Log(floatastring);
        micaracter = floatastring[3];
        Debug.Log(floatastring);
        micaracter = floatastring[2];
        Debug.Log(floatastring);
        micaracter = floatastring[5];
        Debug.Log(floatastring);

        //Utilizar el método substring para separar su nombre completo en 3 strings y utilizar el 
        //método Split para separar su nombre completo en una lista de strings.

        string miNombre = "Eleazar Garcia Acosta";
        string Nombre = miNombre.Substring(0, 7);
        Debug.Log(Nombre);
        string PrimerApellido = miNombre.Substring(8, 13);
        Debug.Log(PrimerApellido);
        string SegundoApellido = miNombre.Substring(16, 21);
        Debug.Log(SegundoApellido);

        string miNombreSplit = "Eleazar;Garcia;Acosta";
        char delimitador = ';';
        string[] valores = miNombreSplit.Split(delimitador);
        Debug.Log(valores);

        //Crea dos variables string que guarden valores numéricos de miles, pasalas a tipos de datos 
        //numéricos utilizando la función tryParse, realiza una operación con ellas e imprime el
        //resultado.
        string uno = "1";
        string dos = "2";
        int resultado = 0;

        resultado = int.Parse(uno + dos);
        Debug.Log(resultado);

        // Imprimira: 12
        
        resultado = int.Parse(uno) + int.Parse(dos);
        Debug.Log(resultado);
        //Imprimira: 3
       
        //Crea un string con una oración, imprime sólo los caracteres que se encuentren en un índice 
        //par, por ejemplo “Hola Mundo”, solo deberá imprimir los caracteres: H,l, ,u,d. (recuerda para
        //qué sirve el uso del operador módulo).

        string MensajeSoloPares = "Eleazar";
        int solopares = MensajeSoloPares.Length;
        if (solopares % 2 != 0)
        {
            Debug.Log(solopares);
        }
        
        
        


        //Crea un string guarda, una oración en él y elimina los primeros 5 caracteres de este ya sea 
        //con la función substring, Split, o cualquier otro método disponible en la clase String.
        
            string CincoCaracteres = "Eleazar Garcia Acosta";
            string NuevoCinco = CincoCaracteres.Substring(6,20);
            Debug.Log($"Resultado:{NuevoCinco}");

               
         //Crea dos variables flotantes, has una operación entre ellas y obtén el resultado en un tipo de 
        //dato entero que requiera un casteo explícito.
        int a, b, c;
        a = 5;
        b = 2;

        c = (int)a / b;
        Debug.Log(c);

        //Utilizar un string y una sentencia switch y dependiendo de la palabra, el cubo deberá 
        //cambiar de color.
        
        string miString = "uno"; 
        string miString1 = miString;
        switch (miString1)
        {
            case "uno":
                Debug.Log(miString);
                GameObject_3.GetComponent<MeshRenderer>().material.color = Color.blue; 
                break;
            
        }
           




        
        



        

        
        
      
        




                       
                
              
    }

    // Update is called once per frame
    void Update()
    {
        //una variable de tipo entero que incremente su valor en cada frame
        mishort += 3;
        Debug.Log(mishort + " " + "Int Aumenta cada frame en 3");


    }
    private void FixedUpdate()
    {
       //El segundo de tipo de float que se incremente en cada FixedUpdate utilizando el operador *=.
                milong *= 3;
        Debug.Log(milong + " " + "float Se multiplica cada frame");

        //Utiliza el operador módulo para saber si un número es impar o par y con el resultado 
        //modificar el GO de color en cada FixedUpdate.

        miint = (int)mishort;
        int a, b;
        a = 1;
        b = 6;

        miint = Random.Range(a, b);
        if (miint % 2 == 0)
        {
            Debug.Log("El Numero" + miint + "Es Par");
            GameObject_1.GetComponent<MeshRenderer>().material.color = Color.white;
        }
        else
        {
            Debug.Log("El Numero" + miint + "Es Non");
            Color h = new Color(Random.value, Random.value, Random.value);
            GameObject_1.GetComponent<MeshRenderer>().material.color = h;
        }
    }

}
