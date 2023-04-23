using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disparo : MonoBehaviour
{
    public GameObject bala;

    public GameObject gestorSonido;



    void Setup() {
        gestorSonido = GameObject.Find("AudioManager");
    }// fin setup

    
    void Start()
    {
        
    }

    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.X) == true){

            Instantiate (bala, new Vector2(transform.position.x, transform.position.y), transform.rotation);
            this.GetComponentInParent<AudioSource>().PlayOneShot(gestorSonido.GetComponent<audioManager>().lanzaBola, 1f);
            //fuenteSonido.PlayOneShot()

        }//if
             
      

    }//update

}//disparo
