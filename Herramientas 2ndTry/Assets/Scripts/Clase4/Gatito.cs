using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gatito : MonoBehaviour
{
    public int experience;
    public int Level {

        get { return experience / 750; }
    }
}
