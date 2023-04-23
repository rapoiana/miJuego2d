using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parallax : MonoBehaviour
{

    public GameObject Personaje;

    public GameObject FondoNubes;

    public GameObject FondoArboles;

    public GameObject ArbolGrande;

    public static string DireccionPersonaje;
    
    public float VelocidadNubes = 2f;
    public float VelocidadArboles = 5f;
    public float VelocidadArbolGrande =10f;


   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(DireccionPersonaje == "derecha"){
            VelocidadNubes -= 0.005f;
            VelocidadArboles -= 0.01f;
            VelocidadArbolGrande -= 0.02f;

        }
        if(DireccionPersonaje == "izquierda"){
            VelocidadNubes = 0.005f;
            VelocidadArboles = 0.01f;
            VelocidadArbolGrande = 0.02f;

            
        }
        if(DireccionPersonaje == "parado"){
            VelocidadNubes = 0f;
            VelocidadArboles = 0f;
            VelocidadArbolGrande = 0f;

        }



        FondoNubes.transform.Translate(VelocidadNubes*Time.deltaTime,0,0);
        FondoArboles.transform.Translate(VelocidadArboles*Time.deltaTime,0,0);
        ArbolGrande.transform.Translate(VelocidadArbolGrande*Time.deltaTime,0,0);
        
    }
}
