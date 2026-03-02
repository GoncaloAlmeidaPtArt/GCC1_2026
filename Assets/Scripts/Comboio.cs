using UnityEngine;

public class Comboio : MonoBehaviour
{
    [SerializeField] private Vector2 velocityBreak;
    private Rigidbody _controller;
    private float _velocity;
    private float _rare;

    // Update is called once per frame
    void Start()
    {
        _controller = GetComponent<Rigidbody>();
        _velocity = Random.Range(velocityBreak.x,velocityBreak.y);
        _rare = Random.Range(0,100);
    }
    void Update()
    {
        if (_rare > 1)
            _controller.linearVelocity = _velocity*Vector3.forward*Time.deltaTime;
        else
            _controller.linearVelocity = (50*Vector3.forward*Time.deltaTime);
    }

    /*void OnCollisionEnter(Collision collision)
    {
        Debug.Log("collision detected: " + collision.gameObject.name);
        CharacterController controller = collision.gameObject.GetComponent<CharacterController>();

        controller.Move(25*Vector3.right*Time.deltaTime);
    }*/
}
