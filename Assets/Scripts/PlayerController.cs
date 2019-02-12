using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

    private Rigidbody rb;
    public float speed;
    private int scoreCount;
    public Text countText;
    public Text winText;


    void Start ()
    {
        rb = GetComponent<Rigidbody>();
        scoreCount = 0;
        setCountText();
    }
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(movement * speed);
    }
    void OnTriggerEnter(Collider other) {
       if (other.gameObject.CompareTag("cyanCube")) {
            other.gameObject.SetActive(false);
            scoreCount = scoreCount + 1;
            setCountText();
        } else if (other.gameObject.CompareTag("redCube")) {
            other.gameObject.SetActive(false);
      scoreCount = scoreCount + 2;
            setCountText();
        } else if (other.gameObject.CompareTag("magentaCube")) {
            other.gameObject.SetActive(false);
      scoreCount = scoreCount + 3;
            setCountText();
        } 
  }

    void setCountText()
    {
        countText.text = "Score: " + scoreCount.ToString();

    }
}
