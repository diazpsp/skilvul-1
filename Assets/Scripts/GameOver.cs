using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    [SerializeField] private GameObject panel;
    public PlayerCharacter pleyerchar;

    // Start is called before the first frame update
    void Start()
    {
        panel.SetActive(false);

        
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision col){
        if (col.gameObject.tag == "Car"){
            GameOverCon();
        }
    }

    public void GameOverCon(){
         Time.timeScale = 0;
            panel.SetActive(true);
           pleyerchar.movepaus = false;
    }
}
