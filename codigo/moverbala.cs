using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moverbala : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Destroy (gameObject, 0.5f);
        
    }

    // Update is called once per frame
    void Update()
    {
        if(movimiento.direccionBala == true && movimiento.ParadireccionBala == false){
        transform.Translate (new Vector2(Time.deltaTime * 6,0));
        }
        if(movimiento.direccionBala == false  && movimiento.ParadireccionBala == true){
        transform.Translate (new Vector2(-Time.deltaTime * 6,0));

        }
        
    }
}
