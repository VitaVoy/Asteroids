using UnityEngine;

namespace Asteroids
{
    public class Damage : MonoBehaviour
    {
        [SerializeField] private float _hp;
        private void OnCollisionEnter2D(Collision2D other)
        {
            if (_hp <= 0)
            {
                Destroy(gameObject);
            }
            else
            {
                _hp--;
            }
        }
    }
}
