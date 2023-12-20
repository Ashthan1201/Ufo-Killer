using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

public class enemyScript : MonoBehaviour
{
    public float minSpeed = 1f;
    public float maxSpeed = 8f;
    private Vector2 initialPosition;
    private float speed;


    // Start is called before the first frame update
    void Start()
    {
        initialPosition = transform.position;
        speed = Random.Range(minSpeed, maxSpeed);
        ResetEnemyState();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()

    {
        if (transform.position.x >= 9)
        {
            transform.position = new Vector2(transform.position.x - 1, transform.position.y - 1);
            speed = -speed;
            GetComponent<Rigidbody2D>().velocity = new Vector2(speed, 0);
        }
        else if (transform.position.x <= -9)
        {
            transform.position = new Vector2(transform.position.x + 1, transform.position.y - 1);
            speed = -speed;
            GetComponent<Rigidbody2D>().velocity = new Vector2(speed, 0);
        }
    }
    void OnBecameVisible()
    {
        GetComponent<EnemyShooting>().enabled = true;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Destroy(other.gameObject);
            GameManager.playerDead();
        }
    }

    public void ResetEnemyState()
    {
        transform.position = initialPosition;
        float randomSpeed = Random.Range(minSpeed, maxSpeed);
        speed = randomSpeed;
        GetComponent<Rigidbody2D>().velocity = new Vector2(speed, 0);
    }
}
