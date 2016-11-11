using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class Prospector : MonoBehaviour {
	static public Prospector S;
	public Deck	deck;
	public TextAsset  deckXML;

	public Layout layout;
	public TextAsset layoutXML;

	void Awake() {
		S = this; // Set up a Singleton for Prospector
	}

	void Start()  {
		deck = GetComponent<Deck>();  // Get the deck
		deck.InitDeck (deckXML.text);  // Pass deckXML to it
		Deck.Shuffle (ref deck.cards); // This shiffles the deck
		// the ref keyword passes a reference to deck.cards, which allows deck.suffle to modify it

		layout = GetComponent<Layout> ();  //get the layout
		layout.ReadLayout (layoutXML.text);  // Passs LayoutXML to it

	}
}
