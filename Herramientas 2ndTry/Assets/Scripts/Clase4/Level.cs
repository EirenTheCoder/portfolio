using UnityEngine;

public class Level : MonoBehaviour
{
    public int experience = 0;

    public int Nivel => experience / 1000;
}
