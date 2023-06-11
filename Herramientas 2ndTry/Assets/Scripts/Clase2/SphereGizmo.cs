using UnityEngine;

public class SphereGizmo : MonoBehaviour
{
    [Header("Gizmo")]
    [SerializeField, Range(1, 50)] protected int Radius = 1;
    [SerializeField] private Color GizmoColor = Color.white;

    private void OnDrawGizmos()
    {
        Gizmos.color = GizmoColor;
        Gizmos.DrawWireSphere(transform.position, Radius);
    }
}
