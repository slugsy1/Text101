using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="State")]
public class State : ScriptableObject
{
    [TextArea(10,14)] [SerializeField] string stateText;
    [SerializeField] State[] nextState;
    public string GetStateStory()
    {
        return stateText;
    }
    public State[]GetNextState()
    {
        return nextState;
    }
}
