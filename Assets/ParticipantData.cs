using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticipantData{

    public string name;
	public string choice;

 

	ParticipantData (string name) {
        this.name = name;    
    }

	public void setChoice(string product)
	{
		choice = product;
	}
	
}
