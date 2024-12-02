using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ScoreController : MonoBehaviour
{

    public static ScoreController instance;
    [SerializeField] TextMeshProUGUI scoreCounter;
    int score = 0;

    private void Awake(){
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        scoreCounter.text = score.ToString();
    }

    public void AddPoint(){
        score += 1;
        scoreCounter.text = score.ToString();
    }

    public int GetTotalScore(){
        return score;
    }

    public void SetTotalScore(int newScore){
        score = newScore;
    }

  
}
