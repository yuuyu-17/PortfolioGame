using UnityEngine;

namespace InGame
{
    public class CoinView : MonoBehaviour
    {
        private IngameController controller;

        private void Start()
        {
            controller = Object.FindFirstObjectByType<IngameController>(); // コントローラーを探す
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                controller.CoinCollected(); // コイン取得イベントをControllerに通知
                Destroy(gameObject);
            }
        }
    }
}
