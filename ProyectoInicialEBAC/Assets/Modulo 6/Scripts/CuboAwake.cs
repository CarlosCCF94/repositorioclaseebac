using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuboAwake : MonoBehaviour 
{
    void Awake()
    {
        GameObject cubo = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cubo.transform.position = new Vector3(20, 1, 0);
        cubo.name = "Cubo_Awake";
    }    
}
