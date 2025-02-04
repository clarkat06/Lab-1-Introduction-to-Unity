using UnityEngine;

public class FryFish : MonoBehaviour {

    void Start() {
        
    }

    void Update() {
        
    }

    void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.CompareTag("RottenFish")) {
            GameManager.Instance.IncScore(Random.Range(-15, -4));
        } else {
            GameManager.Instance.IncScore(Random.Range(5, 16));
        }
        Destroy(collision.gameObject);
    }

}
