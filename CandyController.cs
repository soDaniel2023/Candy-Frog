using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class CandyController : MonoBehaviour
{
 
    void Start()
    {
    }
 
    void Update()
    {
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            GameManager.instance.IncrementScore();
            Destroy(gameObject);
        }
        else if (collider.gameObject.tag == "Boundary")
        {
            GameManager.instance.DecrementLives();
            Destroy(gameObject);
        }
    }
}