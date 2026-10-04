using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private GameObject explosionVFX;
    [SerializeField] private int hitPoints = 3;
    [SerializeField] private int scoreValue = 10;

    private Scoreboard scoreboard;

    void Start()
    {
        scoreboard = FindAnyObjectByType<Scoreboard>();
    }

    void OnParticleCollision(GameObject other)
    {
        ProcessHit();
    }

    void ProcessHit()
    {
        hitPoints--;
        if (hitPoints <= 0)
        {
            scoreboard.IncreaseScore(scoreValue);
            Instantiate(explosionVFX, this.transform.position, Quaternion.identity);
            Destroy(this.gameObject);
        }
    }
}