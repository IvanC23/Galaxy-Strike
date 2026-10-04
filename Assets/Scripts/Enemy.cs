using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private GameObject explosionVFX;
    void OnParticleCollision(GameObject other)
    {
        Instantiate(explosionVFX, this.transform.position, Quaternion.identity);
        Destroy(this.gameObject);
    }
}
