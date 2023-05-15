using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class comportamientoPelota : MonoBehaviour
{

    public void onColisionEnter(Collision collision) {
        /*if (collision.collider.name == "Pierde") {
            Destroy(this.gameObject);

        }*/

        if (collision.collider.name == "PF") {
            this.gameObject.GetComponent<Renderer>().material.color = Color.red;
        }
    }

    public void OnCollisionExit(Collision collision)
    {
        this.gameObject.GetComponent<Renderer>().material.color = Color.gray;
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
