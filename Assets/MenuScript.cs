using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class MenuScript : MonoBehaviour {

	public Text menuText;

	public void StartGameEvent()
	{
		//Application.LoadLevel ("level1");
		SceneManager.LoadScene("level1");
	}

	public void rollOverEvent(Button button)
	{
		//Application.LoadLevel ("level1");
		if (button.name == "shopButton") {
			menuText.text = "Spend your gold on new troops and equipment";
		}
		if (button.name == "villagersButton") {
			menuText.text = "View your current troops";
		}
		if (button.name == "exploreButton") {
			menuText.text = "Explore and fight other tribes";
		}
		if (button.name == "challengesButton") {
			menuText.text = "Fight the top tier tribes";
		}

	}
}