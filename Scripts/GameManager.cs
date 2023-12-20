using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static bool isPlayerDead;
    public GameObject loseScreen;
    public GameObject YouWinScreen;
    private Score scoreManager;

    // Start is called before the first frame update
    void Start()
    {
        isPlayerDead = false;
        loseScreen.SetActive(false);
        YouWinScreen.SetActive(false);

        scoreManager = GetComponent<Score>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isPlayerDead)
        {
            loseScreen.SetActive(true);
        }
        
        else if (Score.score >= 68)
        {
            ShowYouWinScreen();
        }
    }

    public void EnemyDestroyed()
    {
        Score.updateScore();

        if (Score.score >= 68)
        {
            ShowYouWinScreen();
        }
    }

    void ShowYouWinScreen()
    {
        Debug.Log("You Win!");
        YouWinScreen.SetActive(true);
    }
    public static void playerDead()
    {
        isPlayerDead = true;
    }
}
