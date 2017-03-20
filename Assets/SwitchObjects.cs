using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchObjects : MonoBehaviour {

    List<GameObject> allObjects;
	// Use this for initialization
	void Start () {
        allObjects = new List<GameObject>();
        foreach(Transform child in transform)
        {
            allObjects.Add(child.gameObject);
            child.gameObject.SetActive(false);
        }

        allObjects[0].SetActive(true);

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
