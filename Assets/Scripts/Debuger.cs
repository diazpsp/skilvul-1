using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Debuger : MonoBehaviour
{
    [SerializeField] TMP_Dropdown dropdown;
    
    
    
    // Start is called before the first frame update
   
    

    
    public void Play(){
    
    Debug.Log("play");
    }
    public void Settings(){
    Debug.Log("Membuka Settings");
    }
    public void Credits(){
    Debug.Log("Credits");
    }
    public void QuitGame(){
    Debug.Log("Quit Game");
    Application.Quit();
    }
    public void Dropdown(int value){
        Debug.Log(dropdown.options[value].text);
    }
}
