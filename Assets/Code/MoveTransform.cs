using UnityEngine;

namespace Asteroids
{
    [RequireComponent(typeof(Rigidbody2D))]
    internal sealed class MoveTransform : MonoBehaviour
    {
        [SerializeField] private Rigidbody2D _playerRB;       
        [SerializeField] private float _speed;

        private Vector2 _moveVector;

        private void Start()
        {
            _playerRB = GetComponent<Rigidbody2D>();
        }

        private void FixedUpdate()
        {
            Movement();
        }
        private void Movement()
        {
            _moveVector.x = Input.GetAxis("Horizontal");
            _moveVector.y = Input.GetAxis("Vertical");
                      
            _playerRB.velocity = new Vector2(_moveVector.x, _moveVector.y);
        }
    }
}

