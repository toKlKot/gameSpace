using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class shield100Proc : MonoBehaviour {

	public Image[] panelChoise;


	void Start () {
	
	}

	void Update () {
	
	}

	void clikShieldPorc()
	{
		setImageActivePanelChoise (true);

	}
	void clikShieldPorcPlus()
	{
		setImageActivePanelChoise (false);
	}
	public void setImageActivePanelChoise(bool active)
	{
		foreach (Image imgShielChoise in panelChoise)
		{
			imgShielChoise.gameObject.SetActive(active);

		}
	}


	 // reklama

	public void reklamaShield()
	{

	}



}
