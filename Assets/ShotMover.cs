using UnityEngine;

public class ShotMover : MonoBehaviour
{
    [SerializeField] private float shotSpeed = 10f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(Vector2.up * shotSpeed * Time.deltaTime);
    }
}
