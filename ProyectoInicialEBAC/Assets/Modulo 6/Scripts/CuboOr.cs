using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuboOr : MonoBehaviour
{
    public GameObject prefabACrear;
    public CuboAwake cuboAwakeScript;
    public CuboUpdate cuboUpdateScript;
    GameObject cubo;
    public bool estado;
    MeshRenderer meshRenderer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cubo = Instantiate(prefabACrear);
        cubo.transform.position = transform.position;
        cubo.name = "Cubo_OR";
        meshRenderer = cubo.GetComponent<MeshRenderer>();
    }

    void FixedUpdate()
    {
        estado = cuboAwakeScript.estado || cuboUpdateScript.estado;
        if(estado)
        {
            meshRenderer.material.color = Color.white;
        }
        else
        {
            meshRenderer.material.color = Color.black;
        }
        Debug.Log("El cuboOR es:" + estado);
    }
}
