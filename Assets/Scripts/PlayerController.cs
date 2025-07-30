using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour {
    private InputSystem_Actions inputSystem;
    [SerializeField] private Rigidbody2D _rigidbody2D;

    private void OnEnable() {
        if (inputSystem == null) {
            inputSystem = new InputSystem_Actions();
        }
        inputSystem.Enable();
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.CompareTag("Trap")) {
            Debug.Log("Player Hit Trap");
        }
    }

    private void Update() {
        if (inputSystem.Player.Right.inProgress) {
            _rigidbody2D.linearVelocityX = 5f;
        } else if (inputSystem.Player.Left.inProgress) {
            _rigidbody2D.linearVelocityX = -5f;
        }

        if (inputSystem.Player.Jump.inProgress) {
            _rigidbody2D.linearVelocityY = 5f;
        } else {
            _rigidbody2D.linearVelocityY = -5f;
        }
    }
}