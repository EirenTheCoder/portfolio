using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(Ghosts))]
public class GhostsEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();
        if (GUILayout.Button("Create Ghosts")) (target as Ghosts).Create();
    }
}
