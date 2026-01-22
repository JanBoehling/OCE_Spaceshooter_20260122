using UnityEngine;

public class PlayerShooter : MonoBehaviour
{
    public GameObject prefab;
    [SerializeField] private float timeDestroy = 1f;

    private Vector2 position;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        position = new Vector2(transform.position.x, transform.position.y);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            var copy = Instantiate(prefab, position, Quaternion.identity);
            Destroy(copy, timeDestroy);
        }
    }
}
