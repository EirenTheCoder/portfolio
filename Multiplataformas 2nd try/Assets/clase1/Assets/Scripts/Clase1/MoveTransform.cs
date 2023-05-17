using System.Collections;
using UnityEngine;

public class MoveTransform : MonoBehaviour
{
    private Transform _transform = null; // OJO
    [SerializeField] private float Duration = 10f;
    [SerializeField] private Vector3 TargetPosition = Vector3.zero;

    private void Awake() => _transform = transform;

    private IEnumerator Start()
    {
        float currentTime = 0;
        Vector3 initPosition = _transform.position;

        while (currentTime < Duration)
        {
            float percent = currentTime / Duration;
            Lerp(initPosition, TargetPosition, percent);

            currentTime += Time.deltaTime;
            yield return null;
        }

        Lerp(initPosition, TargetPosition, 1);
    }

    private void Lerp(Vector3 a, Vector3 b, float t) => _transform.position = Vector3.Lerp(a, b, t);
}
