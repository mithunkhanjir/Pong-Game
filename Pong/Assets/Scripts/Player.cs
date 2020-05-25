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

    private float dirAxis;
 

    private void Start()
    {
      transform.position = new Vector2(startPos.transform.position.x, startPos.transform.position.y);
    }
    // Update is called once per frame
    void Update()
    {

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

    public void ResetLoc()
    {
        transform.position = new Vector2(startPos.transform.position.x, startPos.transform.position.y);
    }
}
