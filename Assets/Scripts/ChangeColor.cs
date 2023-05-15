using System.Linq.Expressions;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    private Renderer model;
    private enum colors {blue, red, yellow, green};
    private colors actualColor = colors.red;

    void Start(){
        model = GetComponent<Renderer>();
    }

    void OnBecameInvisible(){
        //Habilita el cambio de color cuando el objeto está fuera de cámara
        switch (actualColor)
        {
            case colors.blue:
                model.material.color = Color.blue;
                actualColor = colors.red;
                break;
            case colors.red:
                model.material.color = Color.red;
                actualColor = colors.yellow;
                break;
            case colors.yellow:
                model.material.color = Color.yellow;
                actualColor = colors.green;
                break;
            case colors.green:
                model.material.color = Color.green;
                actualColor = colors.blue;
                break;
        };
    }
}