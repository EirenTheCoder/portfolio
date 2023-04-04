using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MichiNPC : MonoBehaviour
{
Vector3 Trans;
float speed=8;
void Start(){


Trans = transform.position;

}
    // Update is called once per frame
    void Update()
    {

transform.position+= new Vector3(0,speed*Time.deltaTime);


    }
}
