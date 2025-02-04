using UnityEngine;

public class DestroyFish : MonoBehaviour
{

    void Start() {
        
    }
    void Update() {
        
    }

    void OnMouseDown() {
        if (gameObject.CompareTag("FreshFish")) {
            GameManager.Instance.IncScore(Random.Range(-15, -4));
        }
        Destroy(gameObject);
    }

}
