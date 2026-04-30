using UnityEngine;

public class HoverAnimation : MonoBehaviour
{
    public float amplitude = 10f;  // i Canvas pixels
    public float hastighed = 2f;

    RectTransform rectTransform;
    Vector2 originalPosition;

    void Start()
    {
        rectTransform = GetComponent<RectTransform>();
        originalPosition = rectTransform.anchoredPosition;
    }

    void Update()
    {
        rectTransform.anchoredPosition = originalPosition + new Vector2(0, Mathf.Sin(Time.time * hastighed) * amplitude);
    }
}