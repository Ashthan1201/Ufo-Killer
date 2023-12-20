using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Score.ResetScore();

        ResetEnemies();
    }

    private void ResetEnemies()

    {

        enemyScript[] enemies = FindObjectsOfType<enemyScript>();
        foreach (enemyScript enemy in enemies)

        {
            enemy.ResetEnemyState();
            enemy.GetComponent<EnemyShooting>().ResetShooting();
        }
    }
}
