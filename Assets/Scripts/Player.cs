﻿using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
	// コンポーネントを取得
	Spaceship spaceship;
	
	IEnumerator Start ()
	{
		// コンポーネントを取得
		spaceship = GetComponent<Spaceship> ();
		
		while (true) {
			
			// 弾をプレイヤーと同じ位置/角度で作成
			spaceship.Shot (transform);
			
			// shotDelay秒待つ
			yield return new WaitForSeconds (spaceship.shotDelay);
		}
	}
	
	void Update ()
	{
		// 右・左
		float x = Input.GetAxisRaw ("Horizontal");
		
		// 上・下
		float y = Input.GetAxisRaw ("Vertical");
		
		// 移動する向きを求める
		Vector2 direction = new Vector2 (x, y).normalized;
		// 移動
		spaceship.Move (direction);
	}

	void OnMouseDown()
	{
		Debug.Log("OnMouseDown");
		spaceship.Explosion();
		Destroy(gameObject);
	}

	// ぶつかった瞬間に呼び出される
	void OnTriggerEnter2D (Collider2D c)
	{
		// 弾の削除
		Destroy(c.gameObject);
		
		// 爆発する
		spaceship.Explosion();
		
		// プレイヤーを削除
		Destroy (gameObject);
	}
}