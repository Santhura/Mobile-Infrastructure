using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    public string Level;
    private string url = "http://localhost:8080/RESTFullDataBase/webresources/com.screamforyourlife.data"; //backend url
    private int maxDbValue, maxPosY, playerId;
    private string playerName;
    public Text inputField;

    // data that is used for the xml code for the backend
    private const string data = "data",
                        userId = "id",
                        highScore = "highscore",
                        username = "username",
                        decibel = "decibel";

    public void LoadLevel()
    {
        Application.LoadLevel(Level);
    }

    //Submit score
    public void SubmitScore()
    {
        playerName = inputField.text;
        maxDbValue = (int)GameObject.FindGameObjectWithTag("Player").GetComponent<MicInputScript>().maxDbValue;
        maxPosY = (int)GameObject.FindGameObjectWithTag("Player").GetComponent<MicInputScript>().maxPosY;
        
        if(playerName == "")
        {
            Debug.Log("Ik ben leeg");
        }
        else if(playerName != "")
        {
            if (PlayerPrefs.HasKey("playerid"))
            {
                playerId = PlayerPrefs.GetInt("playerid");
                Debug.Log(playerId);
            }
            playerId += 1;

            PlayerPrefs.SetInt("playerid", playerId);
            StartCoroutine(PostScore(maxDbValue, maxPosY, playerId, playerName));
        }
    }

    /// <summary>
    /// Post data from a player on the backend
    /// </summary>
    /// <returns></returns>
    IEnumerator PostScore(int maxDbValue, int maxPosY, int playerId, string playerName)
    {
        string xmlString = "<" + data + "><" + decibel + ">" + maxDbValue + "</" + decibel +
                "><" + highScore + ">" + maxPosY + "</" + highScore + "><" + userId +
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
