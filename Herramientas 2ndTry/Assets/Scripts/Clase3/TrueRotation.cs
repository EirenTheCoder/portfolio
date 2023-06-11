using UnityEngine;

public class TrueRotation : MonoBehaviour
{
    [SerializeField] private Vector3 Size = Vector3.one;

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.matrix = transform.localToWorldMatrix;
        Gizmos.DrawWireCube(Vector3.zero, Size);
    }
}
