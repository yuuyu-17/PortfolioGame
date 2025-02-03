using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace InGame
{
    public class ScoreView : MonoBehaviour
    {
        private TextMeshProUGUI scoreText;

        private void Start()
        {
            scoreText = GetComponent<TextMeshProUGUI>(); // TextMeshProUGUIコンポーネントを取得
            scoreText.text = "Score: 0";  // 初期表示
        }

        public void UpdateScoreText(int newScore)
        {
            scoreText.text = "Score: " + newScore.ToString();  // スコア更新
        }
    }
}