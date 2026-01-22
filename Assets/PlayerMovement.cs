using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 18f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        
        Vector3 move = transform.right * x * _moveSpeed * Time.deltaTime;
        transform.position += move;
        Vector3 playerPosition = transform.position;
        playerPosition.x = Mathf.Clamp(playerPosition.x, -10.5f, 10.5f);
        transform.position = playerPosition;
        
    

    }
}
