using UnityEngine;
using System.Collections;
using System.Xml;
using System.Collections.Generic;
using UnityEngine.UI;
public class XMLParsing : MonoBehaviour
{
    private string _url = "http://localhost:8080/RESTFullDataBase/webresources/com.screamforyourlife.data";
    private string _xml;
    string text;


    IEnumerator Start()
    {
        // Start a download of the given URL
        WWW www = new WWW(_url);

        // Wait for download to complete
        yield return www;

        // get text
        _xml = www.text;
        Debug.Log("Hoi");

        // having XML here. Do with it whatever you want...
        XmlDocument doc = new XmlDocument();
        doc.LoadXml(_xml);
        foreach (XmlNode node in doc.DocumentElement.ChildNodes)
        {
            text = node.SelectSingleNode("highscore").InnerText;
        }
    }
}