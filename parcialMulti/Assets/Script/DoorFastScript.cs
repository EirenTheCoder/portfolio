using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class DoorFastScript : MonoBehaviour
{
 void OnCollisionEnter(Collision other)
    {
        if ( other.gameObject.name == "Player")SceneManager.LoadScene("Won");
    }
}
