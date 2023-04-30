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
            Floor floor = (Floor)target;
            floor.Create();
        }

        if (GUILayout.Button("Clean"))
        {
            Floor floor = (Floor)target;
            floor.Clean();
        }
    }
}
