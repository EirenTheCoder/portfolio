using System.Collections;
using UnityEngine;

public class Directivas : MonoBehaviour
{
    [SerializeField] private Material Red = null;
    [SerializeField] private Material Blue = null;

    private void Start()
    {
        Renderer renderer = GetComponent<Renderer>();

#if UNITY_STANDALONE && !UNITY_EDITOR
        renderer.material = Red;
#else
        renderer.material = Blue;
#endif

        StartCoroutine(Fade(renderer));
    }

    private IEnumerator Fade(Renderer renderer)
    {
        WaitForSeconds wait = new WaitForSeconds(0.5f);

        for (float f = 1f; f >= 0; f -= 0.1f)
        {
            SetRendererAlpha(renderer, f);
            yield return wait;
        }
        SetRendererAlpha(renderer, 0);
    }

    private void SetRendererAlpha(Renderer renderer, float alpha)
    {
        Color color = renderer.material.color;
        color.a = alpha;
        renderer.material.color = color;
    }
}
