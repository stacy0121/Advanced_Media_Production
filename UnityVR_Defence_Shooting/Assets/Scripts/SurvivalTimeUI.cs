using UnityEngine;
using TMPro;

public class SurvivalTimeUI : MonoBehaviour
{
	private	float			startTime;
	private	TextMeshProUGUI	textUI;

	private void Awake()
	{
		textUI = GetComponent<TextMeshProUGUI>();
	}
	
	// ���� �ð� ���� UI
	private void OnEnable()
	{
		startTime = Time.time;
	}

	private void Update()
	{
		textUI.text = $"Survival Time\n{Time.time - startTime:0.0}s";
	}
}
