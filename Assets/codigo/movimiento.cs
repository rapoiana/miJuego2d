using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimiento : MonoBehaviour
{
  public static float Speed = 3.5f;

  public bool  ActivaSalto = true;

  public float Salto = 5f; 
  
  public Animator controlAnimacion;

  public static bool direccionBala = false;
  public static bool ParadireccionBala = false;

  void Awake(){
    DontDestroyOnLoad(gameObject);
  }
  




    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update() 
    {


      if(principalScript.Vida > 0){

     // GETAXIS
       float H = Input.GetAxis("Horizontal")*Speed;
       H *= Time.deltaTime;
       transform.Translate(H,0,0);

     // INPUTS CONTROL NO PREDEFINIDOS
      if(Input.GetKey(KeyCode.Space) && ActivaSalto == true   ){
        GetComponent<Rigidbody2D> ().AddForce (new Vector2 (0,Salto),ForceMode2D.Impulse); //salto
        ActivaSalto = false;
      }

      if(Input.GetKeyDown (KeyCode.RightArrow) || Input.GetKeyDown (KeyCode.D)){
        transform.localScale = new Vector3(1,1,1);
        controlAnimacion.SetBool("activacamina",true);
        direccionBala = true;
        ParadireccionBala = true;
        parallax.DireccionPersonaje = "derecha";



      }
     if(Input.GetKeyDown (KeyCode.LeftArrow) || Input.GetKeyDown (KeyCode.A)){
        transform.localScale = new Vector3(-1,1,1);
        controlAnimacion.SetBool("activacamina",true);
        direccionBala = false;
        parallax.DireccionPersonaje = "personaje";


      } 
     if(Input.GetKeyUp (KeyCode.RightArrow) || Input.GetKeyUp (KeyCode.D)){
        controlAnimacion.SetBool("activacamina",false);
        ParadireccionBala = false;
        parallax.DireccionPersonaje = "parado";
      }
      
      if(Input.GetKeyUp (KeyCode.LeftArrow) || Input.GetKeyUp (KeyCode.A)){
         controlAnimacion.SetBool("activacamina",false);
        ParadireccionBala = true;
        parallax.DireccionPersonaje = "parado";
      }
      }// final vida


    }// fin update
    
    void OnCollisionEnter2D (){
      ActivaSalto = true;
     }
}
   

