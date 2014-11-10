using UnityEngine;
using System.Collections;

public class GenerateEnemies : MonoBehaviour {

	float time = 0;
	float scaleMultiplier = 1;

	public GameObject newEnemy;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		time++;
		if(time > 600)
		{
			time = 0;



			GameObject clone = (GameObject) Instantiate(newEnemy, new Vector3(Random.Range(-17f, 17f), Random.Range(-10f,10f), 0), new Quaternion(0,0,0,0));

			clone.SetActive(true);

			/*Vector3 newScale = new Vector3(scaleMultiplier, scaleMultiplier, 0f);

			newEnemy.transform.localScale = newScale;

			scaleMultiplier += .1f;*/

		}
		
	}
}
