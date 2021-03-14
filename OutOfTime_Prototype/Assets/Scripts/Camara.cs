using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour
{

    public bool posicion1 ;
    public bool posicion2 ;
    public bool posicion3 ;

    public GameObject Posicion1;
    public GameObject Posicion2;
    public GameObject Posicion3;
    void Start()
    {
        
    }

    void Update()
    {        
        
    }
    public void TurnoCamara()
    {
        if (posicion1 == true)
        {
            
            Posicion1.SetActive(false);
            Posicion2.SetActive(true);

            posicion2 = true;
            posicion1 = false;
        }
        else if (posicion2 == true)
        {
            Posicion2.SetActive(false);
            Posicion3.SetActive(true);

            posicion3 = true;
            posicion2 = false;
        }
        else if (posicion3 == true)
        {
            Posicion3.SetActive(false);
            Posicion1.SetActive(true);            

            posicion1 = true;
            posicion3 = false;
        }

    }
}
