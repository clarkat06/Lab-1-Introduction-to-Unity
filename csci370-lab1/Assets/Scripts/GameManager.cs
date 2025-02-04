using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public static GameManager Instance { get; private set; }
    int Score = 0;
    public TextMeshProUGUI ScoreText;

    void Awake() {
        if (Instance == null) {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        } else {
            Destroy(gameObject);
        }
    }

    public void IncScore(int ds) {
        Score += ds;
        ScoreText.text = "Cash: " + Score;
    }

    void Start() {
        
    }

    void Update() {
        
    }

}
