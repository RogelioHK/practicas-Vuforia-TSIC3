using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    private Renderer mRenderer;
    private int colors;
    private bool enable;

    void Start()
    {
        colors = 0;
        enable = true;
        mRenderer = GetComponent<Renderer>();
    }

    void OnWillRenderObject()
    {
        // Cambia el color del objeto cada vez que es renderizado.
       if (colors == 0 && enable){
            mRenderer.material.color = Color.red;
            enable = false;
       }
       if(colors == 1 && enable){
            mRenderer.material.color = Color.green;
            enable = false;
       }
       if(colors == 2 && enable){
            mRenderer.material.color = Color.blue;
            enable = false;
       }
    }

    void OnBecameInvisible()
    {
        // Restaura el color del objeto cuando se vuelve invisible.
        if (colors == 0 && !enable){
            colors = 1;
            enable = true;
        }
        if(colors == 1 && !enable){
            colors = 2;
            enable = true;
        }
        if (colors == 2 && !enable){
            colors = 0;
            enable = true;
        }
    }
}
