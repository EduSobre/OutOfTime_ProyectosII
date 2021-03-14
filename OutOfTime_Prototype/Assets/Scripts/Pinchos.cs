using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pinchos : MonoBehaviour
{

    bool activo = true;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void TurnoPincho()
    {
        if (activo == true)
        {
            GetComponent<BoxCollider>().enabled = false;
            activo = false;
        }
        else 
        {
            GetComponent<BoxCollider>().enabled = true;
            activo = true;
        }

    }
}
