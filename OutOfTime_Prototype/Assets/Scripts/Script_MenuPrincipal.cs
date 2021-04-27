using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Script_MenuPrincipal : MonoBehaviour
{
    public InputField inputDia;
    public InputField inputMes;
    public InputField inputAño;

    void Start()
    {
        
    }

    void Update()
    {
        /*if ()
        {

        }*/

    }

    public void cargarEscena(string nombreNivel)
    {
        SceneManager.LoadScene(nombreNivel);
    }

}
