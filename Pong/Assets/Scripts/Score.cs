using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    

    [SerializeField]
    private bool leftWall;
    public GameManager gm;

    private void Start()
    {
        //gm = new GameManager();
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.CompareTag("Ball"))
        {

            //gm = GameObject.Find("GameManager").GetComponent<GameManager>();

            //Determine which wall has been hit by the wall
            gm.InitRound();
            if (leftWall == true)
            {
                gm.CalculateScore(2);
                gm.InitRound();
            }
            else
            {
                gm.CalculateScore(1);
                gm.InitRound();
            }
            
        }
    }
}
