using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMovement : MonoBehaviour
{
    private Rigidbody _rb;
    private float _horizontalMovement;
    private float _verticalMovement;
    private Vector3 _movement;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
   

    }

    // Update is called once per frame
    void Update()
    {
        _horizontalMovement = Input.GetAxis("Horizontal");
        _verticalMovement = Input.GetAxis("Vertical");
        _movement = new Vector3(_horizontalMovement, 0.0f, _verticalMovement);
        _movement.Normalize();
        if (_rb != null)
        {
            _rb.linearVelocity = _movement;
        }
        else
        {
            Debug.LogError("No RigidBody found");
        }
        
    }
}
