
using UnityEngine;

public partial class PlayerCharacter
{

    // public Rigidbody rb;
   
    [SerializeField] float movementSpeed;

    // Start is called before the first frame update
    void Start()
    {
            // rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
   private void UpdateMove(){
    UpdateRotate();
   }

    

    private void UpdateRotate(){
        if (Input.GetAxisRaw("Horizontal") == 0 && Input.GetAxisRaw("Vertical") > 0){
            transform.localRotation = Quaternion.Euler(0,0,0);
        } 
        else if (Input.GetAxisRaw("Horizontal") > 0 && Input.GetAxisRaw("Vertical") > 0){
            transform.localRotation = Quaternion.Euler(0, 45f, 0);
        }else if (Input.GetAxisRaw("Horizontal") > 0 && Input.GetAxisRaw("Vertical") == 0){
            transform.localRotation = Quaternion.Euler(0, 90f, 0);
        }else if (Input.GetAxisRaw("Horizontal") > 0 && Input.GetAxisRaw("Vertical") < 0){
            transform.localRotation = Quaternion.Euler(0, 135f, 0);
        }else if (Input.GetAxisRaw("Horizontal") == 0 && Input.GetAxisRaw("Vertical") < 0){
            transform.localRotation = Quaternion.Euler(0, 180f, 0);
        }else if (Input.GetAxisRaw("Horizontal") < 0 && Input.GetAxisRaw("Vertical") < 0){
            transform.localRotation = Quaternion.Euler(0, 225f, 0);
        }else if (Input.GetAxisRaw("Horizontal") < 0 && Input.GetAxisRaw("Vertical") == 0){
            transform.localRotation = Quaternion.Euler(0, 270f, 0);
        }else if (Input.GetAxisRaw("Horizontal") < 0 && Input.GetAxisRaw("Vertical") > 0){
            transform.localRotation = Quaternion.Euler(0, 315f, 0);
        }

    }

    private void Move(Vector3 movementDirection, float axisValue){
        transform.Translate(movementDirection * movementSpeed * axisValue * Time.deltaTime, Space.World);
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -8f, 8f), transform.position.y, transform.position.z);
    }
}
