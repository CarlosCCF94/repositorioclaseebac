using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuboEnableDisable : MonoBehaviour 
{
    void OnEnable()
    {
        GameObject cubo = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cubo.transform.position = new Vector3(40, 2, 0);
        cubo.name = "Cubo_OnEnable";
    }
    void OnDisable()
    {
        GameObject cubo = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cubo.transform.position = new Vector3(40, 1, 0);
        cubo.name = "Cubo_OnDisable";
    }
}
