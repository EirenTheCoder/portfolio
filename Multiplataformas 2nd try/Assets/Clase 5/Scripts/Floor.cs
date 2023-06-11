using UnityEngine;

public class Floor : MonoBehaviour
{
    [SerializeField] private GameObject CubePrefab = null;
    [SerializeField, Range(1, 10)] private int Quantity = 5;

    public void Create()
    {
        // Clean
        Clean();

        // Create
        Transform t = transform;
        Vector3 position = new Vector3(0, -0.5f, 0);
        for (int i = 0; i < Quantity; i++)
        {
            position.x = i + 0.5f;
            // Rotated position = rotation * position // V3 = Q4 * V3
            Instantiate(CubePrefab, t.position + t.rotation * position, t.rotation, t);
        }
    }

    public void Clean() => transform.Clean();

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.matrix = transform.localToWorldMatrix;
        Gizmos.DrawWireCube(new Vector3(Quantity / 2f, -0.5f, 0), new Vector3(Quantity, 1, 1));
    }
}
