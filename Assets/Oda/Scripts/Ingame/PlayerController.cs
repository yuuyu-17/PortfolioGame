using UnityEngine;

namespace InGame
{
    public class PlayerController : MonoBehaviour
    {
          [SerializeField]
          private float _speed = 10.0f;//移動速度
          [SerializeField]
          private float _mouseSensitivity = 2.0f; // マウス感度
          // [SerializeField]
          // private float _jumpPower = 5.0f; // ジャンプ力
          // [SerializeField]
          // private float _gravity = 9.8f; // 重力

          private CharacterController _controller;
          private Vector3 _moveVelocity;
          private Transform _cameraTransform;
          private float _cameraRotationX = 0f; // カメラの縦回転角度

          void Start()
          {
               _controller = GetComponent<CharacterController>();
               _cameraTransform = Camera.main.transform;

               Cursor.lockState = CursorLockMode.Locked;
               Cursor.visible = false;
          }

          void Update()
          {
               float moveX = Input.GetAxis("Horizontal") * _speed * Time.deltaTime;
               float moveZ = Input.GetAxis("Vertical") * _speed * Time.deltaTime;
               Vector3 moveDirection = transform.TransformDirection(new Vector3(moveX, 0, moveZ));

               //  if (_controller.isGrounded)
               // {
               //      _moveVelocity.y = 0f; // 接地しているときはy速度をリセット

               //      // スペースキーでジャンプ
               //      if (Input.GetKeyDown(KeyCode.Space))
               //      {
               //           _moveVelocity.y = _jumpPower;
               //      }
               // }

               // _moveVelocity.y -= _gravity * Time.deltaTime;

               _controller.Move((moveDirection + _moveVelocity) * Time.deltaTime);

               float mouseX = Input.GetAxis("Mouse X") * _mouseSensitivity;
               float mouseY = Input.GetAxis("Mouse Y") * _mouseSensitivity;

               transform.Rotate(Vector3.up * mouseX);

               _cameraRotationX -= mouseY;
               _cameraRotationX = Mathf.Clamp(_cameraRotationX, -90f, 90f);
               _cameraTransform.localRotation = Quaternion.Euler(_cameraRotationX, 0f, 0f);
          }
    }
}
