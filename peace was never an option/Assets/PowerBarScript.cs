using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerBarScript : MonoBehaviour
{
    public float fillTime = 5.0f;

    private float fillAmount = 1.0f;
    private float timeLeft = 0.0f;

    void Start()
    {
        timeLeft = fillTime;
    }

    void Update()
    {
        timeLeft -= Time.deltaTime;

        if (timeLeft <= 0.0f)
        {
            fillAmount = 1.0f;
            if (GetComponent<CanvasGroup>().alpha != 0.0f)
            {
                GetComponent<CanvasGroup>().alpha = 0.0f;
            }
        }
        else
        {
            fillAmount = 1.0f - (timeLeft / fillTime);
        }

        GetComponent<UnityEngine.UI.Image>().fillAmount = fillAmount;
    }
}
