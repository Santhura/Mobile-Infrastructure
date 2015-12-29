using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[System.Serializable]
public class Item
{
    private string name;
    private double highscore; 
}

public class HighscoreScript : MonoBehaviour {

    public List<Item> itemList;     //List for showing highscore as an item
    public string url = "http://localhost:8080/RESTFullDataBase/webresources/com.screamforyourlife.data";     //Url for retrieving data

    // Use this for initialization
    void Start () {
        PopulateList();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void PopulateList()
    {
        StartCoroutine(RequestAllHighScores());

    }

    IEnumerator RequestAllHighScores()
    {
        WWW request = new WWW(url);
        Debug.Log(request);
        yield return request;
    }
}
