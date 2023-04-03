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
      
transform.position = new Vector3(7.68f,-3.084666f );

}
}