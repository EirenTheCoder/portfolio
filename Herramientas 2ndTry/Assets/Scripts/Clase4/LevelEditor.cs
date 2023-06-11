using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(Level))]
public class LevelEditor : Editor
{
    private Color color = Color.white;

    public override void OnInspectorGUI()
    {
        //DrawDefaultInspector();

        Level script = target as Level;

        script.experience = EditorGUILayout.IntSlider("Experience", script.experience, 0, 10000);
        EditorGUILayout.LabelField("Test", script.Nivel.ToString());

        EditorGUILayout.Space();

        if (script.Nivel > 5) EditorGUILayout.HelpBox("Alto nivel", MessageType.Info);

        // Color
        color = EditorGUILayout.ColorField("Color", color);

        /*EditorGUILayout.HelpBox("Hola", MessageType.None);
        EditorGUILayout.HelpBox("Información", MessageType.Info);
        EditorGUILayout.HelpBox("Alerta", MessageType.Warning);
        EditorGUILayout.HelpBox("Error", MessageType.Error);*/
    }
}
