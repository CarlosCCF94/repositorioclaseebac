using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuboAwake : MonoBehaviour 
{

    // Practica Modulo 6 

    // public GameObject prefabACrear;

    // void Awake()
    // {
    //     GameObject cubo = Instantiate(prefabACrear);
    //     cubo.transform.position = transform.position;
    //    cubo.name = "Cubo_Awake";
    // }

    // Practica Modulo 7

    public GameObject prefabACrear;
    GameObject cubo;
    public bool estado;
    MeshRenderer meshRenderer;
    void Awake()
    {
        GameObject cubo = Instantiate(prefabACrear);
        cubo.transform.position = transform.position;
        cubo.name = "Cubo_Awake";
        meshRenderer = cubo.GetComponent<MeshRenderer>();
        estado = false;
    }
    void FixedUpdate()
    {
        estado = !estado;
        if (estado)
        {
            meshRenderer.material.color = Color.white;
        }
        else
        {
            meshRenderer.material.color = Color.black;
        }
        Debug.Log("El cuboAwake es: " + estado);
    }
}
