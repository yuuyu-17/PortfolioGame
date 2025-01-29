using UnityEngine;

namespace InGame
{
    public class PlayerController : MonoBehaviour
    {
       [SerializeField]
       private float _speed = 0f;

       private Rigidbody _rb;

       private void Start()
       {
            _rb = GetComponent<Rigidbody>();
       }

       private void FixedUpdate()
       {
            float moveX = Input.GetAxis("Horizontal");
            float moveZ = Input.GetAxis("Vertical");

            Vector3 move = new Vector3(moveX, 0, moveZ).normalized * _speed;
            _rb.linearVelocity = new Vector3(move.x, _rb.linearVelocity.y, move.z);
       }
    }
}
