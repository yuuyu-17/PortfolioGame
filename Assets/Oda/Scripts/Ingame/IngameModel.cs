using UnityEngine;

namespace InGame
{
    public class IngameModel
    {
        public int Score { get; private set; }

        public delegate void ScoreUpdated(int newScore);
        public event ScoreUpdated OnScoreUpdated;

        public void AddScore(int points)
        {
            Score += points;
            OnScoreUpdated?.Invoke(Score); // スコア更新イベント発火
        }
    }
}
