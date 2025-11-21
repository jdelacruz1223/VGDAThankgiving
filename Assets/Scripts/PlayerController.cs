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
    
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    
    void Update()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        moveX = Input.GetAxis("Horizontal");
        moveZ = Input.GetAxis("Vertical");

        Vector3 dir = new Vector3(moveX, 0f, moveZ);
        control.Move(dir * moveSpeed * Time.deltaTime);
    }
}
