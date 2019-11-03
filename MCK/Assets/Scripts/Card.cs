using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Card", menuName = "Card")]
public class Card : ScriptableObject {
	public string name;
	public int damage;
	public int strength;
	public string description;
	public Sprite cardBack;
}
