using System;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.TextCore.Text;

public class PlayerController : MonoBehaviour
{
    [SerializeField] public CharacterController control;
    [SerializeField] float moveSpeed;
    [SerializeField] float moveX;
    [SerializeField] float moveZ;
    [SerializeField] Camera myCam;
    
    void Start()
    {
        //Cursor.lockState = CursorLockMode.Locked;
    }
    
    void Update()
    {
        MovePlayer();
        int amountToRotate = 0;
        if (Input.GetMouseButton(1))
        {
            if (Input.mousePosition.x > Screen.width * 0.667f)
            {
                amountToRotate = 60;
            }
            else if (Input.mousePosition.x < Screen.width * 0.333f)
            {
                amountToRotate = -60;
            }
        }
        transform.Rotate(0, amountToRotate * 1 * Time.deltaTime, 0);
    }

    void MovePlayer()
    {
        moveX = Input.GetAxis("Horizontal");
        moveZ = Input.GetAxis("Vertical");

        Vector3 moveAmount = new Vector3(moveX, 0f, moveZ);
        Vector3 finalMove = transform.TransformDirection(moveAmount);
        control.Move(finalMove * moveSpeed * Time.deltaTime);
    }
}
