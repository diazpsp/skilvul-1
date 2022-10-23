using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    [SerializeField] private Transform playerTransform;

    private float Zcam;
  
  
    public void Initialize()
    {
        Zcam = transform.position.z;
    }

    // Update is called once per frame
    private void Update()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, Zcam + playerTransform.position.z);
    }
}
