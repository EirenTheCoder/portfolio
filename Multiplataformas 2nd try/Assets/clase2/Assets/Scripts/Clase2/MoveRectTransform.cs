using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class MoveRectTransform : MonoBehaviour
{
    private CanvasScaler _canvasScaler = null;
    private RectTransform _rectTransform = null;

    private void Awake()
    {
        _rectTransform = transform as RectTransform;
        _canvasScaler = GetComponentInParent<CanvasScaler>();
    }

    public void MoveToUp() => MoveTo(Vector2.up * _canvasScaler.referenceResolution.y);
    public void MoveToDown() => MoveTo(Vector2.down * _canvasScaler.referenceResolution.y);

    public void MoveTo(Vector2 targetPosition) => StartCoroutine(Move(targetPosition));

    private IEnumerator Move(Vector2 targetPosition, float duration = 1.0f)
    {
        float currentTime = 0;
        Vector2 initPosition = _rectTransform.anchoredPosition;

        while (currentTime < duration)
        {
            float percent = currentTime / duration;
            Lerp(initPosition, targetPosition, percent);

            currentTime += Time.deltaTime;
            yield return null;
        }

        Lerp(initPosition, targetPosition, 1);
    }

    private void Lerp(Vector2 a, Vector2 b, float t) => _rectTransform.anchoredPosition = Vector2.Lerp(a, b, t);
}
