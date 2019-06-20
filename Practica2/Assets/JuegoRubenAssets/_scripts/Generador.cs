using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Generador : MonoBehaviour
{

    public TextMeshProUGUI primerNumeroText;
    public TextMeshProUGUI resultadoText;
    public GameObject signo;
    public GameObject primerResultadoSprite;
    public GameObject resultadoSprite;
    public Sprite[] cupcakesSprites = new Sprite[9];
    public Sprite sumaSprite;
    public Sprite restaSprite;
    public int primerNumero, resultado, solucion;

    // Start is called before the first frame update
    void Start()
    {
        primerNumero = Random.Range(1, 9);
        resultado = Random.Range(1, 9);

        

        //Para que no nos salgan numeros separados por mas de 9
        while (resultado - primerNumero > 9)
        {
            resultado = Random.Range(1, 9);
        }

        primerNumeroText.text = primerNumero.ToString();
        resultadoText.text = resultado.ToString();

        //Ponemos el sprite que toque
        primerResultadoSprite.GetComponent<SpriteRenderer>().sprite = cupcakesSprites[primerNumero - 1];
        resultadoSprite.GetComponent<SpriteRenderer>().sprite = cupcakesSprites[resultado - 1];


        if (primerNumero < resultado)
        {
            signo.GetComponent<SpriteRenderer>().sprite = sumaSprite;
            solucion = resultado - primerNumero;
        }
        else
        {
            signo.GetComponent<SpriteRenderer>().sprite = restaSprite;
            solucion = primerNumero - resultado;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
