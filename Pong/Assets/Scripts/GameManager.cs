using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class GameManager : MonoBehaviour
{
    public GameObject p1;
    public GameObject p2;
    public GameObject ball;

    public int p1Score;
    public int p2Score;

    public GameObject p1Text;
    public GameObject p2Text;

    public GameObject winnerText;


    void Start()
    {
        InitRound();
        
    }

    // Update is called once per frame
    void Update()
    {
        //Decide Winner
        if (p1Score >= 5)
        {
            winnerText.GetComponent<TextMeshProUGUI>().text = "RED WINS";
            StartCoroutine("Quit");
            

        }
        else if(p2Score>=5)
        {
            winnerText.GetComponent<TextMeshProUGUI>().text = "BLUE WINS";
            StartCoroutine("Quit");
        }
    }
    public void InitRound()
    {
        //Reset everything
        ball.GetComponent<Ball>().Reset();
        p1.GetComponent<Player>().ResetLoc();
        p2.GetComponent<Player>().ResetLoc();
    }

    public void CalculateScore(int x)
    {
        //1 for Player 1 aka RED
        if (x == 1)
        {
            p1Score++;
            p1Text.GetComponent<TextMeshProUGUI>().text = p1Score.ToString();
            Debug.Log("Player 1 :" + p1Score);
        }
        else if(x==2)  
        {
            p2Score++;
            Debug.Log("Player 2 :" + p2Score);
            p2Text.GetComponent<TextMeshProUGUI>().text = p2Score.ToString();
        }
    }

    IEnumerator Quit()
    {
        yield return new WaitForSeconds(2);
        Application.Quit();
    }

    
}
