using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontroller : MonoBehaviour
{
    public float speed;

    private Rigidbody2D _Playerirgidboy; //to deal with conusion
    private float _MoveHorizontal;
    private float _MoveVertical;

    // Start is called before the first frame update
    void Start()
    {
        _Playerirgidboy = GetComponent<Rigidbody2D>();
    }
     void Update()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        _MoveHorizontal = Input.GetAxis("Horizontal");
        _MoveVertical = Input.GetAxis("Vertical");

        //Gives direction of player movement
        Vector2 movement = new Vector2(_MoveHorizontal, _MoveVertical);

        _Playerirgidboy.AddForce(movement * speed);
    }
}
