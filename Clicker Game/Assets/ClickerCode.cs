using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickerCode : MonoBehaviour
{
    public int score = 0;
    public Text scoreText;
    public int inc;
    public Text incText;
    public int Price = 5;
    public Text PriceText;

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
        score += 1 + inc;
        scoreText.text = score.ToString("0");
    }

    public void Shop()
    {
        if(score >= Price)
        {
            score -= Price;
            inc += 1;
            scoreText.text = score.ToString("0");
            incText.text = "Inc: " + inc;
            Price *= 2;
            PriceText.text = Price.ToString();
            PriceText.text = "Price: " + Price;
        }
    }

}

