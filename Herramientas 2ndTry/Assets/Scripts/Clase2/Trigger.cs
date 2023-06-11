using UnityEngine;

public abstract class Trigger : SphereGizmo
{
    [Header("Trigger")]
    [SerializeField] private Transform Target = null;

    private float _radius2 = 0;
    private bool _inside = false;
    private Transform _transform = null;

    private void Awake()
    {
        _transform = transform;
        _radius2 = Radius * Radius;
    }

    protected virtual void Update()
    {
        float distance2 = (_transform.position - Target.position).sqrMagnitude;

        if (distance2 < _radius2)
        {
            if (_inside) return;
            _inside = true;

            OnEnter();
        }
        else
        {
            if (!_inside) return;
            _inside = false;

            OnExit();
        }
    }

    protected abstract void OnEnter(); // obligatorio
    protected virtual void OnExit() { } // opcional
}
