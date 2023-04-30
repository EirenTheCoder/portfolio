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
        Vector3 position = new Vector3(0, -0.5f, 0);
        for (int i = 0; i < Quantity; i++)
        {
            position.x = i + 0.5f;
            Instantiate(CubePrefab, position, Quaternion.identity, transform);
        }
    }

    public void Clean()
    {
        int childCount = transform.childCount;
        for (int i = 0; i < childCount; i++)
        {
            DestroyImmediate(transform.GetChild(0).gameObject);
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(transform.position + new Vector3(Quantity / 2f, -0.5f, 0), new Vector3(Quantity, 1, 1));
    }
}

