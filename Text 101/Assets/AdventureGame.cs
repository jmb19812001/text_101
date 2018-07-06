using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
    [SerializeField]
    Text textComponent;
    [SerializeField]
    State StartingState;

     State state;



	// Use this for initialization
	void Start ()
    {
        state = StartingState;
        textComponent.text = state.GetStateStory();
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
