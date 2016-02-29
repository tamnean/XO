using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Manager : MonoBehaviour {
	private int numCheck=1;
	private bool click;
	private string XO;
	private int a1=0;
	private int a2=0;
	private int a3=0;
	private int b1=0;
	private int b2=0;
	private int b3=0;
	private int ab=0;
	private int ba = 0;
	private int checkDraw=0;

	public Text A11;
	public Text A12;
	public Text A13;
	public Text A21;
	public Text A22;
	public Text A23;
	public Text A31;
	public Text A32;
	public Text A33;
	
	public Button a, b, c, d, e, f, g, h, i;

	public GameObject Xwin;
	public GameObject Owin;
	public GameObject Draw;

	void Start () {

	}

	void Update () {
		numCheck = numCheck % 2;
		onClickChange ();
		OnWinLoseDraw ();
	}

	public void onClickChange(){
		if(numCheck ==1)
			XO="X";
		else if (numCheck==0)
			XO="O";
	}

	public void On11(){
		numCheck += 1;
		a.enabled = false;
		A11.text = XO;
		checkDraw += 1;
		if (A11.text == "X") {
			a1 += 1;
			b1 += 1;
			ab +=1;
		} else if (A11.text == "O") {
			a1 -= 1;
			b1 -= 1;
			ab -= 1;
		}
	}
	public void On12(){
		numCheck += 1;
		b.enabled = false;
		A12.text = XO;
		checkDraw += 1;
		if (A12.text == "X") {
			a1 += 1;
			b2 += 1;
		} else if (A12.text == "O") {
			a1 -= 1;
			b2 -= 1;
		}
	}
	public void On13(){
		numCheck += 1;
		c.enabled = false;
		A13.text = XO;
		checkDraw += 1;
		if (A13.text == "X") {
			a1 += 1;
			b3 += 1;
			ba +=1;
		} else if (A13.text == "O") {
			a1 -= 1;
			b3 -= 1;
			ba -= 1;
		}
	}
	public void On21(){
		numCheck += 1;
		d.enabled = false;
		A21.text = XO;
		checkDraw += 1;
		if (A21.text == "X") {
			a2 += 1;
			b1 += 1;
		} else if (A21.text == "O") {
			a2 -= 1;
			b1 -= 1;
		}
	}
	public void On22(){
		numCheck += 1;
		e.enabled = false;
		A22.text = XO;
		checkDraw += 1;
		if (A22.text == "X") {
			a2 += 1;
			b2 += 1;
			ab += 1;
			ba += 1;
		} else if (A22.text == "O") {
			a2 -= 1;
			b2 -= 1;
			ab -= 1;
			ba -= 1;
		}
	}
	public void On23(){
		numCheck += 1;
		A23.text = XO;
		checkDraw += 1;
		f.enabled = false;
		if (A23.text == "X") {
			a2 += 1;
			b3 += 1;
		} else if (A23.text == "O") {
			a2 -= 1;
			b3 -= 1;
		}

	}
	public void On31(){
		numCheck += 1;
		g.enabled = false;
		A31.text = XO;
		checkDraw += 1;
		if (A31.text == "X") {
			a3 += 1;
			b1 += 1;
			ba += 1;
		} else if (A31.text == "O") {
			a3 -= 1;
			b1 -= 1;
			ba -= 1;
		}
	}
	public void On32(){
		numCheck += 1;
		checkDraw += 1;
		A32.text = XO;
		h.enabled = false;
		if (A32.text == "X") {
			a3 += 1;
			b2 += 1;
		
		} else if (A32.text == "O") {
			a3 -= 1;
			b2 -= 1;
		}
	}
	public void On33(){
		numCheck += 1;
		i.enabled = false;
		A33.text = XO;
		checkDraw += 1;
		if (A33.text == "X") {
			a3 += 1;
			b3 += 1;
			ab += 1;
		} else if (A33.text == "O") {
			a3 -= 1;
			b3 -= 1;
			ab -= 1;
		}
	}

	void OnWinLoseDraw(){
		if (a1 == 3 || a2 == 3 || a3 == 3 || b1 == 3 || b2 == 3 || b3 == 3 || ab == 3 || ba == 3) {
			Debug.Log ("X Win");
			Xwin.SetActive(true);
			Invoke ("OnLoad",3);
		} else if (a1 == -3 || a2 == -3 || a3 == -3 || b1 == -3 || b2 == -3 || b3 == -3 || ab == -3 || ba == -3) {
			Debug.Log ("O Win");
			Owin.SetActive(true);
			Invoke ("OnLoad",3);
		}
		else if(checkDraw==9){
			Draw.SetActive(true);
			Invoke ("OnLoad",3);
			checkDraw =0;
		}
	}

	void OnLoad(){
		Application.LoadLevel (0);

	}
}
