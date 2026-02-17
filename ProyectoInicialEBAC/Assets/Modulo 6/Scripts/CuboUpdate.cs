using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuboUpdate : MonoBehaviour
{

    // CuboUpdate Practica Modulo 6

    // public GameObject prefabACrear;

    // void Update()
    // {
    //     GameObject cubo = Instantiate(prefabACrear);
    //     cubo.transform.position = transform.position;
    //     cubo.name = "Cubo_Update";
    // }

    // Practica Modulo 7

    public GameObject prefabACrear;
    GameObject cubo;
    public bool estado;
    MeshRenderer meshRenderer;

    void Start()
    {
        cubo = Instantiate(prefabACrear);
        cubo.transform.position = transform.position;
        cubo.name = "Cubo_Update";
        meshRenderer = cubo.GetComponent<MeshRenderer>();
        estado = false;
    }

    void Update()
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
        Debug.Log("El cuboUpdate es:" + estado);
    }
}
    

