using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MichiScript : MonoBehaviour
{
    private int a;
   [SerializeField] private float MAX_RANGE;
    [SerializeField] private float speed;
    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(Time.deltaTime*-speed,0);

        if (transform.position.x < MAX_RANGE) reasoning();


    }

   
 void reasoning() {
        int i = 0;
    transform.position = new Vector3(7+i,-3.084666f);
        i++;
    }

}
   
