using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{

	public float speed;
	private int count = 0;

	public Text scoreText;
	public Text WinText;
	private Rigidbody rigidbody;

	// Use this for initialization
	void Start()
	{

		rigidbody = GetComponent<Rigidbody>();

	}

	void FixedUpdate()
	{

		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");

		Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

		rigidbody.AddForce(movement * speed * Time.deltaTime);

	}

	// Update is called once per frame
	void Update()
	{

	}

	void LateUpdate()
	{

	}

	void OnTriggerEnter(Collider other)
	{

		if (other.gameObject.tag == "PickUp")
		{
			other.gameObject.SetActive(false);
			count += 1;
			SetCountText();


		}
	}

	void SetCountText()
	{
		
		scoreText.text = "Score : " + count;

		//Check whether you have all the pickups

		if (count >= 23)
		{
			WinText.gameObject.SetActive(true);
			WinText.text = " You Win !!! ";
		}
	}
}
