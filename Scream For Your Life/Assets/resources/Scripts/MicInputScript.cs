﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class MicInputScript : MonoBehaviour
{

    private AudioSource audio;              //AudioSource to listen to
    private float posY;                     //Get current y pos and max y pos
    public float maxPosY;
    private float[] samples;                //Float array to collect audio samples
    private List<float> dbValues;           //Float list to store decibel values
    private const int SAMPLECOUNT = 1024;   //Sample Count
    private const int FREQUENCY = 48000;    //Frequency (Hz)
    private bool isPlaying;                 //Check if mic is listening
    private const float REFVALUE = 0.02f;   // RMS value for 0 dB.
    private float dbValue;                   //One decibel value
    public float maxDbValue;
    private float rmsValue;                 // Volume in RMS
    public Text resultDisplay;              //TextView for displaying amount of decibel
    public Text blowDisplay;                //TextView for displaying whether the user is blowing or not
    public Text highScoreTxt;               //TextView for displaying the highscore (at gameOver)
    public Text maxDecibelTxt;              //TextView for displaying the max decibel value (at gameOver)
    public GameObject gameOverPanel;        //Panel for when you are game over
    private bool gameOver;
    public Text inputField;

    public float forcePower = 500;

    // Use this for initialization
    void Start()
    {
        gameOver = false;
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
        }
        else
        {
            //Game over
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

        //Set text to display the decibel amount
        resultDisplay.text = "Decibel amount = " + dbValue.ToString("F1") + " dB";

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
        //Start listening with the built-in microphone
        audio.clip = Microphone.Start("Built-in Microphone", true, 10, FREQUENCY);
        audio.loop = true;
        audio.volume = 0.2f;

        while (!(Microphone.GetPosition("Built-in-Microphone") > 0)) { } // Wait until the recording has started
        audio.Play(); // Play the audio source!
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

        //Display highest y position
        blowDisplay.text = "HighScore = " + (int)maxPosY;

        //Get the highest decibel value
        if(dbValue > maxDbValue)
        {
            maxDbValue = dbValue;
        }

        if(maxPosY > 30)
        {
            gameOver = true;
        }
    }
}
