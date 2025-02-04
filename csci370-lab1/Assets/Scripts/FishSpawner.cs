using UnityEngine;

public class FishSpawner : MonoBehaviour {

    public GameObject FreshFish;
    public GameObject RottenFish;

    void Start() {
        InvokeRepeating("SpawnFish", 2.0f, 1.5f);
    }


    void Update() {
        
    }

    void SpawnFish() {
        if (Random.Range(0, 3) == 0) {
            Instantiate(RottenFish);
        } else {
            Instantiate(FreshFish);
        }
    }

}
