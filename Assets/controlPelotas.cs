using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlPelotas : MonoBehaviour
{
    public GameObject pelotas;
    public Transform posicionInicial;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Backspace)) {
            Instantiate(pelotas, posicionInicial);
        }
    }
}
