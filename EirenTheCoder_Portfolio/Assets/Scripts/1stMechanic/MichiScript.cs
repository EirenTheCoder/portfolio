using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MichiScript : MonoBehaviour
{



   public  enum TypeOfBuilding {
    
    tally,shorty,temporal
    
    };
    private int a;
   public TypeOfBuilding building;
    
    
    [SerializeField] private float speed;
    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(Time.deltaTime*-speed,0);

    }

    private void OnBecameInvisible()
    {
        reasoning();
    }

    void reasoning() {
        int ran;
transform.position= new Vector3(12.05,-3.084666,0);
        ran = Random.Range(0, 2);
        switch (building) {

           case TypeOfBuilding.tally:

                if (ran == 0) { speed -= Random.Range(0, 3); }

                else { speed += Random.Range(0, 3); }
               break;
       case TypeOfBuilding.shorty:

                if (ran == 0) { speed -= Random.Range(2, 5); }

                else { speed += Random.Range(3, 6); }
                break;

  case TypeOfBuilding.temporal:

                if (ran == 0) { speed -= Random.Range(1, 3); }

                else { speed += Random.Range(1, 3); }
                break;

        };

        transform.position = new Vector3(14.0600004f, -3.75f, 0);
    }

    

}
