using UnityEngine;

public class TargetStalker : CubeGizmo
{
    [Header("Stalker")]
    [SerializeField] private Camera MyCamera = null;
    [SerializeField] private Transform TargetTransform = null;

    private Vector3 _targetPosition = Vector3.zero;
    private Vector3 _velocity = Vector3.zero;

    private Transform _transform = null;
    private Transform _cameraTransform = null;

    private void Awake()
    {
        _targetPosition.z = -10;

        _transform = transform;
        _cameraTransform = MyCamera.transform;
    }

    private void Update()
    {
        Vector2 limit = Size / 2;
        Vector2 view = new Vector2(MyCamera.orthographicSize * MyCamera.aspect, MyCamera.orthographicSize);

        _targetPosition.x = Mathf.Clamp(TargetTransform.position.x, _transform.position.x - limit.x + view.x, _transform.position.x + limit.x - view.x);
        _targetPosition.y = Mathf.Clamp(TargetTransform.position.y, _transform.position.y - limit.y + view.y, _transform.position.y + limit.y - view.y);

        _cameraTransform.position = Vector3.SmoothDamp(_cameraTransform.position, _targetPosition, ref _velocity, 0.25f);
    }
}
