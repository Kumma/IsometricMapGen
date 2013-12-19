using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MapGen : MonoBehaviour {

	public GameObject block01;
	public GameObject block02;
	public GameObject block03;
	public GameObject block04;
	public GameObject block05;
	public GameObject block06;

	public Vector3 startPosition = new Vector3(5, 0, 5);

	//  X 				ARRAYS CAN BE ANY SIZE
	//  |    Z->
	//  V
	//
	// 0 = blue; 1 = cyan; 2 = green; 3 = purple; 4 = red; 5 = yellow;
	private int[][] map = new int[][] {
		new int[] {3, 3, 3, 3, 3},
		new int[] {3, 1, 0, 1, 3},
		new int[] {3, 0, 1, 0, 3},
		new int[] {3, 1, 0, 1, 3, 0},
		new int[] {3, 0, 1, 0, 3, 1},
		new int[] {3, 1, 0, 1, 3, 1},
		new int[] {3, 3, 3, 3, 3, 0}
	};



	void Start () {
		GenerateMap ();
	}


	void Update () {


	}

	void GenerateMap () {

		Vector3 newPosition = startPosition;

		for (int i = 0; i < map.Length; i++) {
			for (int j = 0; j < map [i].Length; j++) {

				switch (map[i][j]) {
				case 0:{
					GameObject mapTile = Instantiate (block01, newPosition, Quaternion.identity) as GameObject;
					mapTile.transform.parent = transform;
					break;
				}
				case 1: {
					GameObject mapTile = Instantiate (block02, newPosition, Quaternion.identity) as GameObject;
					mapTile.transform.parent = transform;
					break;
				}
				case 2: {
					GameObject mapTile = Instantiate (block03, newPosition, Quaternion.identity) as GameObject;
					mapTile.transform.parent = transform;
					break;
				}
				case 3: {
					GameObject mapTile = Instantiate (block04, newPosition, Quaternion.identity) as GameObject;
					mapTile.transform.parent = transform;
					break;
				}
				case 4: {
					GameObject mapTile = Instantiate (block05, newPosition, Quaternion.identity) as GameObject;
					mapTile.transform.parent = transform;
					break;
				}
				case 5: {
					GameObject mapTile = Instantiate (block06, newPosition, Quaternion.identity) as GameObject;
					mapTile.transform.parent = transform;
					break;
				}
				
				}
				newPosition.z++;
			}
			newPosition.z = startPosition.z;
			newPosition.x++;
		}
	}
}