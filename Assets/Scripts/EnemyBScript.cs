using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBScript : MonoBehaviour {

	public GameObject enemyA;//生成される敵
	float timer = 0;//enemyBが消えるタイミングを計る変数

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		InvokeRepeating ("enemyAInstantiate", 0.5f, 2.0f);//関数enemyAInstantiateを2.0fごとに呼ぶ
		timer += 1;//timerの値を１ずつ増やしていく

		//timerの値が50になったらenemyB消す
		if (timer == 50) {
			Destroy (gameObject);
		}
	}

	//enemyAを生成する関数
	void enemyAInstantiate(){
		Instantiate (enemyA,new Vector3(0,0,4),Quaternion.identity);
	}


}
