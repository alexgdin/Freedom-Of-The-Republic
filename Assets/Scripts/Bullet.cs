using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] public float speed = 20f;
    private float direction;
    public Rigidbody2D rb;
    private int lastpos = 1;

    private CircleCollider2D circleCollider;

    private void Awake()
    {
        circleCollider = GetComponent<CircleCollider2D>();
        rb = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        rb.linearVelocity = transform.right * speed;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy") || other.CompareTag("Wall"))
        {   
            Destroy(gameObject);
        }
    }

    public void SetDirection(float dir)
    {
        direction = dir;

        Vector3 scale = transform.localScale;
        if (UnityEngine.Input.GetAxis("Horizontal") > 0)
        { 
            lastpos = 1;
        }
        else if (UnityEngine.Input.GetAxis("Horizontal") < 0)
        { 
            lastpos = -1;
        }

        scale.x = Mathf.Abs(scale.x) * lastpos;
        transform.localScale = scale;
    }
}
