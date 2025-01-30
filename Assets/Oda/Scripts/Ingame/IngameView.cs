using UnityEngine;

namespace InGame
{
    public class IngameView : MonoBehaviour
    {
        [SerializeField]
        private GameObject _coin;
        [SerializeField]
        private GameObject _player;

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject == _player)
            {
                Destroy(_coin);
            }
        }
    }
}
