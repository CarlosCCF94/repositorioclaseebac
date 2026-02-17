using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Componente2 : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log(Componente1.miObjeto.name);
    }
    void Start()
    {
        
    }

}
