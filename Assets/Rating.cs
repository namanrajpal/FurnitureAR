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
	public static float currItemRating;
	public static Dictionary<string,float> ratingsMap;
	public Canvas canvas;

	public Text ratingText;

    // Use this for initialization
	void Start () {
        starWidth = GetComponent<RectTransform>().rect.width;
		starWidth *= canvas.scaleFactor / 2;
		ratingsMap = new Dictionary<string, float>();
    }

	// Update is called once per frame
	void Update () {
		if (ratingsMap.ContainsKey (SwitchObjects.name)) {
			stars.fillAmount = (ratingsMap[SwitchObjects.name]*2f)/10f;
			ratingText.text = ratingsMap [SwitchObjects.name].ToString();
		} else {
			stars.fillAmount = 0f;
			ratingText.text = "0";
		}



	}
		

    public void OnPointerDown()
    {
        
		clickPos = transform.position;
		clickMousePos = Input.mousePosition;


		Debug.Log(clickPos + " " +clickMousePos);
        percentage = (clickMousePos.x - clickPos.x) /starWidth ;
		//percentage =  (float)System.Math.Truncate(10 * percentage) / 10;

		stars.fillAmount = percentage;
		percentage = percentage * 5;

		int p = (int)(percentage * 10);
		Debug.Log (p);
		float pp = p / 10f;
		currItemRating = pp;

		/*if (percentage > 0f && percentage <= 0.2f) {
			stars.fillAmount = 0.2f;
			currItemRating = 1;
		}
		if (percentage > 0.2f && percentage <= 0.4f){
			stars.fillAmount = 0.4f;
			currItemRating = 2;
		}
		if (percentage > 0.4f && percentage <= 0.6f){
			stars.fillAmount = 0.6f;
			currItemRating = 3;
		}
		if (percentage > 0.6f && percentage <= 0.8f){
			stars.fillAmount = 0.8f;
			currItemRating = 4;
		}
		if (percentage > 0.8f && percentage <= 1f){
            stars.fillAmount = 1f;
			currItemRating = 5;
		}*/

		ratingsMap[SwitchObjects.name]= Rating.currItemRating;

		foreach (KeyValuePair<string,float> rating in ratingsMap) {
			Debug.Log (rating.Key + " " + rating.Value);
		}
    }



}
