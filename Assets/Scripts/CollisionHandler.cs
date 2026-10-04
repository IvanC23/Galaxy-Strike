using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    [SerializeField] private GameObject explosionVFX;
    void OnTriggerEnter(Collider other)
    {
        Instantiate(explosionVFX, this.transform.position, Quaternion.identity);
        Destroy(this.gameObject);
    }
}
