using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Segundo_Componente : MonoBehaviour 
{
    private MeshRenderer mr;

    // Start is called before the first frame update

    void Start()
    {
        mr = GetComponent<MeshRenderer>();
    }
   
    // Update is called once per frame

    void Update()
    {
        Color colorAleatorio = new Color(Random.value, Random.value, Random.value);
        mr.material.color = colorAleatorio;
    }    
}
