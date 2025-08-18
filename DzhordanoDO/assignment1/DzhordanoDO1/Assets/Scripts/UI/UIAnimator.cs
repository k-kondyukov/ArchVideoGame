using UnityEngine;

public class UIAnimator : MonoBehaviour
{
    [SerializeField] private CanvasGroup canvasGroup;
    public float fadeDuration = 0.5f;

    public void FadeIn() => StartCoroutine(Fade(0, 1));
    public void FadeOut() => StartCoroutine(Fade(1, 0));

    private System.Collections.IEnumerator Fade(float from, float to)
    {
        float elapsed = 0;
        while (elapsed < fadeDuration)
        {
            elapsed += Time.deltaTime;
            canvasGroup.alpha = Mathf.Lerp(from, to, elapsed / fadeDuration);
            yield return null;
        }
        canvasGroup.alpha = to;
    }
}