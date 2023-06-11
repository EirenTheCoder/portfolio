using UnityEngine;

public class Ghosts : Trigger
{
    [Header("Ghosts")]
    [SerializeField] private GameObject GhostPrefab = null;
    [SerializeField, Range(1, 10)] private int Quantity = 5;

    private int _velocity = 1;
    private float _gap = 0;

    protected override void OnEnter() => _velocity = 2;
    protected override void OnExit() => _velocity = 1;

    public void Create()
    {
        transform.Clean();

        float angle = 0;
        float da = 2 * Mathf.PI / Quantity;

        Vector3 position = Vector3.zero;
        for (int i = 0; i < Quantity; i++)
        {
            angle = da * i;
            position.x = Mathf.Cos(angle) * Radius;
            position.y = Mathf.Sin(angle) * Radius;
            Instantiate(GhostPrefab, position, Quaternion.identity, transform);
        }
    }

    protected override void Update()
    {
        base.Update();

        _gap += _velocity * Time.deltaTime;

        float angle = 0;
        float da = 2 * Mathf.PI / Quantity;

        Vector3 position = Vector3.zero;

        int childCount = transform.childCount;
        for (int i = 0; i < childCount; i++)
        {
            angle = da * i + _gap;
            position.x = Mathf.Cos(angle) * Radius;
            position.y = Mathf.Sin(angle) * Radius;
            transform.GetChild(i).position = position;
        }
    }
}
