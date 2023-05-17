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
    Vector3 lookPos = Vector3.zero;
    float angle = 0;
    private void Start()
    {

    }

    private void Update()
    {
        switch (fighters)
        {
            case Fighters.Player:

                mousePos = new Vector3(Input.mousePosition.x, Input.mousePosition.z, 10);
                lookPos = Camera.main.ScreenToWorldPoint(mousePos);
         

                break;
            case Fighters.Npc:



                break;


        }
    }
}