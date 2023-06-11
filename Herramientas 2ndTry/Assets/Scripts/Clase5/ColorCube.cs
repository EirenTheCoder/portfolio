using UnityEngine;

[ExecuteInEditMode, RequireComponent(typeof(Renderer))]
public class ColorCube : MonoBehaviour
{
    private void Awake() => GetComponent<Renderer>().material = Utils.CreateMaterial(Random.ColorHSV());
}