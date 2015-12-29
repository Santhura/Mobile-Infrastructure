using UnityEngine;
using System.Collections;

public class ButtonScript : MonoBehaviour
{
    public string Level;

    public void LoadLevel()
    {
        Application.LoadLevel(Level);
    }

}
