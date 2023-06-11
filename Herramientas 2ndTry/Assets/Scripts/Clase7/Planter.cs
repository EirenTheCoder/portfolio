using UnityEditor;
using UnityEngine;

public class Planter : EditorWindow
{
    private static float _verticalGap = 0;
    private static bool _alignToGround = true;
    private static bool _rotateRandomly = false;

    [MenuItem("Sergio/Planter/Show Tool")]
    public static void ShowWindow() => GetWindow<Planter>("Planter");

    private void OnGUI()
    {
        _verticalGap = EditorGUILayout.Slider("Vertical gap", _verticalGap, 0, 10);
        _alignToGround = EditorGUILayout.Toggle("Align to ground", _alignToGround);
        _rotateRandomly = EditorGUILayout.Toggle("Rotate Randomly", _rotateRandomly);

        if (GUILayout.Button("Plant")) Plant();
    }

    [MenuItem("Sergio/Planter/Plant #p")]
    public static void Plant()
    {
        GameObject go = Selection.activeGameObject;
        if (go)
        {
            Transform t = go.transform;

            Ray ray = new Ray(t.position, Vector3.down);
            if (Physics.Raycast(ray, out RaycastHit raycastHit, 100))
            {
                // Position
                t.position = raycastHit.point + Vector3.up * _verticalGap;

                // Rotation
                if (_alignToGround) t.up = raycastHit.normal;
                if (_rotateRandomly) t.rotation *= Quaternion.Euler(0, Random.Range(0, 360), 0);
            }
            else Debug.Log("No collision");
        }
        else Debug.Log("No selection");
    }
}
