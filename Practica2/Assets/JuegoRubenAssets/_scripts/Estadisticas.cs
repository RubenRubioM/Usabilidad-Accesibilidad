using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Estadisticas : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI fallos1, fallos2, aciertos1, aciertos2,porcentaje1,porcentaje2;
    void Start()
    {
        fallos1.text = PlayerPrefs.GetInt("Fallos1").ToString();
        fallos2.text = PlayerPrefs.GetInt("Fallos2").ToString();
        aciertos1.text = PlayerPrefs.GetInt("Aciertos1").ToString();
        aciertos2.text = PlayerPrefs.GetInt("Aciertos2").ToString();

        //Porcentaje del primero
        if((float)PlayerPrefs.GetInt("Aciertos1")>=1 && (float)PlayerPrefs.GetInt("Fallos1") >= 1)
        {
            float por1 = (float)PlayerPrefs.GetInt("Aciertos1") / (float)PlayerPrefs.GetInt("Fallos1");
            Debug.Log(por1);
            por1 *= 100;
            porcentaje1.text = por1.ToString() + " %";
            if (por1 < 50)
            {
                porcentaje1.color = Color.red;
            }
            else
            {
                porcentaje1.color = Color.green;
            }
        }
        else
        {
            porcentaje1.text = "0 %";
            porcentaje1.color = Color.green;
        }

        //Porcentaje del segundo
        if ((float)PlayerPrefs.GetInt("Aciertos2") >= 1 && (float)PlayerPrefs.GetInt("Fallos2") >= 1)
        {
            float por2 = (float)PlayerPrefs.GetInt("Aciertos2") / (float)PlayerPrefs.GetInt("Fallos2");
            Debug.Log(por2);
            por2 *= 100;
            porcentaje2.text = por2.ToString() + " %";
            if (por2 < 50)
            {
                porcentaje2.color = Color.red;
            }
            else
            {
                porcentaje2.color = Color.green;
            }
        }
        else
        {
            porcentaje2.text = "0 %";
            porcentaje2.color = Color.green;
        }

    }

}
