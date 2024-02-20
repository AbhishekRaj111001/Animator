using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rigidbody;
    public float F = 20f;
    public float M = 8f;

    public float maxX;
    public float minX;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerPos = transform.position;

        if (playerPos.x < minX)
        {
            playerPos.x = minX;
        }
        transform.position = playerPos;

        if (playerPos.x > maxX)
        {
            playerPos.x = maxX;
        }
        transform.position = playerPos;

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position = transform.position + new Vector3(0, 0, 10f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position = transform.position + new Vector3(-10f * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position = transform.position + new Vector3(10f * Time.deltaTime, 0, 0);
        }
    }
    private void FixedUpdate()
    {
        transform.position = transform.position + new Vector3(0, 0, F * Time.deltaTime);
    }
}
