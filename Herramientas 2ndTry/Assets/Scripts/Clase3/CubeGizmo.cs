using UnityEngine;

public class CubeGizmo : MonoBehaviour
{
    [Header("Gizmo")]
    [SerializeField] protected Vector3 Size = Vector3.one;
    [SerializeField] private Color GizmoColor = Color.white;

    private void OnDrawGizmos()
    {
        Gizmos.color = GizmoColor;
        Gizmos.DrawWireCube(transform.position, Size);
    }
}
