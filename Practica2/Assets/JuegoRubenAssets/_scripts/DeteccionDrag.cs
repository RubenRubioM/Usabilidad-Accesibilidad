using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DeteccionDrag : MonoBehaviour
{
    public static int numDentro = 0;
    public TextMeshProUGUI textoNumero;
    public Generador generadorScript;
    public AudioManager audioManager;
    public GameObject popUp;
    public GameObject fade;

    private void Start()
    {
        numDentro = 0;
    }

    private void OnTriggerEnter2D(Collider2D _obj)
    {
        if (_obj.tag.Equals("ZonaPiruletas"))
        {
            numDentro++;
            textoNumero.text = numDentro.ToString();
        }


    }

    private void OnTriggerExit2D(Collider2D _obj)
    {
        if (_obj.tag.Equals("ZonaPiruletas"))
        {
            numDentro--;
            textoNumero.text = numDentro.ToString();
        }
    }

    public void comprobarVictoria()
    {

        if(generadorScript.solucion == numDentro)
        {
            Debug.Log("ACIERTO");
            popUp.SetActive(true);
            fade.SetActive(true);
            PlayerPrefs.SetInt("Aciertos1", PlayerPrefs.GetInt("Aciertos1", 0) + 1);

            audioManager.hasGanado();
            
        }
        else if(generadorScript.solucion>numDentro)
        {
            PlayerPrefs.SetInt("Fallos1", PlayerPrefs.GetInt("Fallos1",0) + 1);
            Debug.Log(PlayerPrefs.GetInt("Fallos"));
            Debug.Log("Mete mas");
            audioManager.meteMas();
        }else if (generadorScript.solucion < numDentro)
        {
            PlayerPrefs.SetInt("Fallos1", PlayerPrefs.GetInt("Fallos1",0) + 1);
            Debug.Log("Mete menos");
            audioManager.meteMenos();
        }
    }
}
