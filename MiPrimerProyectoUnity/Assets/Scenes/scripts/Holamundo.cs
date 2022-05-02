using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Holamundo : MonoBehaviour
{

    int x;

    // Start is called before the first frame update
    void Start()
    {
        _ = x - 0;
        print("algo paso");
     
        Debug.LogWarning("algo salio mal");
        Debug.LogError("algo salio muy mal");
    }
    // Update is called once per frame
    void Update()
    {
        //_ = x - x + 1;
        //Debug.Log(x);

        Debug.Log("hola desde ubdate");
    }
    private void FixedUpdate()
    {
        Debug.LogWarning("hola mundo dede fixed update cada 50fps");

    }
    private void LateUpdate()
    {
        Debug.Log("hola mundo desde late update");

    }
    private void OnEnable()
    {
        Debug.LogWarning("el objeto ha sido habilitado");
    }
    private void OnDisable()
    {
        Debug.LogWarning("el objeto ha sido deshabilitado");
    }
}
