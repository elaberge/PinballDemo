using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
    public Vector2 springForce;
    public Collider2D hellCollider;
    public UnityEngine.UI.Text scoreText;
    private bool inGame;
    private Vector2 startPosition;
    private int score = 0;
    

	// Use this for initialization
	void Start () {
        inGame = false;
        startPosition = transform.position;
        scoreText.text = 0.ToString();
    }
	
	// Update is called once per frame
	void Update () {
		if (!inGame && Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody2D>().AddForce(springForce, ForceMode2D.Impulse);
            inGame = true;
        }
	}

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == hellCollider)
        {
            var body = GetComponent<Rigidbody2D>();
            inGame = false;
            body.MovePosition(startPosition);
            body.velocity = Vector2.zero;
            score -= 100;
            scoreText.text = score.ToString();
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (inGame)
        {
            score += 10;
            scoreText.text = score.ToString();
        }
    }
}
