using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxingPlayer : Boxer
{
    private void Start()
    {

        this.speed = 5;
        this.dmg = 2;
        this.life = 100;

    }
    private void Update()
    {
        Moverse();
    }
    void Moverse() {

        transform.position += new Vector3(Input.GetAxis("Horizontal")*Time.deltaTime*speed,Input.GetAxis("Vertical")*Time.deltaTime*speed);


    
    }
}
