using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuboAwake : MonoBehaviour 
{
    public GameObject prefabACrear;
    void Awake()
    {
        GameObject cubo = Instantiate(prefabACrear);
        cubo.transform.position = transform.position;
        cubo.name = "Cubo_Awake";
    }    
}
