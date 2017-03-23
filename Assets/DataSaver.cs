using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DataSaver : MonoBehaviour {

    ParticipantData p;
	StringBuilder sBuilder;
	PlayerPrefs prefs;
	public Text thankyouText;

	int pnum = 0;
	// Use this for initialization
	void Start () {
		sBuilder = new StringBuilder ();

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private string getPath()
    {
#if UNITY_EDITOR
        return Application.dataPath + "/CSV/" + "Saved_dataAR.csv";
#elif UNITY_ANDROID
        return Application.persistentDataPath+"Saved_data.csv";
#elif UNITY_IPHONE
        return Application.persistentDataPath+"/"+"Saved_data.csv";
#else
        return Application.dataPath +"/"+"Saved_data.csv";
#endif
    }

	
	public void SubmitRatings()
	{

		if (PersistantData.testing == false) {
			string delimiter = ",";
			Debug.Log ("Saving Ratings");
		sBuilder.AppendLine ("Participant No. "+PlayerPrefs.GetInt("pNum") + delimiter + "Study Results");

			foreach (KeyValuePair<string,float> rating in Rating.ratingsMap) {
				sBuilder.AppendLine (rating.Key + delimiter + rating.Value);
			}
			string filePath = getPath ();
			//StreamWriter outStream = System.IO.File.CreateText(filePath);
			//File.AppendText(filePath);
			File.AppendAllText (filePath, sBuilder.ToString ());
		}

		Invoke ("Exit", 1f);

	}


		public void Exit()
		{
		thankyouText.text = "Thank you";
		DestroyImmediate (PersistantData.Instance);
		SceneManager.LoadScene (0);

		}

}
