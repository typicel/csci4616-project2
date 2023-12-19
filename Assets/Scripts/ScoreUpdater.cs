using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreUpdater : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameEventManager.current.onUpdateText += UpdateScoreText;
    }

    public void UpdateScoreText(string text)
    {
		var textComp = GetComponentInChildren<TextMeshProUGUI>();
		textComp.text = text;
    }
}
