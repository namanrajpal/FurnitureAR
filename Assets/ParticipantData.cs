using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticipantData{

    public string name;
    public Hashtable productRatings;

 

	ParticipantData (string name) {
        this.name = name;    
        productRatings = new Hashtable();
    }

    public void AddRating(string productName, int rating)
    {
        productRatings.Add(productName, rating);
    }
	
	
}
