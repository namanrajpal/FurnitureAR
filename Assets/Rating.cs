using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Rating : MonoBehaviour {
    Vector3 clickPos;
    Vector3 clickMousePos;
    float percentage;
    public Image stars;
    float starWidth;
    
    // Use this for initialization
	void Start () {
        starWidth = GetComponent<RectTransform>().rect.width;

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnPointerDown()
    {
        //mouseDown = true;
        clickPos = transform.position;
        clickMousePos = Input.mousePosition;
        Debug.Log("clickPos = " + clickPos + "   clickMousePos = " + clickMousePos);
        percentage = (clickMousePos.x - clickPos.x) /starWidth ;
        //stars.fillAmount = percentage;

        if (percentage > 0f && percentage <= 0.2f)
            stars.fillAmount = 0.2f;
        if (percentage > 0.2f && percentage <= 0.4f)
            stars.fillAmount = 0.4f;
        if (percentage > 0.4f && percentage <= 0.6f)
            stars.fillAmount = 0.6f;
        if (percentage > 0.6f && percentage <= 0.8f)
            stars.fillAmount = 0.8f;
        if (percentage > 0.8f && percentage <= 1f)
            stars.fillAmount = 1f;


    }
}
