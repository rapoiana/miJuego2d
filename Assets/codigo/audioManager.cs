using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class audioManager : MonoBehaviour
{

    public AudioClip bandaSonora;
    
    public AudioClip clicMenu;

    public AudioClip lanzaBola;

    public AudioClip sonidoMuerte;

    public AudioClip sonidoBola;

    

    private AudioSource hiloMusical;
    private Scene escenaActual;

    public static GameObject scriptDuplicado;




    void Awake(){
        DontDestroyOnLoad(this.gameObject);

        if(scriptDuplicado == null){
            scriptDuplicado = this.gameObject;
        }
        else if(scriptDuplicado != null){
            Object.Destroy(this.gameObject);
        }

    }//fin de awake


   
    void Start()
    {
        hiloMusical = GetComponent<AudioSource>();
        hiloMusical.clip = bandaSonora;
        hiloMusical.loop = true;
        hiloMusical.Play();
        
    }//fin de start

   
    void Update()
    {
        escenaActual = SceneManager.GetActiveScene();
        if(escenaActual.name == "start"){
            hiloMusical.volume = 0.2f;
            hiloMusical.pitch = 1f;

        }
        else if(escenaActual.name == "miJuego2d"){
             hiloMusical.pitch = 1.3f;

        }
        
    }//fin de update


    public void clicBoton (){
        hiloMusical.PlayOneShot(clicMenu, 1f);
    }

    public void sonidoDead (){
        hiloMusical.PlayOneShot(sonidoMuerte, 1f);
    }

}
