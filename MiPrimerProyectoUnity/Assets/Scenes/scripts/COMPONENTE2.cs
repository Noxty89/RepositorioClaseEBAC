using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class COMPONENTE2 : MonoBehaviour
{
    private void Awake()
    {
        

    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(COMPONENTE1.miObjeto.name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
