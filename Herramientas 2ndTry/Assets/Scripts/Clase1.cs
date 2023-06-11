using System;
using UnityEngine;

public class Clase1 : MonoBehaviour
{
    public enum CharacterType
    {
        TEACHER,
        WARRIOR,
        MAGE
    }

    [Serializable]
    public struct Character
    {
        public string name;
        public CharacterType type;
        [Range(0, 10)] public int life;
        [TextArea] public string description;
    }

#pragma warning disable CS0414 // no usar

    [Header("Examples")]
    public int publicInt = 0; // no usar
    private int _privateInt = 0;

    [HideInInspector] public int publicHidedInt = 0;
    [SerializeField] private int PrivateSerializedInt = 0;

    [Range(0, 10)] public int publicRangeInt = 0;
    [SerializeField, Range(0, 10)] private int PrivateRangeInt = 0; // OK

    [Space(20)]
    [SerializeField] private Character[] Characters = null;
}
