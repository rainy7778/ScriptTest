using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {
    void Start()
    {
        // 要素数5の配列を初期化する
        int[] array = new int[5];

        // 配列の各要素に値を代入する
        array[0] = 10;
        array[1] = 20;
        array[2] = 30;
        array[3] = 40;
        array[4] = 50;

        // 配列の要素をすべて表示する
        Debug.Log(array[0]);
        Debug.Log(array[1]);
        Debug.Log(array[2]);
        Debug.Log(array[3]);
        Debug.Log(array[4]);

        for(int i = 4; i > -1; i--) {
            Debug.Log(array[i]);
        }
    
}

    void Update () {
		
	}
}
