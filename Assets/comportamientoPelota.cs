using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class comportamientoPelota : MonoBehaviour{
    private void OnTriggerEnter(Collider other){
        if (other.CompareTag("Pierde")){
            Destroy(this.gameObject);
            Debug.Log("PIERDE");
        }

        if (other.CompareTag("PuntoFinal")){
            this.gameObject.GetComponent<Renderer>().material.color = Color.green;
            Debug.Log("PUNTO FINAL");
        }
    }

    private void OnTriggerExit(Collider other){
        if (other.CompareTag("PuntoFinal")){
            this.gameObject.GetComponent<Renderer>().material.color = Color.red;
            Debug.Log("OUT PUNTO FINAL");
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
