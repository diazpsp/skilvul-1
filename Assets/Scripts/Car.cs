using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    float speed;
    //  [SerializeField] private CarSpawner carSpawn;

    
    void Start(){
        speed = Random.Range(2, 6);
    }
    

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime *speed);
        if (this.transform.position.x > 8.21f || this.transform.position.x <= -10.3f)
        Destroy(this.gameObject);
    }

}
