using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MichiNPC : MonoBehaviour
{float speed = 0;
Vector3 Trans;
//float speed=8;
void Start(){


Trans = transform.position;
speed = Random.Range(5,9);
}


    // Update is called once per frame
    void Update()
    {

transform.position+= new Vector3(0,speed*Time.deltaTime);


    }

void OnBecameInvisible(){

Destroy(this.gameObject);

}
}
