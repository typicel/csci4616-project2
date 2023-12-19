using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameEventManager : MonoBehaviour
{
    public static GameEventManager current;
    // Start is called before the first frame update
    public void Awake()
    {
        current = this;
    }

    public event Action onTargetHit;
    public void TargetHit()
    {
        if (onTargetHit != null)
        {
            onTargetHit();
        }
    }

    public event Action<string> onUpdateText;
    public void UpdateText(string text)
    {
        if (onUpdateText != null)
        {
            onUpdateText(text);
        }
    }

	public event Action onResetGame;
	public void ResetGame()
	{
		if(onResetGame != null){
			onResetGame();
		}
	}

}
