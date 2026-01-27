using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private ParticleSystem effect;
    
    void Update()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime * speed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Instantiate(effect, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
