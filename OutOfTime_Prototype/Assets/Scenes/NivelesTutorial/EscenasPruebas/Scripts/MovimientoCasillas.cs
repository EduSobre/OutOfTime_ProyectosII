using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovimientoCasillas : MonoBehaviour
{
    public LayerMask layer;

    public Camera CamPresente;
    public Camera CamPasado;

    public string nivelSiguiente;
    public string nivelMuerte;

    public GameObject puerta1;
    public GameObject puerta2;
    public GameObject puerta3;
    public GameObject puerta4;

    public GameObject puertaLlave1;

    public GameObject llaveObjeto;
    public GameObject tesoroObjeto;

    public GameObject jugador1;
    public GameObject jugador2;

    public bool llave = false;
    public bool tesoro = false;

    public bool oculto = false;

    public bool noCambio = false;

    public bool adelante = true;
    public bool atras = true;
    public bool izquierda = true;
    public bool derecha = true;

    public bool estoyPresente = true;

    public GameObject laser1;
    public GameObject laser2;

    public Pinchos pinchos1;
    public Pinchos pinchos2;
    public Pinchos pinchos3;
    public Pinchos pinchos4;
    public Pinchos pinchos5;
    public Pinchos pinchos6;
    public Pinchos pinchos7;
    public Pinchos pinchos8;

    public Camara camara1;
    public Camara camara2;
    public Camara camara3;
    public Camara camara4;
    public Camara camara5;
    public Camara camara6;
    public Camara camara7;
    public Camara camara8;




    public List<Camara> camaraScript;
    public List<Pinchos> pinchoScript;



    void Start()
    {
        CamPresente.gameObject.SetActive(true);
        CamPasado.gameObject.SetActive(false);
    }

    void Update()
    {

        //Cambio entre cámaras y desactivar/activar trigger jugador
        if (Input.GetKeyDown("p") && noCambio == false && estoyPresente == true)
        {
            CamPresente.gameObject.SetActive(false);
            CamPasado.gameObject.SetActive(true);
            transform.Translate(50f, 0f, 0f);
            //jugador1.SetActive(true);
            //jugador2.SetActive(false);
            //GetComponent<CapsuleCollider>().enabled = true;
            estoyPresente = false;
                
        }
        if (Input.GetKeyDown("o") && noCambio == false && estoyPresente == false)
        {
            CamPresente.gameObject.SetActive(true);
            CamPasado.gameObject.SetActive(false);
            transform.Translate(-50f, 0f, 0f);
            //jugador1.SetActive(false);
            //jugador2.SetActive(true);
            //GetComponent<CapsuleCollider>().enabled = false;
            estoyPresente = true;
            

        }

        
        //Movimiento personajes y límites.
        if (Input.GetKeyDown("w") && adelante == true)
        {
            
            var ray = new Ray(this.transform.position, this.transform.forward);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 1, layer))
            {
                Debug.Log("NoMover");
            }
            else
            {
                transform.Translate(0f, 0f, 1f);

                pinchos1.TurnoPincho();
                pinchos2.TurnoPincho();
                pinchos3.TurnoPincho();
                pinchos4.TurnoPincho();
                pinchos5.TurnoPincho();
                pinchos6.TurnoPincho();
                pinchos7.TurnoPincho();
                pinchos8.TurnoPincho();

                camara1.TurnoCamara();
                camara2.TurnoCamara();
                camara3.TurnoCamara();
                camara4.TurnoCamara();
                camara5.TurnoCamara();
                camara6.TurnoCamara();
                camara7.TurnoCamara();
                camara8.TurnoCamara();

            }

        }
        if (Input.GetKeyDown("s") && atras == true)
        {

            var ray2 = new Ray(this.transform.position, -this.transform.forward);
            RaycastHit hit2;
            if (Physics.Raycast(ray2, out hit2, 1, layer))
            {
                Debug.Log("NoMover");
            }
            else
            {
                transform.Translate(0f, 0f, -1f);

                pinchos1.TurnoPincho();
                pinchos2.TurnoPincho();
                pinchos3.TurnoPincho();
                pinchos4.TurnoPincho();
                pinchos5.TurnoPincho();
                pinchos6.TurnoPincho();
                pinchos7.TurnoPincho();
                pinchos8.TurnoPincho();

                camara1.TurnoCamara();
                camara2.TurnoCamara();
                camara3.TurnoCamara();
                camara4.TurnoCamara();
                camara5.TurnoCamara();
                camara6.TurnoCamara();
                camara7.TurnoCamara();
                camara8.TurnoCamara();




            }

        }

        if (Input.GetKeyDown("a") && izquierda == true)
        {

            var ray3 = new Ray(this.transform.position, -this.transform.right);
            RaycastHit hit3;
            if (Physics.Raycast(ray3, out hit3, 1, layer))
            {
                Debug.Log("NoMover");
            }
            else
            {
                transform.Translate(-1f, 0f, 0f);

                pinchos1.TurnoPincho();
                pinchos2.TurnoPincho();
                pinchos3.TurnoPincho();
                pinchos4.TurnoPincho();
                pinchos5.TurnoPincho();
                pinchos6.TurnoPincho();
                pinchos7.TurnoPincho();
                pinchos8.TurnoPincho();

                camara1.TurnoCamara();
                camara2.TurnoCamara();
                camara3.TurnoCamara();
                camara4.TurnoCamara();
                camara5.TurnoCamara();
                camara6.TurnoCamara();
                camara7.TurnoCamara();
                camara8.TurnoCamara();

            }
        }
        if (Input.GetKeyDown("d") && derecha == true)
        {

            var ray4 = new Ray(this.transform.position, this.transform.right);
            RaycastHit hit4;
            if (Physics.Raycast(ray4, out hit4, 1, layer))
            {
                Debug.Log("NoMover");
            }
            else
            {
                transform.Translate(1f, 0f, 0f);

                pinchos1.TurnoPincho();
                pinchos2.TurnoPincho();
                pinchos3.TurnoPincho();
                pinchos4.TurnoPincho();
                pinchos5.TurnoPincho();
                pinchos6.TurnoPincho();
                pinchos7.TurnoPincho();
                pinchos8.TurnoPincho();

                camara1.TurnoCamara();
                camara2.TurnoCamara();
                camara3.TurnoCamara();
                camara4.TurnoCamara();
                camara5.TurnoCamara();
                camara6.TurnoCamara();
                camara7.TurnoCamara();
                camara8.TurnoCamara();


            }

        }
        
    }



    void OnTriggerEnter(Collider colision)
    {
        //Colisiones con pinchos
        if (colision.tag == "Pincho")
        {
            //SceneManager.LoadScene(nivelMuerte);
            Debug.Log("Pinchado");
           /*Provisional*/ SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        }
        //Colision con final
        if (colision.tag == "Final" && tesoro == true)
        {
            SceneManager.LoadScene(nivelSiguiente);
            Debug.Log("CargarSiguienteNivel");
        }
        //Colision con boton
        if (colision.tag == "Boton")
        {
            puerta1.layer = 0;
            puerta1.GetComponent<BoxCollider>().enabled = false;
            Debug.Log("DesactivadaPuerta");
            Destroy(puerta1);
        }
        if (colision.tag == "Boton2")
        {
            puerta2.layer = 0;
            puerta2.GetComponent<BoxCollider>().enabled = false;
            Debug.Log("DesactivadaPuerta");
            Destroy(puerta2);
        }
        if (colision.tag == "Boton3")
        {
            puerta3.layer = 0;
            puerta3.GetComponent<BoxCollider>().enabled = false;
            Debug.Log("DesactivadaPuerta");
            Destroy(puerta3);
        }
        if (colision.tag == "Boton4")
        {
            puerta4.layer = 0;
            puerta4.GetComponent<BoxCollider>().enabled = false;
            Debug.Log("DesactivadaPuerta");
            Destroy(puerta4);
        }
        //Colision con boton con necesidad de llave
        if (colision.tag == "BotonLlave" && llave == true)
        {
            puertaLlave1.layer = 0;
            puertaLlave1.GetComponent<BoxCollider>().enabled = false;
            Debug.Log("DesactivadaPuertaLlave");
            Destroy(puertaLlave1);

        }
        //Colision recoger llave
        if (colision.tag == "Llave")
        {            
            llave = true;
            Debug.Log("Llave recogida");
            Destroy(llaveObjeto);
        }
        if (colision.tag == "BotonLaser1")
        {            
            Debug.Log("LaserDesactivado");
            Destroy(laser1);
        }
        if (colision.tag == "BotonLaser2")
        {            
            Debug.Log("LaserDesactivado");
            Destroy(laser2);
        }
        //Colision laser
        if (colision.tag == "Laser")
        {
            SceneManager.LoadScene(nivelMuerte);
            Debug.Log("Lasereado");
            /*Provisional*/
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);


        }
        //recogidatesoro
        if (colision.tag == "Tesoro")
        {
            tesoro = true;
            Debug.Log("Tesoro recogida");
            Destroy(tesoroObjeto);
        }
        //Colision con Camara
        if (colision.tag == "Camara" && oculto == false)
        {
            SceneManager.LoadScene(nivelMuerte);
            Debug.Log("Enfocado con camara");
            /*Provisional*/
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        }

    }
    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "limiteDireccionDer")
        {
            adelante = false;
            atras = false;
            izquierda = false;               
        }
        if (other.tag == "limiteDireccionIzq")
        {
            adelante = false;
            atras = false;
            derecha = false;
        }
        if (other.tag == "limiteDireccionAdelante")
        {
            izquierda = false;
            atras = false;
            derecha = false;
        }
        if (other.tag == "limiteDireccionAtras")
        {
            adelante = false;
            izquierda = false;
            derecha = false;
        }

        if (other.tag == "Oculto")
        {
            oculto = true;
        }

        if (other.tag == "noCambio")
        {
            noCambio = true;
        }
        else
        {
            noCambio = false;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        adelante = true;
        atras = true;
        derecha = true;
        izquierda = true;

        oculto = false;

        noCambio = false;

    }
}




