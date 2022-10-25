using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawner : MonoBehaviour
{
    [SerializeField] GameObject carPrefab;
    [SerializeField] private CarChecker carCek;
    [SerializeField] public float minSpawnDuration;
    [SerializeField] public float maxSpawnDuration;
     float currentTime;
    float randomTime;

    // bool isRight;
    // float timer;
    // Start is called before the first frame update
    void Start()
    {
        randomTime = Random.Range(minSpawnDuration, maxSpawnDuration);
        
       // isRight = Random.value > 0.5f ? true : false;
    }

    // Update is called once per frame
    void Update()
    {
       currentTime += Time.deltaTime;
        if(currentTime > randomTime && carCek.carExist == false)
        {
        InstantiateCar();
        }else
        {
            
        }
    }
    
    public void InstantiateCar()
    {
    Instantiate(carPrefab, transform.position, transform.rotation);
   randomTime = Random.Range(minSpawnDuration, maxSpawnDuration);
    currentTime = 0;
    }
}
