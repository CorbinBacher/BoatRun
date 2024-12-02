using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour

{
    public static Timer instace;
    public float TimeLeft;
    public bool TimerOn = false;
    public float TimePassed;
    private bool isDeasd = false;
    [SerializeField] DeathFader dead;
    private int fadeCount = 0;
    

    public Text TimerTxt;
    // Start is called before the first frame update
    void Start()
    {
        TimerOn = true;
        TimePassed = 0;
    }

    void Awake()
    {
        instace = this;
    }

    // Update is called once per frame
    void Update()
    {
      
        if(TimerOn)
        {
            if(TimeLeft > 0)
            {
                TimeLeft -= Time.deltaTime;
                updateTimer(TimeLeft);
                TimePassed += Time.deltaTime;
                 

                if(TimePassed >= 5)
                {
                    Spawner.instance.spawnObjects();
                    TimePassed = 0;
                }
            }
            else{
                Debug.Log("Time is UP");
                
                if(fadeCount == 0)
                {
                    dead.FadeToColor();
                    fadeCount++;
                }
                
                TimeLeft = 0;
                if(Input.GetKeyDown(KeyCode.Space))
                {
                    TimerOn = false;
                    SceneManager.LoadScene("MainMenu");
                }
                
            }
        }
    }

    void updateTimer(float currentTime)
    {
        currentTime += 1;

        float minutes = Mathf.FloorToInt(currentTime / 60);
        float seconds = Mathf.FloorToInt(currentTime % 60);

        TimerTxt.text = string.Format("{0:00} :{1:00}", minutes, seconds);
    }

    public void addTime(int n)
    {
        TimeLeft += n;
    }

    public void subTime(int s)
    {
        TimeLeft -= s;
    }

}
