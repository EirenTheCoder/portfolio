using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{ 
    [SerializeField] private float speed = 5f;
    Vector3 Move;
      [SerializeField]private Joystick joy;
    [SerializeField] private GameObject joystickGO;
    
    #if UNITY_STANDALONE
  


    void Start() {


        joystickGO.SetActive(false);
    }
  void Update()
    {
        transform.position += new Vector3(Input.GetAxis("Horizontal")*Time.deltaTime*speed,0,Input.GetAxis("Vertical")*Time.deltaTime*speed);
        

   

   }


    #elif UNITY_ANDROID
void Awake(){

    joystickGO.SetActive(true);

}
void Update(){
   Move = new Vector3( joy.Horizontal, 0, joy.Vertical);


            transform.position += new Vector3(joy.Horizontal*Time.deltaTime*speed,0,joy.Vertical*Time.deltaTime*speed);





 
}
   }  
   
    #endif