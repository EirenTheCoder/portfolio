using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PrologueController : MonoBehaviour
{

    bool excecuted = false,hasFinished=false;

    public Animator anim;
    private void Update()
    {
        if (excecuted == false) startScene();
    
       hasFinished =  Utils.animHasFinished(anim,"blackScreen");

        if (hasFinished) //Scene jump
           Debug.Log("Jump to next scene") ;
        Debug.Log(hasFinished);
    }
    void startScene()
{

        if (Input.GetKeyDown(KeyCode.E)) { anim.SetTrigger("pressedE"); excecuted = true; }
        
    }


}
