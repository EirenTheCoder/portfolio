using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrologueController : MonoBehaviour
{

    bool excecuted = false;
    public Animator anim;
    private void Update()
    {
        if (excecuted == false) startScene();
        Debug.Log(excecuted);
    }
    void startScene()
{

        if (Input.GetKeyDown(KeyCode.E)) { anim.SetTrigger("pressedE"); excecuted = true; }
        
    }
   

}
