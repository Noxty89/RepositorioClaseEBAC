using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    public GameObject prefabcubo;
    public List<GameObject> listadecubos;
    public float factordeescalamiento;
    public int numcubos = 0;

    // Start is called before the first frame update
    void Start()
    {
        listadecubos = new List<GameObject>();

    }
    // Update is called once per frame
    void Update()
    {
        numcubos++;
        GameObject tempGameObject = Instantiate<GameObject>(prefabcubo);
        tempGameObject.name = "CuboNumero" + numcubos;
        Color c = new Color(Random.value, Random.value, Random.value);
        tempGameObject.GetComponent<MeshRenderer>().material.color = c;
        tempGameObject.transform.position = Random.insideUnitSphere;

        listadecubos.Add(tempGameObject);
        List<GameObject> ObjetosParaEliminar = new List<GameObject>();
        foreach (GameObject go in listadecubos) 
        {
            float scale = go.transform.localScale.x;
            scale *= factordeescalamiento;
            go.transform.localScale = Vector3.one * scale;

            if (scale <= 0.1) 
            {
                ObjetosParaEliminar.Add(go);
            }
            
        }
        foreach (GameObject go in ObjetosParaEliminar) 
        {
            listadecubos.Remove(go);
            Destroy(go);
        }

    }
}
