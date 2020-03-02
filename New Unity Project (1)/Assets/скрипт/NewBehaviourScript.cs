using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
	public float speed = 20f;
	private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
	rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    { 
	float moveX = Input.GetAxis("Horizontal");
	transform.Translate(Vector3.left * moveX * Time.deltaTime);

        float moveY = Input.GetAxis("Vertical");
	transform.Translate(Vector3.up * moveY * 5.0f * Time.deltaTime);
	}
}