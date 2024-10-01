// The following is a list of c# scripts used in Captain Blaster
// TODO modify into use for MiNR

//Game Manager
using UnityEngine;
using UnityEngine.UI; // Note this new line is needed for UI

/*

public class GameManager : MonoBehaviour
{
	public Text scoreText;
	public Text gameOverText;

	int playerScore = 0;

	public void AddScore()
	{
		playerScore++;
		// This converts the score (a number) into a string
		scoreText.text = playerScore.ToString();
	}

	public void PlayerDied()
	{
		gameOverText.enabled = true;
		// This freezes the game
		Time.timeScale = 0;
	}
}

//General trigger script


public class DestroyOnTrigger : MonoBehaviour
{
	void OnTriggerEnter2D(Collider2D other)
	{
		Destroy(other.gameObject);
	}
}



//Spawning Meteor


public class MeteorSpawn : MonoBehaviour
{
	public GameObject meteorPrefab;
	public float minSpawnDelay = 1f;
	public float maxSpawnDelay = 3f;
	public float spawnXLimit = 6f;

	void Start()
	{
		Spawn();
	}

	void Spawn()
	{
		// Create a meteor at a random x position
		float random = Random.Range(-spawnXLimit, spawnXLimit);
		Vector3 spawnPos = transform.position + new Vector3(random, 0f, 0f);
		Instantiate(meteorPrefab, spawnPos, Quaternion.identity);

		Invoke("Spawn", Random.Range(minSpawnDelay, maxSpawnDelay));
	}
}
//Moving Meteor


public class MeteorMover : MonoBehaviour
{
	public float speed = -2f;

	Rigidbody2D rigidBody;

	void Start()
	{
		rigidBody = GetComponent<Rigidbody2D>();
		// Give meteor an initial downward velocity
		rigidBody.velocity = new Vector2(0, speed);
	}
}

//Control player ship


public class ShipControl : MonoBehaviour
{
	public GameManager gameManager;
	public GameObject bulletPrefab;
	public float speed = 10f;
	public float xLimit = 7f;
	public float reloadTime = 0.5f;

	float elapsedTime = 0f;

	void Update()
	{
		// Keeping track of time for bullet firing
		elapsedTime += Time.deltaTime;

		// Move the player left and right
		float xInput = Input.GetAxis("Horizontal");
		transform.Translate(xInput * speed * Time.deltaTime, 0f, 0f);

		// Clamp the ship�s x position
		Vector3 position = transform.position;
		position.x = Mathf.Clamp(position.x, -xLimit, xLimit);
		transform.position = position;

		// Spacebar fires. The default InputManager settings call this �Jump�
		// Only happens if enough time has elapsed since last firing.
		if (Input.GetButtonDown("Jump") && elapsedTime > reloadTime)
		{
			// Instantiate the bullet 1.2 units in front of the player
			Vector3 spawnPos = transform.position;
			spawnPos += new Vector3(0, 1.2f, 0);
			Instantiate(bulletPrefab, spawnPos, Quaternion.identity);

			elapsedTime = 0f; // Reset bullet firing timer
		}
	}

	// If a meteor hits the player
	void OnTriggerEnter2D(Collider2D other)
	{
		gameManager.PlayerDied();
	}
}

*/