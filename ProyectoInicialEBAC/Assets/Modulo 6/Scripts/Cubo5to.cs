using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubo5to : MonoBehaviour
{
    public GameObject prefabACrear;
    public CuboEnableDisable cuboANDScript;
    public CuboOr cuboORScript;
    GameObject cubo;
    public bool estado;
    MeshRenderer meshRenderer;

    // Usando AND
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cubo = Instantiate(prefabACrear);
        cubo.transform.position = transform.position;
        cubo.name = "Cubo_5to";
        meshRenderer = cubo.GetComponent<MeshRenderer>();
    }

    void FixedUpdate()
    {
        estado = cuboANDScript.estado && cuboORScript.estado;  //Usando OR estado = cuboANDScript.estado || cuboORScript.estado;
        if (estado)
        {
            meshRenderer.material.color = Color.white;
        }
        else
        {
            meshRenderer.material.color = Color.black;
        }
        Debug.Log("El Cubo5to es: " + estado);
    }
}
   