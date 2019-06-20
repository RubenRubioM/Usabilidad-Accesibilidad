using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialInicial : MonoBehaviour
{
    public GameObject foto;
    // Start is called before the first frame update
    void Start()
    {
        foto.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            foto.SetActive(false);
            gameObject.GetComponent<AudioSource>().Stop();
        }
    }
}
