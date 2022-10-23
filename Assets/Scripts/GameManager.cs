using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private CameraScript cameraScript;
    public PlayerCharacter pleyercharacter;
    public GameOver gemover;
    [SerializeField] public GameObject menuPanel;
    [SerializeField] private AudioSource audio;
    [SerializeField] private GameObject timers;
    public float TimeLeft;
    public bool TimerOn =false;
    public Text TimerTxt;

    // Start is called before the first frame update
    void Start()
    {
        timers.SetActive(false);
        cameraScript.Initialize();
        
    }

    // Update is called once per frame
   void Update(){
    if(TimerOn){
        if(TimeLeft> 0 ){
            TimeLeft -= Time.deltaTime;
            UpdateTimer(TimeLeft);
        }
        else
        {
            
            TimeLeft = 0;
            TimerOn= false;
            gemover.GameOverCon();
        }
    }
   }

   void UpdateTimer(float currentTime){
    currentTime += 1;
    float minutes = Mathf.FloorToInt(currentTime / 60);
    float seconds = Mathf.FloorToInt(currentTime % 60);
    TimerTxt.text = string.Format("{0:00} : {1:00}", minutes,seconds);
   }

   
    public void PlayInMenu(){
        pleyercharacter.movepaus = true;
        menuPanel.SetActive(false);
        Time.timeScale = 1;
        audio.Play();
        TimerOn = true;
        timers.SetActive(true);

    }
    public void QuitGame(){
        Application.Quit();
    }

    public void Retry()
    {
 SceneManager.LoadScene("animasl");
        
    }
    
}
