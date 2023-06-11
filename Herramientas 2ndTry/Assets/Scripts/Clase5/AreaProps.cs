using UnityEngine;

public class AreaProps : MonoBehaviour
{
    [Header("Area")]
    [SerializeField] private Color GizmoColor = Color.white;
    [SerializeField] private Vector2Int Size = Vector2Int.one;

    [Header("Props")]
    [SerializeField] private GameObject PropPrefab = null;
    [SerializeField, Range(1, 10)] private int Quantity = 5;

    [Header("Customization")]
    [SerializeField] private bool RotateWithParent = false;
    [SerializeField, Range(-10, 10)] private float VerticalGap = 0;

    public void Create()
    {
        Transform t = transform;

        t.Clean();

        Vector2 size = Size / 2;
        Vector3 position = new Vector3(0, VerticalGap, 0);
        Quaternion rotation = RotateWithParent ? t.rotation : Quaternion.identity;

        for (int i = 0; i < Quantity; i++)
        {
            position.x = Random.Range(-size.x, size.x);
            position.z = Random.Range(-size.y, size.y);
            Instantiate(PropPrefab, t.position + t.rotation * position, rotation, t);
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = GizmoColor;
        Gizmos.matrix = transform.localToWorldMatrix;
        Gizmos.DrawWireCube(Vector3.zero, new Vector3(Size.x, 0, Size.y));
    }
}
