using UnityEditor;
using UnityEngine;

public class TestWindow : EditorWindow
{
    private Color _color = Color.white;

    [MenuItem("Sergio/Colorizer")]
    public static void ShowWindow() => GetWindow<TestWindow>("Colorizer");

    private void OnGUI()
    {
        //GUILayout.Label("Hola", EditorStyles.boldLabel);

        _color = EditorGUILayout.ColorField("Color", _color);
        if (GUILayout.Button("Colorize"))
        {
            Material material = _color.CreateMaterial();

            GameObject[] selected = Selection.gameObjects;
            for (int i = 0; i < selected.Length; i++)
            {
                Renderer renderer = selected[i].GetComponent<Renderer>();
                if (renderer) renderer.material = material;
            }
        }
    }

    /*private void OnSelected(Action<GameObject> action)
    {
        GameObject[] selected = Selection.gameObjects;
        for (int i = 0; i < selected.Length; i++)
        {
            action(selected[i]);
        }
    }*/
}
