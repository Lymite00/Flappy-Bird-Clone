using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update

    public Text scoreText;
    public int score;


    public void updateScore()
    {
        score++;
        scoreText.text = score.ToString();
    }
    void Start()
    {
        score = 0;
    }
}
