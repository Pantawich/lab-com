using UnityEngine;
using System.Collections;

public class ScreenShake : MonoBehaviour
{
    private static ScreenShake instance;
    private Vector3 originalPos;

    void Awake()
    {
        instance = this;
    }

    void OnEnable()
    {
        originalPos = transform.localPosition;
    }

    public static void ShakeScreen(float duration, float magnitude)
    {
        if (instance != null)
        {
            instance.StartCoroutine(instance.Shake(duration, magnitude));
        }
    }

    private IEnumerator Shake(float duration, float magnitude)
    {
        float elapsed = 0.0f;

        while (elapsed < duration)
        {
            float x = Random.Range(-1f, 1f) * magnitude;
            float y = Random.Range(-1f, 1f) * magnitude;

            transform.localPosition = new Vector3(x, y, originalPos.z);

            elapsed += Time.deltaTime;
            yield return null; 
        }

        transform.localPosition = originalPos;
    }
}