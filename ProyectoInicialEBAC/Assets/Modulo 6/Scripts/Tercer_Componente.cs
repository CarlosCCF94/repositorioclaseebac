using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tercer_Componente : MonoBehaviour
{
    private MeshRenderer mr;

    // Start is called before the first frame update   
    void Start()
    {
        mr = GetComponent<MeshRenderer>();
    }

    void FixedUpdate()
    {
        Color colorAleatorio = new Color(Random.value, Random.value, Random.value);
        mr.material.color = colorAleatorio;
    }
}
