using UnityEngine;
using System.Collections;


public class mount : MonoBehaviour {

	mc mmc;  // 摄像机绑定脚本

	UnityEngine.UI.Text tt;   // 显示文字组件

	reStart rs; // 结束界面

	// Use this for initialization
	void Start () {
		tt = GameObject.Find ("/Canvas/countLable").GetComponent<UnityEngine.UI.Text> ();
		mmc = GameObject.Find ("Main Camera").GetComponent<mc> ();
		rs = GameObject.Find ("floor").GetComponent<reStart> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.y < 0) {
			int bc = mmc.bulletSend_Count;
			int dc = mmc.dead_Count++;

			tt.text = "发射子弹:   " + bc + "   阵亡人数:   "+ dc;

			// 游戏结束
			if(dc >= 20){  
				tt.text = "恭喜过关";
				mmc.enabled = false;
				rs.enabled = true;
			}

			Destroy (gameObject);
		}
	}
}
