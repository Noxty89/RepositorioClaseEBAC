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
        if (valor1 >= 0)
        {
            variable1 = true;
            variable2 = false;
        }
        else
            variable1 = false;
        variable2 = true;

    }



    private void FixedUpdate()
    {
        //cubo1
        valor1 = Random.Range(limiteInferior, limiteSuperior);
        Debug.Log(valor1);
        if (Mathf.Sign(valor1) == -1)// si el valor de "valor uno es negativo"entonces:
        {
            //cubo1
            variable1 = true;
            Debug.Log("cubo1True");
            GameObject_GO.GetComponent<MeshRenderer>().material.color = Color.white;

            //cubo2
            variable2 = false;
            Debug.Log("cubo2False");
            GameObject_GO2.GetComponent<MeshRenderer>().material.color = Color.black;
        }
        else // aqui entran los valores que sean positivos
        {
            //cubo1
            variable1 = false;
            Debug.Log("cubo1False");
            GameObject_GO.GetComponent<MeshRenderer>().material.color = Color.black;

            //cubo2
            variable2 = true;
            Debug.Log("cubo2True");
            GameObject_GO2.GetComponent<MeshRenderer>().material.color = Color.white;

        }
        // aqui es la operacion con AND cubo 3
        if (variable1 && variable2)
        {
            //cubo3            
            Debug.Log("cubo3true");
            GameObject_GO3.GetComponent<MeshRenderer>().material.color = Color.white;

        }
        else
        {            
            Debug.Log("cubo3False");
            GameObject_GO3.GetComponent<MeshRenderer>().material.color = Color.black;
            
            if (variable1 || variable2)
            {                           
                Debug.Log("cubo4true");
                GameObject_GO4.GetComponent<MeshRenderer>().material.color = Color.white;

            }
            else
            {                
                Debug.Log("cubo4False");
                GameObject_GO4.GetComponent<MeshRenderer>().material.color = Color.black;

                //cubo5
                if(variable1 && variable2 && variable1)
                {
                    Debug.Log("cubo5true");
                    GameObject_GO5.GetComponent<MeshRenderer>().material.color = Color.black;
                }

            }
        }
    }
}       





