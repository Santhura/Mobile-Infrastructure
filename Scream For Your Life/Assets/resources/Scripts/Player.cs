using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class Player : MonoBehaviour {

    public string url = "http://localhost:8080/RESTFullDataBase/webresources/com.screamforyourlife.data"; //backend url


    // data that is used for the xml code for the backend
    private const string data = "data",
                        userId = "id",
                        highScore = "highscore",
                        username = "username",
                        decibel = "decibel";
   


   public int playerId = 7, playerHighscore = 0,  decibelNumber = 0;
   public string playerName = "Jan";

   public Text inputField;

   
// Use this for initialization
    void Start ()
    {
      /*  StartCoroutine(RequestAllScores());

        StartCoroutine(PostScore());

        StartCoroutine(RequestAllScores());*/
    }
    void FixedUpdate()
    {
        Debug.Log(playerId);
    }


    /// <summary>
    /// get the user name that is entered
    /// </summary>
    public void Username()
    {
        this.playerName = inputField.text;
        Debug.Log(this.playerName);
    }

    /// <summary>
    /// save the users name and give it a id to this user
    /// </summary>
    public void StartButton()
    {
        
        if (PlayerPrefs.HasKey("playerid"))
        {
            playerId = PlayerPrefs.GetInt("playerid");
            Debug.Log(playerId);
        }
        playerId += 1;
       
        PlayerPrefs.SetInt("playerid", playerId);
        StartCoroutine(PostScore());
    }

    /// <summary>
    /// get all the data from the backend
    /// </summary>
    /// <returns></returns>
    IEnumerator RequestAllScores()
    {
        WWW request = new WWW(url);
        yield return request;
        Debug.Log(request.text);
    }

    /// <summary>
    /// Post data from a player on the backend
    /// </summary>
    /// <returns></returns>
    IEnumerator PostScore()
    {
        string xmlString = "<" + data + "><" + decibel + ">" + decibelNumber + "</" + decibel +
                "><" + highScore + ">" + playerHighscore + "</" + highScore + "><" + userId + 
                ">" + playerId + "</" + userId + "><" + username + ">" + playerName + "</" + username + "></" + data + ">";

        byte[] xmlBytes = System.Text.Encoding.UTF8.GetBytes(xmlString);

        Dictionary<string, string> postHeader = new Dictionary<string, string>();

        postHeader.Add("Content-Type", "application/xml");
        postHeader.Add("Content-Length", xmlBytes.Length.ToString());
       
        WWW request = new WWW(url, xmlBytes, postHeader);

        yield return request;
        Debug.Log(request.text);
    }
}

//ID, get all scores (count), count+1. Insert at the end of the row.