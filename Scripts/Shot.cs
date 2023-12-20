using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class shotScript : MonoBehaviour
{
    public int speed = 10;
    public int damage;
    public string target;
    public GameObject explosion;


    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, speed);
    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == target)
        {
            if (other.tag == "Player")
            {
                GameManager.playerDead();
            }

            else
            {
                Score.updateScore();
            }

            Destroy(other.gameObject);
            GameObject fire = (GameObject)Instantiate(explosion, other.gameObject.transform.position, Quaternion.identity);
            Destroy(fire, 0.5f);
            Destroy(gameObject);


        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
