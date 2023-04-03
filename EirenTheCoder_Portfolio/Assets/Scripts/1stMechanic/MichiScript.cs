using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MichiScript : MonoBehaviour
{



    private int a;
    
    
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
      
transform.position = new Vector3(9.98f,-4.184084f);

}
}