using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Spawner : MonoBehaviour
{
private GameObject miau;

  
    // Update is called once per frame
    void Update()
    {
        if(miau ==null){


            spawn();
        }
    }

void spawn(){

       for(int i=0;i<3;i++){

          miau =  Instantiate(Resources.Load<GameObject>("MichiNPC"),new Vector3(Random.Range(-8,9),-7.63f),Quaternion.identity);

        }


}


}
