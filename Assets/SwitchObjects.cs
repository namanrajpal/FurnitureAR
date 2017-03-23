using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwitchObjects : MonoBehaviour {

    List<GameObject> allObjects;
	static int numOfItems;
	static int curNum;
	public static string name;
	public Text indexText;
	public Button submitButton;
	// Use this for initialization
	void Start () {
        allObjects = new List<GameObject>();



        foreach(Transform child in transform)
        {
            allObjects.Add(child.gameObject);
            child.gameObject.SetActive(false);
        }

		numOfItems = allObjects.Count;
		curNum = 0;
		allObjects[curNum].SetActive(true);

	}
	
	// Update is called once per frame
	void Update () {
		name = allObjects [curNum].name;
		indexText.text = "Item no: " + (curNum+1) + "/" + numOfItems;

		if (Rating.ratingsMap.Count == numOfItems && curNum == (numOfItems-1))
			submitButton.gameObject.SetActive (true);
		else
			submitButton.gameObject.SetActive (false);


	}


	public void nextItem()
	{
		if (curNum < numOfItems-1) {
			curNum++;
			foreach (GameObject obj in allObjects) {
				obj.SetActive (false);
			}

			allObjects [curNum].SetActive (true);
		}


	}

	public void previousItem()
	{
		if (curNum > 0) {
			curNum--;
			foreach (GameObject obj in allObjects) {
				obj.SetActive (false);
			}

			allObjects [curNum].SetActive (true);

		}
	}

	void submitRating(int index,string name)
	{
		Debug.Log ("Submitting rating for "+ name +": "+ Rating.currItemRating);	

	}
}
