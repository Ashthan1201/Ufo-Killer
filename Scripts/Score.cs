using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int score;
    public Text scoreTxt;

    public static void updateScore()
    {
        score++;
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        scoreTxt.text = "Score: " + score;
    }

    public static void ResetScore()
    {
        score = 0;
    }
}