
using UnityEngine;

public partial class PlayerCharacter : MonoBehaviour
{
    // Start is called before the first frame update
    public bool movepaus;
   
    
    // Update is called once per frame
    private void Update()
    {
        if (movepaus == true){
            UpdateInput();
            UpdateMove();
        } 
        
    }

    private void UpdateInput(){
        if(Input.GetAxisRaw("Vertical") != 0){
           Move(Vector3.forward, Input.GetAxisRaw("Vertical"));
        }
        // if(Input.GetKey(KeyCode.S)){
        //    Move(Vector3.forward, Input.GetKey(KeyCode.S))
        // }
        if(Input.GetKey(KeyCode.A)){
             transform.localRotation = Quaternion.Euler(0, -90, 0 * Time.deltaTime) ;
             Move(Vector3.right, -1);
        }
        if(Input.GetKey(KeyCode.D)){
             transform.localRotation = Quaternion.Euler(0, 90, 0 * Time.deltaTime) ;
             Move(Vector3.right, 1);
        }
        // if(Input.GetKeyDown(KeyCode.Space)){
        //     Move(Vector3.up, Input.GetAxisRaw("Vertical")); salah kih
        // }
    
    }
}
