using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GenerateEnemies : MonoBehaviour {

	float time = 0;
	float scaleMultiplier = 1;

	public GameObject player;

	public GameObject newEnemy1;
	public GameObject newEnemy2;
	public GameObject newEnemy3;
	public GameObject newEnemy4;
		
	private Dictionary<GameObject, float> enemies = new Dictionary<GameObject, float>();

	// Use this for initialization
	void Start () {

		enemies.Add (newEnemy1, 1f);
		enemies.Add (newEnemy2, 2f);
		enemies.Add (newEnemy3, 3f);
		enemies.Add (newEnemy4, 4f);
	}
	
	// Update is called once per frame
	void Update () {

		time++;
		if(time > 600)
		{
			time = 0;

			List<int> numberOf = ChooseHowMany();

			for(int i = 0; i < enemies.Count; i++)
			{
				for(int j = 0; j < numberOf[0]; j++)
				{
					GameObject clone = (GameObject) Instantiate(enemies[0], new Vector3(Random.Range(-17f, 17f), Random.Range(-10f,10f), 0), new Quaternion(0,0,0,0));

					clone.SetActive(true);
				}
			}

			//GameObject clone = (GameObject) Instantiate(newEnemy, new Vector3(Random.Range(-17f, 17f), Random.Range(-10f,10f), 0), new Quaternion(0,0,0,0));

			//clone.SetActive(true);

			/*Vector3 newScale = new Vector3(scaleMultiplier, scaleMultiplier, 0f);

			newEnemy.transform.localScale = newScale;

			scaleMultiplier += .1f;*/

		}
	}

	//
	List<int> ChooseHowMany()
	{
		List<int> numberOf;
		numberOf.Add (Random.Range (3, 7));
		numberOf.Add (Random.Range (1, 4));
		numberOf.Add (Random.Range (1, 4));
		numberOf.Add (Random.Range (1, 3));

		return numberOf;
	}
}
