using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlPelotas : MonoBehaviour
{
    [SerializeField]
    private Transform location;
    [SerializeField]
    private GameObject prefabSphere;
    private GameObject sphere;
    // Start is called before the first frame update
    void Update()
    {
        if (sphere == null)
        //{
            sphere = Instantiate(prefabSphere, location) as GameObject;
            //sphere.transform.position = new Vector3((float)-0.47, (float)0.026, (float)-0.494);
        //}
    }
}
    // Update is called once per frame


    //void OnTriggerEnter(Collision collision)
    //{
    //    if (collision.gameObject.CompareTag("PuntoFinal"))
    //    {
    //        Destroy(currentSphere);

    //        currentSphere = Instantiate(spherePrefab, regenerationPosition, Quaternion.identity);
    //        // Configura el collider y el Rigidbody de la esfera regenerada
    //    }
    //}

    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.CompareTag("Pierde"))
    //    {
    //        Destroy(currentSphere);

    //        currentSphere = Instantiate(spherePrefab, regenerationPosition, Quaternion.identity);
    //    }
    //}
