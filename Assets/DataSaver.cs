using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using UnityEngine;

public class DataSaver : MonoBehaviour {

    ParticipantData p;
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void Savecsv()
    {
        string delimiter = ",";
        Debug.Log("Saving File");
        string[][] output = new string[][]{
             new string[]{"Col 1 Row 1", "Col 2 Row 1", "Col 3 Row 1"},
             new string[]{"Col 1 Row 2", "Col2 Row 2", "Col3 Row 2","col4"}
         };
        int length = output.GetLength(0);
        StringBuilder sb = new StringBuilder();
        for (int index = 0; index < length; index++)
            sb.AppendLine(string.Join(delimiter, output[index]));
        string filePath = getPath();
        //StreamWriter outStream = System.IO.File.CreateText(filePath);
        //File.AppendText(filePath);
        File.AppendAllText(filePath, sb.ToString());
        

    }

    private string getPath()
    {
#if UNITY_EDITOR
        return Application.dataPath + "/CSV/" + "Saved_data.csv";
#elif UNITY_ANDROID
        return Application.persistentDataPath+"Saved_data.csv";
#elif UNITY_IPHONE
        return Application.persistentDataPath+"/"+"Saved_data.csv";
#else
        return Application.dataPath +"/"+"Saved_data.csv";
#endif
    }



}
