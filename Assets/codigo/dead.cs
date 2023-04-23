using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dead : MonoBehaviour

{
    public GameObject Personaje;

    public GameObject gestorSonido;

    private static int contadorTrigger;

    // Start is called before the first frame update
    void Start()
    {
        contadorTrigger = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(contadorTrigger);
        
    }

    void OnTriggerEnter2D (){
        if(contadorTrigger <= 0){
            //añadir efecto
            Debug.Log("EfectoEco");
            contadorTrigger++;

        }
        else if(contadorTrigger >= 1){
            Debug.Log("HAS MUERTO!!!");
       // gestorSonido.GetComponent<AudioSource>().PlayOneShot(gestorSonido.GetComponent<audioManager>().sonidoMuerte, 1f);
        gestorSonido.GetComponent<audioManager>().sonidoDead();
        principalScript.Vida--;
        Personaje.transform.position = new Vector2(0.74f,-2.22f);
        contadorTrigger++;

        }
    
    }//fin trigger

     void OnTriggerExit2D(){
            contadorTrigger--;
        }
}
