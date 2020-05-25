using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float speed;

    [SerializeField]
    private bool isPlayer1;

    [SerializeField]
    private Transform startPos;

    //Check which input is being used
    private float dirAxis;
 

    private void Start()
    {
      //set the start position
      transform.position = new Vector2(startPos.transform.position.x, startPos.transform.position.y);
    }
   
    void Update()
    {
        //Detemine input
        if (isPlayer1)
        {
            dirAxis = Input.GetAxis("Vertical") * speed * Time.deltaTime; ;
        }
        else
        {
            dirAxis = Input.GetAxis("Vert2") * speed * Time.deltaTime; ;
        }
        
        transform.Translate(Vector2.up * dirAxis);
    }

    //Reset Player(paddle) position
    public void ResetLoc()
    {
        transform.position = new Vector2(startPos.transform.position.x, startPos.transform.position.y);
    }
}
