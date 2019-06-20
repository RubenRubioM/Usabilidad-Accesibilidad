using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Eventos : MonoBehaviour
{
    public GameObject popUp;
    // Start is called before the first frame update
    void Start()
    {
        popUp.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void resetEstadisticas()
    {
        popUp.SetActive(true);
    }

    public void noReiniciar()
    {
        popUp.SetActive(false);
    }

    public void siReiniciar()
    {
        PlayerPrefs.SetInt("Fallos1", 0);
        PlayerPrefs.SetInt("Fallos2", 0);
        PlayerPrefs.SetInt("Aciertos1", 0);
        PlayerPrefs.SetInt("Aciertos2", 0);
        reiniciarJuego();
    }

    public void reiniciarJuego()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void volverAlMenu()
    {
        SceneManager.LoadScene(0);

    }
}
