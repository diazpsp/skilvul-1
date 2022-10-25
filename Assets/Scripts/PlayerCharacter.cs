
using UnityEngine;
using UnityEngine.UI;

public partial class PlayerCharacter : MonoBehaviour
{
    // Start is called before the first frame update
    public bool movepaus;
   [SerializeField] private Animator anim;
   [SerializeField] private int skor;
    public Text skorTxt;
    
    // Update is called once per frame
    private void Update()
    {
        if (movepaus == true){
            UpdateInput();
            UpdateMove();
        } 
        skorTxt.text = skor.ToString();
    }

    void OnTriggerEnter(Collider col){
        if(col.gameObject.tag == "CarCheck"){ skor += 1;}
    }



    private void UpdateInput(){
        if(Input.GetAxisRaw("Vertical") != 0){
           Move(Vector3.forward, Input.GetAxisRaw("Vertical"));
           anim.SetBool("isWalking",true);
        }else{
            anim.SetBool("isWalking",false);
        }
        // if(Input.GetKey(KeyCode.S)){
        //    Move(Vector3.forward, Input.GetKey(KeyCode.S))
        // }
      if(Input.GetAxisRaw("Horizontal") != 0){
           Move(Vector3.right, Input.GetAxisRaw("Horizontal"));
           anim.SetBool("isWalking",true);
        }
        // if(Input.GetKeyDown(KeyCode.Space)){
        //     Move(Vector3.up, Input.GetAxisRaw("Vertical")); salah kih
        // }
    
    }
}
