using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DriverScript : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] float steerSpeed = 1f;
    [SerializeField] float moveSpeed = 5f;
    [SerializeField] float slowSpeed = 3f;
    [SerializeField] float boostSpeed = 10f;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, moveAmount, 0);
    }

    private void OnTriggerEnter2D(Collider2D other) {
        
        if (other.tag == "SpeedUp") {
            moveSpeed = boostSpeed;
            
        }

        if (other.tag == "Slow") {
            moveSpeed = slowSpeed;
        }
    }

    private void OnCollisionEnter2D(Collision2D other) {
        moveSpeed = slowSpeed;
    }
}
