using UnityEngine;
using System.Collections;
using System.Xml;
using System.Collections.Generic;
using UnityEngine.UI;
public class XMLParsing : MonoBehaviour
{
    private string _url = "http://localhost:8080/RESTFullDataBase/webresources/com.screamforyourlife.data";
    private string _xml;
    string text, text_name;
    public List<string> arrayData, arrayNames;
    public Text UI_Text;
    IEnumerator Start()
    {
        arrayData = new List<string>();
        arrayNames = new List<string>();
        // Start a download of the given URL
        WWW www = new WWW(_url);

        // Wait for download to complete
        yield return www;

        // get text
        _xml = www.text;

        // having XML here. Do with it whatever you want...
        XmlDocument doc = new XmlDocument();
        doc.LoadXml(_xml);
        foreach (XmlNode node in doc.DocumentElement.ChildNodes)
        {
            text = node.SelectSingleNode("highscore").InnerText;
            text_name = node.SelectSingleNode("username").InnerText;
            Debug.Log(text);
            arrayData.Add(text);
            arrayNames.Add(text_name);
            
        }

        arrayData.Reverse();
        arrayData.RemoveAt(0);
        arrayData.RemoveAt(0);
        arrayNames.Reverse();
        arrayNames.RemoveAt(0);
        arrayNames.RemoveAt(0);
        for (int i = 0; i < arrayData.Count; i++)
        {
            Text UI_Text = Instantiate(Resources.Load("Prefabs/UI_Text",typeof (Text))) as Text;
            UI_Text.transform.SetParent(GameObject.FindWithTag("ViewPort").transform);
            UI_Text.transform.localScale = new Vector3(1, 1, 1);

            UI_Text.transform.position = new Vector3(GameObject.FindWithTag("ViewPort").transform.position.x + 3, (GameObject.FindWithTag("ViewPort").transform.position.y - 2) - (i - 1), GameObject.FindWithTag("ViewPort").transform.position.z);
            UI_Text.text = arrayData[i];

            Text UI_Text_Name = Instantiate(Resources.Load("Prefabs/UI_Text", typeof(Text))) as Text;
            UI_Text_Name.transform.SetParent(GameObject.FindWithTag("ViewPort").transform);
            UI_Text_Name.transform.localScale = new Vector3(1, 1, 1);

            UI_Text_Name.transform.position = new Vector3(GameObject.FindWithTag("ViewPort").transform.position.x + 1, (GameObject.FindWithTag("ViewPort").transform.position.y -2) - (i - 1), GameObject.FindWithTag("ViewPort").transform.position.z);
            UI_Text_Name.text = arrayNames[i];
        }
    }
}