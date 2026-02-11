using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuboUpdate : MonoBehaviour
{
    public GameObject prefabACrear;

    // Update is called once per frame

    void Update()
    {
        GameObject cubo = Instantiate(prefabACrear);
        cubo.transform.position = transform.position;
        cubo.name = "Cubo_Update";
    }
}
