using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MovimientoJugador2 : MonoBehaviour
{
    public LayerMask layer;

    public Camera CamPresente;
    public Camera CamPasado;

    public string nivelSiguiente;
    public string nivelMuerte;

    public GameObject puerta1;
    public GameObject puertaLlave1;

    public GameObject llaveObjeto;
    public GameObject tesoroObjeto;

    public GameObject jugador1;
    public GameObject jugador2;

    public bool llave = false;
    public bool tesoro = false;

    public bool oculto = false;

    public bool adelante = true;
    public bool atras = true;
    public bool izquierda = true;
    public bool derecha = true;

    public Pinchos pinchosScript1;
    public Pinchos pinchosScript2;
    public Pinchos pinchosScript3;
    public Pinchos pinchosScript4;
    public Pinchos pinchosScript5;
    public Pinchos pinchosScript6;
    public Pinchos pinchosScript7;
    public Pinchos pinchosScript8;
    public Pinchos pinchosScript9;
    public Pinchos pinchosScript10;

    public Camara camaraScript1;
    public Camara camaraScript2;
    public Camara camaraScript3;
    public Camara camaraScript4;
    public Camara camaraScript5;
    public Camara camaraScript6;
    public Camara camaraScript7;
    public Camara camaraScript8;
    public Camara camaraScript9;
    public Camara camaraScript10;
    void Start()
    {
        
    }

    void Update()
    {

        // desactivar/activar trigger jugador
        if (Input.GetKeyDown("p"))
        {
            //CamPresente.gameObject.SetActive(true);
            //CamPasado.gameObject.SetActive(false);

            //jugador1.SetActive(true);
            //jugador2.SetActive(false);
            GetComponent<CapsuleCollider>().enabled = false;
        }
        if (Input.GetKeyDown("o"))
        {
            //CamPresente.gameObject.SetActive(false);
            //CamPasado.gameObject.SetActive(true);

            //jugador1.SetActive(false);
            //jugador2.SetActive(true);
            GetComponent<CapsuleCollider>().enabled = true;

        }
        //Movimiento personajes y límites.
        if (Input.GetKeyDown("w"))
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
                pinchosScript1.TurnoPincho();
                pinchosScript2.TurnoPincho();
                pinchosScript3.TurnoPincho();
                pinchosScript4.TurnoPincho();
                pinchosScript5.TurnoPincho();
                pinchosScript6.TurnoPincho();
                pinchosScript7.TurnoPincho();
                pinchosScript8.TurnoPincho();
                pinchosScript9.TurnoPincho();
                pinchosScript10.TurnoPincho();



                camaraScript1.TurnoCamara();
                camaraScript2.TurnoCamara();
                camaraScript3.TurnoCamara();
                camaraScript4.TurnoCamara();
                camaraScript5.TurnoCamara();
                camaraScript6.TurnoCamara();
                camaraScript7.TurnoCamara();
                camaraScript8.TurnoCamara();
                camaraScript9.TurnoCamara();
                camaraScript10.TurnoCamara();

            }

        }
        if (Input.GetKeyDown("s"))
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
                pinchosScript1.TurnoPincho();
                pinchosScript2.TurnoPincho();
                pinchosScript3.TurnoPincho();
                pinchosScript4.TurnoPincho();
                pinchosScript5.TurnoPincho();
                pinchosScript6.TurnoPincho();
                pinchosScript7.TurnoPincho();
                pinchosScript8.TurnoPincho();
                pinchosScript9.TurnoPincho();
                pinchosScript10.TurnoPincho();



                camaraScript1.TurnoCamara();
                camaraScript2.TurnoCamara();
                camaraScript3.TurnoCamara();
                camaraScript4.TurnoCamara();
                camaraScript5.TurnoCamara();
                camaraScript6.TurnoCamara();
                camaraScript7.TurnoCamara();
                camaraScript8.TurnoCamara();
                camaraScript9.TurnoCamara();
                camaraScript10.TurnoCamara();

            }

        }

        if (Input.GetKeyDown("a"))
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
                pinchosScript1.TurnoPincho();
                pinchosScript2.TurnoPincho();
                pinchosScript3.TurnoPincho();
                pinchosScript4.TurnoPincho();
                pinchosScript5.TurnoPincho();
                pinchosScript6.TurnoPincho();
                pinchosScript7.TurnoPincho();
                pinchosScript8.TurnoPincho();
                pinchosScript9.TurnoPincho();
                pinchosScript10.TurnoPincho();



                camaraScript1.TurnoCamara();
                camaraScript2.TurnoCamara();
                camaraScript3.TurnoCamara();
                camaraScript4.TurnoCamara();
                camaraScript5.TurnoCamara();
                camaraScript6.TurnoCamara();
                camaraScript7.TurnoCamara();
                camaraScript8.TurnoCamara();
                camaraScript9.TurnoCamara();
                camaraScript10.TurnoCamara();

            }
        }
        if (Input.GetKeyDown("d"))
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
                pinchosScript1.TurnoPincho();
                pinchosScript2.TurnoPincho();
                pinchosScript3.TurnoPincho();
                pinchosScript4.TurnoPincho();
                pinchosScript5.TurnoPincho();
                pinchosScript6.TurnoPincho();
                pinchosScript7.TurnoPincho();
                pinchosScript8.TurnoPincho();
                pinchosScript9.TurnoPincho();
                pinchosScript10.TurnoPincho();



                camaraScript1.TurnoCamara();
                camaraScript2.TurnoCamara();
                camaraScript3.TurnoCamara();
                camaraScript4.TurnoCamara();
                camaraScript5.TurnoCamara();
                camaraScript6.TurnoCamara();
                camaraScript7.TurnoCamara();
                camaraScript8.TurnoCamara();
                camaraScript9.TurnoCamara();
                camaraScript10.TurnoCamara();

            }

        }
    }
    void OnTriggerEnter(Collider colision)
    {
        //Colision con Pinchos
        if (colision.tag == "Pincho")
        {
            SceneManager.LoadScene(nivelMuerte);
            Debug.Log("Pinchado");
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
        }
        //Colision con boton con necesidad de llave
        if (colision.tag == "BotonLlave" && llave == true)
        {
            puertaLlave1.layer = 0;
            puertaLlave1.GetComponent<BoxCollider>().enabled = false;
            Debug.Log("DesactivadaPuertaLlave");
        }
        //Colision recoger llave
        if (colision.tag == "Llave")
        {
            llave = true;
            Debug.Log("Llave recogida");
            Destroy(llaveObjeto);
        }
        //Colision laser
        if (colision.tag == "Laser")
        {
            SceneManager.LoadScene(nivelMuerte);
            Debug.Log("Lasereado");

        }
        //recogidatesoto
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
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "limiteDireccionDer")
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
    }

    private void OnTriggerExit(Collider other)
    {
        adelante = true;
        atras = true;
        derecha = true;
        izquierda = true;

        oculto = false;
    }
}
