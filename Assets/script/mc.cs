using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class mc : MonoBehaviour {

	public GameObject newobject;

	public int bulletSend_Count = 0;

	public int dead_Count = 0;

	Text textCC;

	// Use this for initialization
	void Start () {
//		GameObject.Find ("Directional Light").GetComponent<Light> ().enabled = true;
		textCC = GameObject.Find ("/Canvas/countLable").GetComponent<Text> ();
		textCC.text = "发射子弹:   " + bulletSend_Count + "   阵亡人数:   "+ dead_Count;
	}

	void Update () {
		float x = Input.GetAxis ("Horizontal") * Time.deltaTime * 5;   
		float z = Input.GetAxis ("Vertical") * Time.deltaTime * 5;  
		float y = 0;

		if(Input.GetKey(KeyCode.Z)){
			y = 25 * Time.deltaTime;
		}

		if(Input.GetKey(KeyCode.X)){
			y = -25 * Time.deltaTime;
		}

		transform.Translate(x,y,z);

		if(Input.GetButtonDown("Fire1")){
			GameObject n = Instantiate(newobject,transform.position,transform.rotation) as GameObject;
			n.GetComponent<Rigidbody>().AddForce(Vector3.forward * 2800);
			bulletSend_Count++;
			textCC.text = "发射子弹:   " + bulletSend_Count + "   阵亡人数:   "+ dead_Count;
		}

		if(Input.GetKey(KeyCode.Q)){
			transform.Rotate (0, -25 * Time.deltaTime, 0,Space.Self);
		}

		if(Input.GetKey(KeyCode.E)){
			transform.Rotate (0, 25 * Time.deltaTime, 0,Space.Self);
		}


	}
}
