using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuboEnableDisable : MonoBehaviour 
{

    // Practica Modulo 6

    // public GameObject prefabACrear;

    // void OnEnable()
    // {
    //     GameObject cubo = Instantiate(prefabACrear);
    //     cubo.transform.position = transform.position;
    //     cubo.name = "Cubo_OnEnable";
    // }
    // void OnDisable()
    // {
    //     GameObject cubo = Instantiate(prefabACrear);
    //     cubo.transform.position = transform.position;
    //     cubo.name = "Cubo_OnDisable";
    // }

    // Practica Modulo 7

    public GameObject prefabACrear;
    public CuboAwake cuboAwakeScript;
    public CuboUpdate cuboUpdateScript;
    GameObject cubo;
    public bool estado;
    MeshRenderer meshRenderer;

    void Start()
    {
        cubo = Instantiate(prefabACrear);
        cubo.transform.position = transform.position;
        cubo.name = "Cubo_AND";
        meshRenderer = cubo.GetComponent<MeshRenderer>();
    }

    void FixedUpdate()
    {
        estado = cuboAwakeScript.estado && cuboUpdateScript.estado;
        if(estado)
        {
            meshRenderer.material.color = Color.white;
        }
        else
        {
            meshRenderer.material.color = Color.black;
        }
        Debug.Log("El cuboAND es:" + estado);
    }
}
