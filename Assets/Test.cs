using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//発展課題
public class Boss{
	private int mp = 53;		//mp

	//魔法攻撃用の関数
	public void Magic(){

		if (this.mp >= 5) {
			//mpが5以上の場合
			//残りmpを減らす
			this.mp -= 5;
			//残りmpを表示
			Debug.Log ("魔法攻撃をした。残りMPは" + this.mp + "。");
		} else {
			//mpが5未満の場合
			Debug.Log ("MPが足りないため魔法が使えない。");
		}
	}
}

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {

		//課題
		//要素数5の配列を初期化する
		int[] array = {100,50,88,97,568};

		//配列の要素を順番に表示する
		//配列の要素数の分だけ処理を繰り返す
		for (int i = 0; i < 5; i++) {
			//配列の要素を表示する
			Debug.Log (array [i]);
		}

		//配列の要素を逆順に表示する
		//配列の要素数の分だけ逆から処理を繰り返す
		for (int i = 4; i >= 0; i--){
			//配列の要素を表示する
			Debug.Log(array [i]);
		}

		//発展課題つづき
		//Bossクラスの変数を宣言してインスタンスを代入
		Boss lastboss = new Boss();

		//魔法攻撃用の関数を呼び出して処理を10回行う
		for (int i = 0; i < 10; i++) {
			lastboss.Magic ();
		}

		//mpが足りない場合のメッセージが表示されるかの確認
		lastboss.Magic ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
