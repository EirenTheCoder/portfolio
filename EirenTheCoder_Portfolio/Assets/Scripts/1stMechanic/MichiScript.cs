using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MichiScript : MonoBehaviour
{
    enum TypeOfBuilding {
    
    tally,shorty,temporal
    
    };
    private int a;
    private TypeOfBuilding building;
    [SerializeField] private float speed;
    // Update is called once per frame
    void Update()
    {
        
    }

    void reasoning() {

        switch (building) {

            case TypeOfBuilding.tally:
                

                
                
                break;
            case TypeOfBuilding.shorty:
                
                
                break;

            case TypeOfBuilding.temporal:


                break;

        };
    }
    void spawn() {
        
        a = Random.Range(0, 3);

        switch (a) {

            case 0:
                
                break;
            case 1:break;
            case 2:break;
        
        }
    
    
    }
    

}
