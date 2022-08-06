using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class day4 : MonoBehaviour

{
    public int score = 0;
    public Text scoreText;
    public int inc = 1;
    public Text incText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   public void scoreUp()
   {
        score += inc;
        scoreText.text = score + "";

        if(score==250)
        {
            scoreText.text = "HAlFWAY THERE!";
            
        }
        else if(score>=251)
        {
            scoreText.text = score + "";
        }

        if(score==500)
        {
            scoreText.text = "YOU WON!!";
        }
        else if(score>=501)
        {
            scoreText.text = " keep going";
        }
        
        if(score>550)
        {
            scoreText.text = score + "";
        }
   }

   public void Store()
   {
        if(score>= 5)
        {
            score -= 5;
            inc += 1;
            scoreText.text = score + "";
            incText.text = "inc: " + inc;
        }

    }
}
