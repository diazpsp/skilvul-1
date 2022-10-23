using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarChecker : MonoBehaviour
{
    public bool carExist = false;
    // Start is called before the first frame update
    void Start()
    {
        carExist = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnTriggerStay(Collider coltrig){
        carExist = true;
    }
    void OnTriggerExit(Collider coltrigex){
        carExist = false;
    }
}
