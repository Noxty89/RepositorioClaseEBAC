using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TareaModulo7 : MonoBehaviour
{
    public GameObject GameObject_GO;
    public GameObject GameObject_GO2;
    public GameObject GameObject_GO3;
    public GameObject GameObject_GO4;// Hijo del GO3 Para utilizar sentencia or
    public GameObject GameObject_GO5;


    bool variable1;
    bool variable2;
    bool variable3;
     int valor1 = 0;
    int limiteInferior = -5;
    int limiteSuperior = 5;

    enum SeleccionColor
    {
        blanco,
        Negro,
    }
    // A B C   or  and  ((A or B) and C))    ((A or B) or C)
    // 1 1 1   1    1          1                    1 
    // 1 1 0   1    0          0                    1 
    // 1 0 1   1    0          1                    1
    // 1 0 0   0    0          0                    1 
    // 0 1 1   1    0          1                    1 
    // 0 1 0   1    0          0                    1
    // 0 0 1   0    0          0                    1
    // 0 0 0   0    0          0                    0


    // Start is called before the first frame update
    void Start()
    {
        variable1 = true;
        variable2 = false;
        variable3 = true;
       
    }
    private void FixedUpdate()
    {
        //cubo1
        valor1 = Random.Range(limiteInferior, limiteSuperior);
        Debug.Log(valor1);
        if (valor1 >= 0)
        {
            variable1 = true;
            variable2 = true;

        }
        else
        {
            variable1 = false;
            variable2 = false;
        }

        if (variable1 == true)
        {
            Debug.Log("Cubo1True");
            GameObject_GO.GetComponent<MeshRenderer>().material.color = Color.white;

        }
        else
        {
            Debug.Log("Cubo1false");
            GameObject_GO.GetComponent<MeshRenderer>().material.color = Color.black;
        }
        //cubo2
        if (valor1 >= 0)
        {
            variable1 = true;
            variable2 = true;

        }
        else
        {
            variable1 = false;
            variable2 = false;
        }

        if (variable2 == true)
        {
            Debug.Log("Cubo2True");
            GameObject_GO2.GetComponent<MeshRenderer>().material.color = Color.white;

        }
        else
        {
            Debug.Log("Cubo2false");
            GameObject_GO2.GetComponent<MeshRenderer>().material.color = Color.black;
        }
        //cubo3 con AND
        if (variable1 && variable2)
        {
            Debug.Log("Cubo3true");
            GameObject_GO3.GetComponent<MeshRenderer>().material.color = Color.white;

        }
        else
        {
            Debug.Log("Cubo3False");
            GameObject_GO3.GetComponent<MeshRenderer>().material.color = Color.black;
        }
        //cubo4 con or es copia del objeto 3 pero con OR
        if (variable1 || variable2)
        {
            Debug.Log("Cubo4true");
            GameObject_GO4.GetComponent<MeshRenderer>().material.color = Color.white;

        }
        else
        {
            Debug.Log("Cubo4False");
            GameObject_GO4.GetComponent<MeshRenderer>().material.color = Color.black;

        }
        //cubo5 combinando los resultados de el cubo3 y cubo 4
        if(variable1 && variable2 && variable3)
        {
            Debug.Log("Cubo5true");
            GameObject_GO5.GetComponent<MeshRenderer>().material.color = Color.white;

        }
        else
        {
            Debug.Log("Cubo5False");
            GameObject_GO5.GetComponent<MeshRenderer>().material.color = Color.black;
        }
    }
}





