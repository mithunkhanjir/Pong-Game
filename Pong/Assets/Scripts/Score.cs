using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    // Start is called before the first frame update

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

            //GameObject.Find("GameManager").GetComponent<GameManager>().InitRound();
         //gm = GameObject.Find("GameManager").GetComponent<GameManager>();
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
