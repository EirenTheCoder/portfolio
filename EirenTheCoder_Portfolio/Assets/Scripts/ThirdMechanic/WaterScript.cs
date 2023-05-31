using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterScript : MonoBehaviour
{
    private Agent agent;
    // Start is called before the first frame update
    void Start()
    {
     agent = GetComponent<Agent>();   
    }

    // Update is called once per frame
    void Update()
    {
        agent.addFlee(new FleeParameters{

            target = Input.mousePosition,
            range = 5f;
            weight= 1f;

        });
        agent.Update();
    }
}
