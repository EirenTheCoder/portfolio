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
    
    [SerializeField] private float speed = 1f;
    private float startingRotation = 0f;
    float angleInRadians = 0f;
    float angleInDegrees = 0f;
    float clampedAngle = 0f; 
    float currentAngle = 0f;
    float targetAngle = 0f;
   
    Quaternion targetRotation = Quaternion.identity;
    Quaternion smoothedRotation = Quaternion.identity;
      [SerializeField] private float maxRotation = 45f; // Maximum rotation in degrees
    [SerializeField] private float minRotation = -45f; // Minimum rotation in degrees


    private void Update()
    {
        switch (fighters)
        {
            case Fighters.Player:
         mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
         direction = mousePos - transform.position;
         angleInRadians = Mathf.Atan2(direction.y, 1f);
         angleInDegrees = Mathf.Rad2Deg * angleInRadians;
         targetAngle = angleInDegrees - startingRotation;
         clampedAngle = Mathf.Clamp(targetAngle, minRotation, maxRotation);

        // Smoothly rotate the object towards the target angle
         targetRotation = Quaternion.Euler(0f, 0f, clampedAngle);
         smoothedRotation = Quaternion.RotateTowards(transform.rotation, targetRotation, speed * Time.deltaTime);
        transform.rotation = smoothedRotation;
     
      break;
            case Fighters.Npc:

                StartCoroutine("FistNPC");

                break;


        }
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