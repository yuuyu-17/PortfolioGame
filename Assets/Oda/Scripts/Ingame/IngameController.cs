using UnityEngine;

namespace InGame
{
    public class IngameController : MonoBehaviour
    {
        private IngameModel model;
        private ScoreView scoreView;

        private void Awake()
        {
            model = new IngameModel();
            scoreView = Object.FindFirstObjectByType<ScoreView>(); // ScoreViewを探す

            model.OnScoreUpdated += scoreView.UpdateScoreText; // スコア変化時にUI更新
        }

        public void CoinCollected()
        {
            model.AddScore(10); // コイン取得時に10点加算
        }
    }
}