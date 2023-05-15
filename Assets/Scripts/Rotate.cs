using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;
using Vuforia;

public class Rotate : MonoBehaviour{
    public Camera cameraAR;
    private bool isRotate = true;
    // Start is called before the first frame update
    void Start(){
        cameraAR = VuforiaBehaviour.Instance.GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update(){
        if (isRotate){
            transform.Rotate(Vector3.up * Time.deltaTime * 100);
        }

        if (Input.touchCount > 0){
            foreach (Touch touch in Input.touches){
                if (touch.phase == TouchPhase.Began){
                    Ray ray = cameraAR.ScreenPointToRay(Input.GetTouch(0).position);
                   // RaycastHit hit;
                    if (Physics.Raycast(ray, out _)){
                        isRotate = !isRotate;
                    }
                }
            }
        }
    }
}
