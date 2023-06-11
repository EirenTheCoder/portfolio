using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxinNPC : Boxer{
 
void Update(){

StartCoroutine("stateBoxer");

}


IEnumerator stateBoxer(){
int state = Random.Range(0,2);
switch(state){
case 0:
transform.position = Vector3.Lerp( transform.position, new Vector3(0,0,0), 0.1f);


break;
case 1:break;
}


yield return new WaitForSeconds(1f);

}

}