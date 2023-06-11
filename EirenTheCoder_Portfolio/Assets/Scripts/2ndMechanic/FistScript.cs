using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FistScript : MonoBehaviour
{
    enum Fighters
    {

        Player,
        Npc

    }

    [SerializeField] Fighters fighters;
    Vector3 mousePos = Vector3.zero;
    Vector3 direction = Vector3.zero;
    [SerializeField] private Camera cam;
    float angleInRadians = 0f;
       private void Update()
    {
        switch (fighters)
        {
            case Fighters.Player:
           
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0;
        direction = mousePos - transform.position;
        transform.up = direction;
             break;
            case Fighters.Npc:

                StartCoroutine("FistNPC");

                break;
        }
    //     if(Input.GetMouseButtonDown(0)){
    //         //Here the fist will punch!!
    //         transform.position = new Vector3(Mathf.Lerp(transform.position.x, transform.position.x+.1f, 0.1f), transform.position.y, transform.position.z);
    //     }
    }

    IEnumerator FistNPC()
    {
        int random = Random.Range(0, 3);

        switch(random){

            case 0: 
            
            transform.rotation = Quaternion .Euler(0f, 0f, 125f);
            break;

            case 1:
            
            transform.rotation = Quaternion .Euler(0f, 0f, 85f);
            
             break;

            case 2:
            
            transform.rotation = Quaternion .Euler(0f, 0f, 50f);
            
            break;

        }


        yield return new WaitForSeconds(7);
    }
}