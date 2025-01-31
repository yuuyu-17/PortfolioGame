using UnityEngine;

namespace InGame
{
    public class IngameView : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                Destroy(gameObject);
            }
        }
    }
}
