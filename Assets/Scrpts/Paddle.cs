using UnityEngine;

public class Paddle : MonoBehaviour
{
    protected Rigidbody2D _rigidbody;
    public float _speed = 10.0f;
     

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }
}
