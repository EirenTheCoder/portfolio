using UnityEditor;
using UnityEngine;

public class Tools
{
    [MenuItem("Sergio/Hello &a")] // & Alt / % Ctrl / # Shift
    public static void SayHello() => Debug.Log($"Hello {SystemInfo.deviceName}");

    [MenuItem("Sergio/Duplicate")]
    public static void Duplicate()
    {
        GameObject go = Selection.activeGameObject;
        if (go) Object.Instantiate(go);
    }

    [MenuItem("Sergio/Destroy")]
    public static void Destroy()
    {
        GameObject go = Selection.activeGameObject;
        if (go) Object.DestroyImmediate(go);
    }

    [MenuItem("CONTEXT/Transform/Rotate 45°")]
    public static void Rotate45(MenuCommand menuCommand)
    {
        Transform t = menuCommand.context as Transform;
        t.rotation *= Quaternion.Euler(0, 45, 0);
    }

    [MenuItem("CONTEXT/Transform/Grow x 2")]
    public static void GrowX2(MenuCommand menuCommand)
    {
        Transform t = menuCommand.context as Transform;
        t.localScale *= 2;
    }
}
