using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuboUpdate : MonoBehaviour
{

    // Update is called once per frame

    void Update()
    {
        GameObject cubo = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cubo.transform.position = new Vector3(30, 1, 0);
        cubo.name = "Cubo_Update";
    }
}
