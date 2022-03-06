using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {

	public float jumpForce = 10f;

	public Rigidbody2D rb;
	public SpriteRenderer sr;
	public int score;
	public TextMeshProUGUI scoreText;
	public TextMeshProUGUI gameOverPanelText;
    public GameObject gameoverPanel;
	public string currentColor;

	public Color[] playercolors;
	

	void Start ()
	{
		gameoverPanel.SetActive(false);
		SetRandomColor();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Jump") || Input.GetMouseButtonDown(0))
		{
			rb.velocity = Vector2.up * jumpForce;
		}
	}
// 
	void OnTriggerEnter2D (Collider2D col)
	{
		if (col.tag == "ColorChanger")
		{
			SetRandomColor();
			
			Destroy(col.gameObject);
			return;
		}

		if (col.tag != currentColor && col.tag !="Star")
		{
			gameoverPanel.SetActive(true);
			
		}
		if (col.tag == "Star")
		{
			score++;
			scoreText.text=score.ToString();
			gameOverPanelText.text=score.ToString();
			Destroy(col.gameObject);
		}
	}

	void SetRandomColor ()
	{
		int index = Random.Range(0, 4);

		switch (index)
		{
			case 0:
				currentColor = "blue";
				sr.color = playercolors[0];
				break;
			case 1:
				currentColor = "yellow";
				sr.color = playercolors[1];
				break;
			case 2:
				currentColor = "purple";
				sr.color = playercolors[2];
				break;
			case 3:
				currentColor = "pink";
				sr.color = playercolors[3];
				break;
		}
	}
}
