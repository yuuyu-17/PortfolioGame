using UnityEngine;

namespace InGame
{
    public class PlayerController : MonoBehaviour
    {
          private Rigidbody _rb;
          [SerializeField]
          private float speed = 3.0f;

          void Start()
          {
               _rb = GetComponent<Rigidbody> ();
          }

          void Update()
          {
               if(Input.GetKey(KeyCode.W)){
                    _rb.linearVelocity = transform.forward*speed;
               }
               if(Input.GetKey(KeyCode.S)){
                    _rb.linearVelocity = -transform.forward*speed;
               }
               if(Input.GetKey(KeyCode.D)){
                    _rb.linearVelocity = transform.right*speed;
               }
               if(Input.GetKey(KeyCode.A)){
                    _rb.linearVelocity = -transform.right*speed;
               }
          }
    }
}
