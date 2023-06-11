using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    

    public  void ButtonPressed( int state){


        switch(state){
            case 0:

            Debug.Log("Pressed");
            GameObject ui = GameObject.Find("FirstUI");
            ui.SetActive(false);

                break;
            case 1:
            Application.Quit();
            break;
        }
    }


}
