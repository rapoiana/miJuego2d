using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemigo : MonoBehaviour
{
    public string clonBala;

    float SpeedEnemigo = 0.6f; //IA

    float DistanciaPlayer = 4f; //IA

    Vector3 posicionInicial; //IA

    public GameObject player; //IA 

    public GameObject gestorSonido;

    private AudioSource emisorEnemigo;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player"); //IA
        posicionInicial = transform.position; //IA 
        emisorEnemigo = GetComponent<AudioSource>();
        
    }

    void Update()
    {
        Vector3 Objetivo = posicionInicial; //IA
        float distancia = Vector3.Distance(player.transform.position, transform.position); //IA

        if(distancia < DistanciaPlayer){
            Objetivo = player.transform.position; //IA
        }
        float Velocidadfija = SpeedEnemigo*Time.deltaTime; //IA

        transform.position = Vector3.MoveTowards(transform.position,Objetivo,Velocidadfija); //IA

        Debug.DrawLine(transform.position,Objetivo,Color.green); //IA se visualiza dentro de la escena

    }
       


    void OnTriggerEnter2D(Collider2D col){

        clonBala = col.gameObject.name;

        if(clonBala == "balafuego(Clone)"){
            emisorEnemigo.PlayOneShot( gestorSonido.GetComponent<audioManager>().sonidoBola, 1f);
            principalScript.Enemigos++;
            Destroy(this.gameObject, 0.3f);
        }

        if(clonBala == "personanje"){     
        principalScript.Vida--;
        player.transform.position = new Vector2(0.74f,-2.22f);
        gestorSonido.GetComponent<audioManager>().sonidoDead();

        }



    }


   
    
    
}
