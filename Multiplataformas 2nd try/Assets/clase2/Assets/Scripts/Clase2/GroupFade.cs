using System.Collections;
using UnityEngine;

[RequireComponent(typeof(CanvasGroup))]
public class GroupFade : MonoBehaviour
{
    private CanvasGroup _canvasGroup = null;

    private void Awake() => _canvasGroup = GetComponent<CanvasGroup>();

    public void FadeOut() => StartCoroutine(Fade());

    private IEnumerator Fade()
    {
        WaitForSeconds wait = new WaitForSeconds(0.1f);

        for (float f = 1f; f >= 0; f -= 0.1f)
        {
            _canvasGroup.alpha = f;
            yield return wait;
        }
        _canvasGroup.alpha = 0;
    }
}
