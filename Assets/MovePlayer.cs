using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{

    public Rigidbody rb;
    [SerializeField] float MoveDuration;

    // Start is called before the first frame update
    void Start()
    {
            rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
       
        if(Input.GetKey(KeyCode.W)){
            rb.velocity = new Vector3(0,0,1);
        }
        if(Input.GetKey(KeyCode.S)){
            rb.velocity = new Vector3(0,0,-1);
        }
        if(Input.GetKeyDown(KeyCode.Space)){
            rb.velocity = new Vector3(0,5,1);
        }
    }
}
