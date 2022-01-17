using UnityEngine;

public class Controller : MonoBehaviour
{
    //private CharacterController _controller;
    //private Camera _viewCamera;
    //private Vector3 _velocity;
    //private float _moveSpeed;
    //private void Awake()
    //{
    //    _controller = GetComponent<CharacterController>();
    //    _viewCamera = Camera.main;
    //}

    //private void Update()
    //{
    //    Vector3 mousePos = _viewCamera.ScreenToViewportPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, _viewCamera.transform.position.y));
    //    transform.LookAt(mousePos + Vector3.up * transform.position.y);
    //    _velocity = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical")).normalized * _moveSpeed;
    //}

    //private void FixedUpdate()
    //{
    //    _controller.Move(transform.position + _velocity * Time.fixedDeltaTime);
    //}
}
