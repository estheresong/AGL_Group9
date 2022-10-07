using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
	public Transform player;
	public Transform spawnPoint;

	public void Respawn()
	{
		player.position = spawnPoint.position;
	}
}
