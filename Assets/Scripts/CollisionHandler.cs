using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    [SerializeField] private GameObject explosionVFX;

    private GameSceneManager gameSceneManager;

    void Start()
    {
        gameSceneManager = FindAnyObjectByType<GameSceneManager>();
    }

    void OnTriggerEnter(Collider other)
    {
        gameSceneManager.ReloadLevel();
        Instantiate(explosionVFX, this.transform.position, Quaternion.identity);
        Destroy(this.gameObject);
    }
}
