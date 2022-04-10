using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroMain : MonoBehaviour
{
    [SerializeField] private float _speed;
    public static HeroMain instance;
    private static readonly int IsGoing = Animator.StringToHash("isGoing");
    private static readonly int directionX = Animator.StringToHash("directionX");
    private static readonly int directionY = Animator.StringToHash("directionY");
    private Vector2 _direction;
    private Rigidbody2D _rigidbody;
    private Animator _animation;
    private bool _isGoing;
    public int flag = 1;

    private void Awake() {
        _rigidbody = GetComponent<Rigidbody2D>();
        _animation = GetComponent<Animator>();
    }
    public void SetDirection(Vector2 direction){
            _direction = direction;
        
    }

    private void Start()
    {
        instance = this;
    }

    private void FixedUpdate() {
        
            
            _rigidbody.velocity = new Vector2(_direction.x * _speed, _direction.y * _speed);
            if (_rigidbody.velocity.x != 0 || _rigidbody.velocity.y != 0) { _isGoing = true; }
            else { _isGoing = false; }

            _animation.SetBool(IsGoing, _isGoing);
            _animation.SetFloat(directionX, _rigidbody.velocity.x);
            _animation.SetFloat(directionY, _rigidbody.velocity.y);

            UpdateSpriteDirection();
        
    }


    private void UpdateSpriteDirection(){
            if (_direction.x > 0)
            {
                transform.localScale = new Vector3(-1.75f, 1.75f, 1);
            }
            else if (_direction.x < 0)
            {
                transform.localScale = new Vector3(1.75f, 1.75f, 1);
            }
       
    }
}
