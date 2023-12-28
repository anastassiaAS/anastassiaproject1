using UnityEngine;
using System.Collections;

public class NPC_1 : NPC {
	 
	// Use this for initialization
	public override void OnSetUpDialogue() {
		Speech.AddDialogue("0", "Welcome to this magical world!", "1");
		Speech.AddDialogue("1", "Your first task will be to collect all coins", "2");
		Speech.AddDialogue("2", "Your second task will be to collect double jump skills", "3");
		Speech.AddDialogue("3", "Only after completing these tasks you will be able to go to the next level", "4");
		Speech.AddDialogue("4", "You will have 3 levels", "5");
		Speech.AddDialogue("5", "Good luck!");

	}

	// Triggered when the player comes in range of the NPC
	public override void OnTriggerNPC( Collider other ){
		Speech.SetDialogue("0");
	}
}