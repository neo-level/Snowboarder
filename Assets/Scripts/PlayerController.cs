using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float torqueAmount = 5.0f;
    private Rigidbody2D _rigidbody2D;
    private void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            _rigidbody2D.AddTorque(torqueAmount);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            _rigidbody2D.AddTorque(-torqueAmount);
        }
    }
}
