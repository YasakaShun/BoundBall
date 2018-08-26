using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LengthGauge : MonoBehaviour
{
    private Slider slider;

	void Start()
    {
        slider = transform.Find("Slider").GetComponent<Slider>();

        Debug.Assert(slider != null);

        UpdateValue();
	}
	
	void Update()
    {
        UpdateValue();
        //transform.rotation = Camera.main.transform.rotation;
	}

    private void UpdateValue()
    {
        var slideCounter = MainSceneManager.Instance.SlideCounter;
        slider.value = Mathf.Clamp01(-1.0f * slideCounter.ScrollValue / slideCounter.GoalLength);
    }
}
