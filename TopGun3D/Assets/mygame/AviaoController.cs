using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AviaoController : MonoBehaviour
{
    // Start is called before the first frame update
    
    private float horizontalInput;
    private float verticalInput; 
    private float speed = 0.9f; // Update is called once per frame
    void Update()
    {
        ControllPlaneDirection();
    }
  private void ControllPlaneDirection(){
        horizontalInput = Input.GetAxis("Horizontal");
        Debug.Log(horizontalInput);
        transform.Rotate( 0,  0, -horizontalInput * speed);

        verticalInput = Input.GetAxis("Vertical");
        transform.Rotate(verticalInput * speed,  0, 0);

        transform.position += transform.forward * speed / 70;
    }
}
