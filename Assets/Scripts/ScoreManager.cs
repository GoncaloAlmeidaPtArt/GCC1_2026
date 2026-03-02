using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI text;
    [SerializeField] private ScoreBoard scoreBoard;
    private float _timer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        scoreBoard.ResetScore();
    }

    // Update is called once per frame
    void Update()
    {
        _timer += Time.deltaTime;
        scoreBoard.UpdateScore(Mathf.RoundToInt(_timer));
        text.text = $"Score: {scoreBoard.Score}";
    }
}
