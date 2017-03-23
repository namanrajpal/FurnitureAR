using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PersistantData : MonoBehaviour {


	public static PersistantData Instance;
	public Toggle tog;
	public static bool testing;
	public static int pnum;
	void Awake() {
		
		if(Instance)
		DestroyImmediate(gameObject);
		else
		{
			DontDestroyOnLoad(gameObject);
			Instance = this;
		}
	}

	// Use this for initialization
	void Start () {

		if (PlayerPrefs.HasKey ("pNum")) {
			pnum = PlayerPrefs.GetInt ("pNum");
			pnum++;
			PlayerPrefs.SetInt ("pNum", pnum);
		} else {
			PlayerPrefs.SetInt ("pNum", pnum);
		}
		tog = GameObject.FindGameObjectWithTag ("TestingToggle").GetComponent<Toggle>();
	}
	
	// Update is called once per frame
	void Update () {
		testing = tog.isOn;
	}

	public void LoadARscene()
	{
		SceneManager.LoadScene (1);
	}

	public void LoadImagescene()
	{

	}
}
