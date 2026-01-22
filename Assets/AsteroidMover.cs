using UnityEngine;

public class AsteroidMover : MonoBehaviour
{
    [SerializeField] private float asteroidSpeed = 10f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(Vector2.down * asteroidSpeed * Time.deltaTime);
    }
}
