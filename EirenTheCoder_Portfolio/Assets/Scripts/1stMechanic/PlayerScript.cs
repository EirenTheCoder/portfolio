using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerScript : MonoBehaviour
{ float isJump;
   [SerializeField] private float speed; 
    [SerializeField] private float jforce;
    [SerializeField] private Rigidbody2D catRB;
    [SerializeField] private float groundCheckDistance;
    [SerializeField]bool canJump;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()

    {


   

        
        if (Input.GetKeyDown(KeyCode.Space)&&canJump) isJump = 1;
            else { isJump = 0; }
            catRB.AddForce(new Vector2(0, isJump * jforce), ForceMode2D.Impulse);
          
     

        transform.position += new Vector3(Time.deltaTime*speed*Input.GetAxis("Horizontal"),0);

       
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag =="buildings") canJump = true;
       if(collision.gameObject.name =="Michi") Utils.changeScene("Menu");
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        canJump = false;
    }
    private void OnBecameInvisible()
    {
       Utils.changeScene("FirstHUD");
    }
}
