using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardDisplay : MonoBehaviour {
	public Card card;
	public Text descText;

	void Start()
	{
		descText.text = card.description;
	}
}
