using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    public string url = "http://localhost:8080/RESTFullDataBase/webresources/com.screamforyourlife.data";

    int id = 7, highscore = 34,  decibel = 78;
    string username = "Jan";
	// Use this for initialization
    void Awake()
    {
        
        
    }

	void Start () {

        WWWForm form = new WWWForm();
        form.AddField("id", id);
        form.AddField("username", username);
        form.AddField("highscore", highscore);
        form.AddField("decibel", decibel);


        WWW www = new WWW(url, form);

        StartCoroutine(Get());
        StartCoroutine(WaitForRequest(www));
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    IEnumerator Get()
    {
        WWW www = new WWW(url);
        yield return www;
        Debug.Log(www.text);
    }

    IEnumerator WaitForRequest(WWW www)
    {
        yield return www;

        if (www.error == null)
        {
            Debug.Log("WWW ok: " + www.data);
        }
        else
        {
            Debug.Log("WWW error: " + www.error);
        }
    }
}
