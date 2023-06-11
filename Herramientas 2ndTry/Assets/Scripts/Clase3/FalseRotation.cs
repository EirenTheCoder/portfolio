using UnityEngine;

public class FalseRotation : MonoBehaviour
{
    enum AXIS
    {
        X,
        Z
    }

    [SerializeField] private AXIS Axis = default;
    [SerializeField] private Vector2 Size = Vector2.one;

    private Vector3 _size = Vector3.zero;

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;

        if (Axis == AXIS.X)
        {
            _size.x = Size.x;
            _size.z = 0; 
        }
        else
        {
            _size.x = 0;
            _size.z = Size.x;
        }
        _size.y = Size.y;

        Gizmos.DrawWireCube(transform.position, _size);
    }
}
