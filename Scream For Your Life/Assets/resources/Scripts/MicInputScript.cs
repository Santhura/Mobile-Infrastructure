using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class MicInputScript : MonoBehaviour
{
    //CONSTANTS
    private const int SAMPLECOUNT = 1024;       //Sample Count
    private const int FREQUENCY = 48000;        //Frequency (Hz)
    private const float REFVALUE = 0.02f;       //RMS value for 0 dB

    //PUBLIC VARIABLES
    public Text resultDisplay;                  //TextView for displaying amount of decibel
    public Text blowDisplay;                    //TextView for displaying whether the user is blowing or not
    public Text highScoreTxt;                   //TextView for displaying the highscore (at gameOver)
    public Text maxDecibelTxt;                  //TextView for displaying the max decibel value (at gameOver)
    public GameObject gameOverPanel;            //UI panel for the gameOver screen
    public float maxPosY;                       //Get the player's max Y pos recorded in-game (highscore)
    public float maxDbValue;                    //Get max decibel value recorded in-game
    public float forcePower = 500;              //Force power to make the player move (when making sounds)

    //PRIVATE VARIABLES
    private AudioSource audio;                  //AudioSource to listen to
    private float posY;                         //Get player's current y pos and max y pos
    private float camera2DMinY, camera2DMaxY;   //Lowest/highest y position of the camera
    private float dbValue;                      //One decibel value
    private float rmsValue;                     //Volume in RMS
    private List<float> dbValues;               //Float list to store decibel values
    private float[] samples;                    //Float array to collect audio samples 
    private bool gameOver;                      //Boolean which checks if the player is gameover or not
    private bool isPlaying;
   

    // Use this for initialization
    void Start()
    {
        Time.timeScale = 1;
        gameOver = false;
        isPlaying = false;
        maxPosY = 0;
        maxDbValue = 0;
        samples = new float[SAMPLECOUNT];
        audio = GetComponent<AudioSource>();
        StartMicListener();
    }

    // Update is called once per frame
    void Update()
    {
        if (!gameOver)
        {
            //Game playing
            GetDecibel();
            GetMaxData();
            CheckGameOver();
        }
        else
        {
            //Game over
            Time.timeScale = 0;
            gameOverPanel.SetActive(true);
            highScoreTxt.text = "HighScore = " + (int)maxPosY;
            maxDecibelTxt.text = "Loudest scream = " + (int)maxDbValue + " dB";
        }

}

    void GetDecibel()
    {
        //Get input, otherwise no sound has been made
        if (isPlaying)
        {
            GetOutputSamples();

            //Sums squared samples
            float sum = 0;
            for (int i = 0; i < SAMPLECOUNT; i++)
            {
                sum += Mathf.Pow(samples[i], 2);
            }

            //Get decibel value
            //RMS is the square root of the average value of the samples
            rmsValue = Mathf.Sqrt(sum / SAMPLECOUNT);
            dbValue = 20 * Mathf.Log10(rmsValue / REFVALUE);

            //If somehow the decibel value is less than 0
            if (dbValue < 0) { dbValue = 0; }
        }
        else
        {
            dbValue = 0;
        }

        //Blow up/Shrink balloon (sphere in editor)
        if (dbValue > 0)
        {
            //blowDisplay.text = "Blowing";
            GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody2D>().AddForce(Vector2.up * forcePower);
        }
    }

    void GetOutputSamples()
    {
        // Get all of the input samples from the mic
        audio.GetOutputData(samples, 0);
    }

    void StartMicListener()
    {
        Debug.Log("Hallo");
        //Start listening with the built-in microphone
        audio.clip = Microphone.Start("Built-in Microphone", true, 10, FREQUENCY);
        audio.loop = true;
        audio.volume = 0.2f;

        // Wait until the recording has started
        while (!(Microphone.GetPosition("Built-in-Microphone") > 0)) { } 

        // Play the audio source!
        audio.Play(); 
        isPlaying = true;
    }

    void GetMaxData()
    {
        //Get the highest y position
        posY = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>().position.y;

        if (posY > maxPosY)
        {
            maxPosY = posY;
        }

        //Get the highest decibel value
        if (dbValue > maxDbValue)
        {
            maxDbValue = dbValue;
        }

        //Display highest y position
        blowDisplay.text = "HighScore = " + (int)maxPosY;
    }

    void CheckGameOver()
    {
        //Get the lowest and highest y position of the viewport
        camera2DMinY = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera2D>()._minY;
        //camera2DMaxY = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera2D>()._maxY;

        //GameOver if player isn't visible anymore
        if (posY < camera2DMinY)
        {
            gameOver = true;
            audio.Stop();
        }
    }
}
