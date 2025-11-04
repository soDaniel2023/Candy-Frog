using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class Player : MonoBehaviour
{
    public bool canMove = true;
 
    [SerializeField]
    float moveSpeed;
 
    void Start()
    {
    }
 
    void Update()
    {
        if (canMove)
        {
            Move();
        }
    }
 
    void Move()
    {
        float inputX = Input.GetAxis("Horizontal");
        transform.position += Vector3.right * inputX * moveSpeed * Time.deltaTime;
    }
}