using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatInputHandler : MonoBehaviour
{
   BoatController boatController;

    void Awake()
    {
        boatController = GetComponent<BoatController>();
    }
    // Update is called once per frame
    void Update()
    {
       Vector2 inputVector = Vector2.zero;

       inputVector.x = Input.GetAxis("Horizontal");
       inputVector.y = Input.GetAxis("Vertical");

       boatController.SetInputVector(inputVector); 
    }
}
