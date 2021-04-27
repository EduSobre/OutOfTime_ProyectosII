using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Script : MonoBehaviour
{
    public TMP_InputField meterTexto;
    public TextMeshProUGUI codigo;
    public TMP_InputField textoFinal;
    void Start()
    {
        meterTexto.text = "718741";

    }

    void Update()
    {
        int[] numeroRandomA = new int[] { 1, 2, 3, 4, 5, 6,7,8,9,10,11,12,13,14,15,16 };
        int numerosA = numeroRandomA[Random.Range(0, numeroRandomA.Length)];

        int[] numeroRandomB = new int[] { 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32 };
        int numerosB = numeroRandomB[Random.Range(0, numeroRandomA.Length)];

        string textoObtenido;
        textoObtenido = meterTexto.text;
        
        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (numerosA == 1)
            {
                textoObtenido = textoObtenido.Replace("a", "1|");
            }
            if (numerosA == 2)
            {
                textoObtenido = textoObtenido.Replace("a", "2|");
            }
            if (numerosA == 3)
            {
                textoObtenido = textoObtenido.Replace("a", "3|");
            }
            if (numerosA == 4)
            {
                textoObtenido = textoObtenido.Replace("a", "4|");
            }
            if (numerosA == 5)
            {
                textoObtenido = textoObtenido.Replace("a", "5|");
            }
            if (numerosA == 6)
            {
                textoObtenido = textoObtenido.Replace("a", "6|");
            }
            if (numerosA == 7)
            {
                textoObtenido = textoObtenido.Replace("a", "7|");
            }
            if (numerosA == 8)
            {
                textoObtenido = textoObtenido.Replace("a", "8|");
            }
            if (numerosA == 9)
            {
                textoObtenido = textoObtenido.Replace("a", "9|");
            }
            if (numerosA == 10)
            {
                textoObtenido = textoObtenido.Replace("a", "10|");
            }
            if (numerosA == 11)
            {
                textoObtenido = textoObtenido.Replace("a", "11|");
            }
            if (numerosA == 12)
            {
                textoObtenido = textoObtenido.Replace("a", "12|");
            }
            if (numerosA == 13)
            {
                textoObtenido = textoObtenido.Replace("a", "13|");
            }
            if (numerosA == 14)
            {
                textoObtenido = textoObtenido.Replace("a", "14|");
            }
            if (numerosA == 15)
            {
                textoObtenido = textoObtenido.Replace("a", "15|");
            }
            if (numerosA == 16)
            {
                textoObtenido = textoObtenido.Replace("a", "16|");
            }

            if (numerosB == 17)
            {
                textoObtenido = textoObtenido.Replace("b", "17|");
            }
            if (numerosB == 18)
            {
                textoObtenido = textoObtenido.Replace("b", "18|");
            }
            if (numerosB == 19)
            {
                textoObtenido = textoObtenido.Replace("b", "19|");
            }
            if (numerosB == 20)
            {
                textoObtenido = textoObtenido.Replace("b", "20|");
            }
            if (numerosB == 21)
            {
                textoObtenido = textoObtenido.Replace("b", "21|");
            }
            if (numerosB == 22)
            {
                textoObtenido = textoObtenido.Replace("b", "22|");
            }
            if (numerosB == 23)
            {
                textoObtenido = textoObtenido.Replace("b", "23|");
            }
            if (numerosB == 24)
            {
                textoObtenido = textoObtenido.Replace("b", "24|");
            }
            if (numerosB == 25)
            {
                textoObtenido = textoObtenido.Replace("b", "25|");
            }
            if (numerosB == 26)
            {
                textoObtenido = textoObtenido.Replace("b", "26|");
            }
            if (numerosB == 27)
            {
                textoObtenido = textoObtenido.Replace("b", "27|");
            }
            if (numerosB == 28)
            {
                textoObtenido = textoObtenido.Replace("b", "28|");
            }
            if (numerosB == 29)
            {
                textoObtenido = textoObtenido.Replace("b", "29|");
            }
            if (numerosB == 30)
            {
                textoObtenido = textoObtenido.Replace("b", "30|");
            }
            if (numerosB == 31)
            {
                textoObtenido = textoObtenido.Replace("b", "31|");
            }
            if (numerosB == 32)
            {
                textoObtenido = textoObtenido.Replace("b", "32|");
            }
            
            codigo.text = textoObtenido;

            textoFinal.text = textoObtenido;
        }






    }
    
    
}
