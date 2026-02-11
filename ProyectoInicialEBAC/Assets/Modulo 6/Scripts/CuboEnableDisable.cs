using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuboEnableDisable : MonoBehaviour 
{
    public GameObject prefabACrear;
    void OnEnable()
    {
        GameObject cubo = Instantiate(prefabACrear);
        cubo.transform.position = transform.position;
        cubo.name = "Cubo_OnEnable";
    }
    void OnDisable()
    {
        GameObject cubo = Instantiate(prefabACrear);
        cubo.transform.position = transform.position;
        cubo.name = "Cubo_OnDisable";
    }
}
