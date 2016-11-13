using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class enemy : MonoBehaviour {
	
	private static float maxHealth = 18;
	private float health = maxHealth;
	private float speed = 0.04f;
	private float attackSpeed = 2f;
	private float timeLeftAttack = 1; //attack time
	private float deathTime = 1; //attack time
	private bool move = true;
	private bool dead = false;
	private bool attacking = false;
	private GameObject currentEnemy = null;
	// Use this for initialization

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (gameObject.name == "monster2") {
			return;
		}
		var pos = transform.position;
		if(move && !dead)
			pos.x -= speed;
		
		transform.position = pos;

		if (pos.x < -12.2f) {
			//Destroy (gameObject);
		}

		timeLeftAttack -= Time.deltaTime;
		if(timeLeftAttack < 0 && !dead)
		{
			float damage = Random.Range (0f, 4f);
			float critical = Random.Range (0f, 100f);
			if (critical > 80f)
				damage = 4f;
			attack (damage, currentEnemy);
			timeLeftAttack = 1;
		}

		if (health <= 0) {
			deathTime -= Time.deltaTime;
			dead = true;
			if (deathTime < 0) {
				var unitPos = gameObject.transform.position;
				unitPos.y += 200;
				gameObject.transform.position = unitPos;
				Destroy (gameObject, 3);
			}
		}
	}

	void OnCollisionStay2D(Collision2D coll) {
		if (move == false)
			return;
		
		if (coll.gameObject.tag == "unit") {
			//coll.gameObject.SendMessage("ApplyDamage", 10);
			Debug.Log ("unit hit!");
			move = false;
			Debug.Log("ally hit, not moving");
			attacking = true;
			currentEnemy = coll.gameObject;
		}
	}

	void OnCollisionEnter2D(Collision2D coll) {
		if (coll.gameObject.tag == "enemy") {
			//coll.gameObject.SendMessage("ApplyDamage", 10);
			//attacking = false;
			Debug.Log("ally hit, not moving");
			move = false;
			//currentEnemy = null;
		}

	}

	void OnCollisionExit2D(Collision2D coll) {
		if (coll.gameObject.tag == "unit") {
			move = true;
			attacking = false;
			currentEnemy = null;
		}
		else if (coll.gameObject.tag == "enemy") {
			//coll.gameObject.SendMessage("ApplyDamage", 10);
			//attacking = false;
			move = true;
			Debug.Log("ally moved, moving");
			//currentEnemy = null;
		}

	}

	void ApplyDamage(float damage) {
		health -= damage;
		Image image = gameObject.transform.GetChild(0).transform.GetComponent<Image>();
		image.fillAmount = 1f * (health/maxHealth);
		Text text = gameObject.transform.GetChild(2).GetComponent<Text>();
		text.text = damage.ToString("0");
		//RectTransform ob = (RectTransform)gameObject.transform.GetChild (0);
		//ob.sizeDelta = new Vector2( (float)(2.13 * (health/maxHealth)), ob.rect.height);

	}

	void attack(float damage, GameObject go) {
		if(go != null)
			go.SendMessage("ApplyDamage", damage);
	}
}
