using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ButtonScriptB : MonoBehaviour
{

    private Color cubeColor;
    public void AnotherOne(string color){

        switch(color){
            case "Red":
            cubeColor = Color.red;
            break;
            case "Purple":
            cubeColor = Color.magenta;
            break;
            case "Blue":
            cubeColor = Color.blue;
            break;
        }

         Material material = Utils.CreateMaterial(cubeColor);
         GameObject player = GameObject.Find("Player");
         Renderer renderer = player.GetComponent<Renderer>();
                if (renderer != null) renderer.material = material;
    
        StartCoroutine("eliminateUI");
    }

    public void NotFinished(int state){

        switch(state){
            case 0:
            SceneManager.LoadScene("SampleScene");
        break;
            case 1:
            Application.Quit();
            break;

        }
    }
    IEnumerator eliminateUI(){
        
        GameObject gO = GameObject.Find("Menu");
        gO.SetActive(false);

        
        yield return null;
        
    }
}