using System.Collections;
using System.Collections.Generic;
using Unity.XR.OpenVR;
using UnityEngine;

public class Primer_Componente : MonoBehaviour 
{
    private void Awake()
    {
        MeshRenderer mr = GetComponent<MeshRenderer>();

        Color colorAleatorio = new Color(Random.value, Random.value, Random.value);
        mr.material.color = colorAleatorio;
    }
}
