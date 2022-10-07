using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
	public float timeValue = 90;

	public TextMeshProUGUI counter;
	public GameOverMenu end;
    // Update is called once per frame
    void Update()
    {
        if (timeValue > 0 && !GameOverMenu.isGameOver)
		{
			timeValue -= Time.deltaTime;
		}
		else
		{
			timeValue = 0;
			end.GameOver();
		}
		DisplayText(timeValue);
    }

	void DisplayText(float timeToDisplay)
	{
		if (timeToDisplay < 0)
		{
			timeToDisplay = 0;
		}

		float minutes = Mathf.FloorToInt(timeToDisplay / 60);
		float seconds = Mathf.FloorToInt(timeToDisplay % 60);

		counter.SetText(minutes + " : " + seconds);
	}
}
