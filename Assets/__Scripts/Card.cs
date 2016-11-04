using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Card : MonoBehaviour {

}

[System.Serializable]
public class Decorator  {
// This  class stores information from each  decorator or pip from deckXML
	public string  type; // for card types type = pips
	public Vector3 loc; // location of the sprite on the card
	public bool   flip = false;  // whether to flip the sprite vertically
	public float  scale = 1f; // the scale of the sprite

}

[System.Serializable]
public class CardDefinition  {
// this class stores information for each rank of card
	public string	face; // sprite to use for each face card
	public int		rank; // the rank (1-13) of the card
	public List<Decorator>	pips = new List<Decorator> ();  // pips used

}


