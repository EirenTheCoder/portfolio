using UnityEngine;

public static class Utils
{
    public static void Clear(this Transform transform)
    {
        int childCount = transform.childCount;
        for (int i = 0; i < childCount; i++)
        {
            Object.DestroyImmediate(transform.GetChild(0).gameObject);
        }
    }

    public static Material CreateMaterial(Color color) => new Material(Shader.Find("Standard"))
    {
        color = color
    };

    public static Color GetRandomColor() => new Color(Random.value, Random.value, Random.value);
}

