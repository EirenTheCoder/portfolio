using UnityEngine;

public static class Utils
{
    public static void Clean(this Transform t)
    {
        int childCount = t.childCount;
        for (int i = 0; i < childCount; i++)
        {
            Object.DestroyImmediate(t.GetChild(0).gameObject);
        }
    }

    public static Material CreateMaterial(this Color color, string shader = "Standard") => new Material(Shader.Find(shader)) { color = color };
}
