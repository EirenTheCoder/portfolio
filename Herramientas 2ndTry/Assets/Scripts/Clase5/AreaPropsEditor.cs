using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(AreaProps))]
public class AreaPropsEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        EditorGUILayout.Space();
        if (GUILayout.Button("Create Props")) (target as AreaProps).Create();
    }
}
