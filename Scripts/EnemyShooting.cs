using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    public float timeBetweenShots;
    public float nextShot;
    public GameObject BulletPrefab;


    // Start is called before the first frame update
    void Start()
    {
        ResetShooting();
    }

    // Update is called once per frame
    void Update()
    {
        if (IsOnScreen() && Time.time > nextShot)
        {
            ShootBullet();
            nextShot = Time.time + timeBetweenShots;
        }

    }

    bool IsOnScreen()
    {
        Vector2 screenPoint = Camera.main.WorldToViewportPoint(transform.position);
        return screenPoint.x > 0 && screenPoint.x < 1 && screenPoint.y > 0 && screenPoint.y < 1;
    }
    void ShootBullet()
    {
        if (BulletPrefab != null)
        {
            Instantiate(BulletPrefab, transform.position, Quaternion.identity);
        }
        else
        {
            Debug.LogError("BulletPrefab is not assigned in the inspector!");
        }
    }

    public void ResetShooting()
    {
        nextShot = Time.time + Random.Range(3f, 6.5f);
        timeBetweenShots = Random.Range(3f, 6.5f);
    }
}
