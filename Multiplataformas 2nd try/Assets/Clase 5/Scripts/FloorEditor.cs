using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(Floor))]
public class FloorEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        if (GUILayout.Button("Create"))
        {
            Floor floor = target as Floor;
            floor.Create();
        }

        if (GUILayout.Button("Clean"))
        {
            Floor floor = target as Floor;
            floor.Clean();
        }
    }
}
