using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroFade : MonoBehaviour {
    public CanvasGroup uiElement;
	// Use this for initialization
	void Start () {
        StartCoroutine(waiter());
	}
	
	void Update () {
	}

    IEnumerator waiter() {
        FadeOut();
        yield return new WaitForSeconds(3.5f);
        FadeIn();
    }

    public void FadeIn() {
        StartCoroutine(FadeCanvasGroup(uiElement, uiElement.alpha, 1, 2));
    }

    public void FadeOut()
    {
        StartCoroutine(FadeCanvasGroup(uiElement, uiElement.alpha, 0, 2));
    }

    public IEnumerator FadeCanvasGroup(CanvasGroup cg, float start, float end, float lerpTime = 2f) {
        float _timeStartedLerping = Time.time;
        float timeSinceStarted = Time.time - _timeStartedLerping;
        float percentageComplete = timeSinceStarted / lerpTime;
        while (true)
        {
            timeSinceStarted = Time.time - _timeStartedLerping;
            percentageComplete = timeSinceStarted / lerpTime;
            float currentValue = Mathf.Lerp(start, end, percentageComplete);
            cg.alpha = currentValue;
            if (percentageComplete >= 1) break;
            yield return new WaitForEndOfFrame();
        }
    }
}
