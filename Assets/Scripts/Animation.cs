using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SmoothButtonHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public AnimationCurve rotationCurve;
    public AnimationCurve opacityCurve;

    private Quaternion originalRotation;
    private Color originalColor;

    private Coroutine currentCoroutine;

    private void Awake()
    {
        originalRotation = transform.rotation;
        originalColor = GetComponent<Image>().color;
    }

    private IEnumerator SmoothHover(bool hoverIn)
    {
        float time = 0f;
        float duration = 0.5f; // Adjust as desired
        Quaternion startRotation = transform.rotation;
        Color startColor = GetComponent<Image>().color;
        Color targetColor = hoverIn ? startColor : originalColor;

        while (time < duration)
        {
            time += Time.deltaTime;
            float curveValue = rotationCurve.Evaluate(time / duration);
            transform.rotation = startRotation * Quaternion.Euler(0f, 0f, curveValue);
            Color color = startColor;
            color.a = opacityCurve.Evaluate(time / duration);
            GetComponent<Image>().color = color;
            yield return null;
        }

        transform.rotation = hoverIn ? originalRotation : startRotation;
        GetComponent<Image>().color = targetColor;

        currentCoroutine = null;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (currentCoroutine != null)
        {
            StopCoroutine(currentCoroutine);
        }

        currentCoroutine = StartCoroutine(SmoothHover(true));
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (currentCoroutine != null)
        {
            StopCoroutine(currentCoroutine);
        }

        currentCoroutine = StartCoroutine(SmoothHover(false));
    }
}
