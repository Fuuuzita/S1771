using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ずっと、移動する（水平）
public class Forever_MoveH : MonoBehaviour {

	public float speedH = 1; // スピード：Inspectorで指定
	public float speedV = 1; // スピード：Inspectorで指定

	void FixedUpdate() { // ずっと行う（一定時間ごとに）
		this.transform.Translate(speedH / 50, speedV / 50, 0); // 水平移動する
	}
}
