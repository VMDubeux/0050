using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerController : MonoBehaviour
{
    private CharacterController _controller;
    private Animator _animator;
    private Transform _mCamera;

    private float _moveSpeed;
    [SerializeField] private float _walkSpeed;
    [SerializeField] private float _runningSpeed;
    void Start()
    {
        _controller = GetComponent<CharacterController>();
        _animator = GetComponent<Animator>();
        _mCamera = Camera.main.transform;

        _moveSpeed = _walkSpeed;
    }
    void Update()
    {
        MoveCharacter();
    }

    private void MoveCharacter() 
    {
        Vector3 moveDirection = transform.TransformDirection(InputManager.Instance.GetAxis());

        _controller.Move(moveDirection * _moveSpeed * Time.deltaTime);
    }

}
