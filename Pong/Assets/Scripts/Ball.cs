using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D rb;

    [SerializeField]
    private float speed;

    public Transform startPos;
    
    void Start()
    {
        MoveBall();
    }

    void MoveBall()
    {

        //Move randomly when the round begins
        float x, y,temp;
        temp = Random.Range(0, 2);
        if (temp == 0)
        {
            x = -1;
        }
        else 
        {
            x = 1;
        }

        temp = Random.Range(0, 2);
        if (temp == 0)
        {
            y = -1;
        }
        else
        {
            y = 1;
        }

        rb.velocity = new Vector2(x * speed, y * speed);
    }

    public void Reset()
    {
        transform.position = new Vector2(startPos.transform.position.x, startPos.transform.position.y);
        rb.velocity = Vector2.zero;
        StartCoroutine(Wait());
        //MoveBall();
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(2);
        MoveBall();
    }
}
