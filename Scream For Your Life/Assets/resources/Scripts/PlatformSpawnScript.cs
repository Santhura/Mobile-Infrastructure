using UnityEngine;
using System.Collections;

public class PlatformSpawnScript : MonoBehaviour {

    public GameObject platformPrefab;               // prefab of a platform
    public Transform playerPos;                     // players position

    private float minX = -6, maxX = 6;

    private Vector2 playerOldPos;

    public bool canSpawn;

    private int amountSpawn;

	// Use this for initialization
	void Start () {
        canSpawn = false;
        amountSpawn = 0;
        playerPos = GameObject.FindWithTag("Player").transform;
        
	}
	
	// Update is called once per frame
	void Update () {

        if (!canSpawn)
        {
            if (playerPos.position.y <= playerOldPos.y)
            {
                amountSpawn = 0;
                canSpawn = true;
            }
        }
        else
        {
            if (playerPos.position.y > playerOldPos.y && amountSpawn < 1)
            {
                amountSpawn++;
                Instantiate(platformPrefab, new Vector3(Random.Range(minX, maxX), playerPos.position.y + 5, 0), Quaternion.identity);
                playerOldPos = playerPos.position;
                canSpawn = false;
            }
        }
        Debug.Log("player pos: " + playerPos.position.y + "\nplayer old pos: " + playerOldPos.y);

	}
}
