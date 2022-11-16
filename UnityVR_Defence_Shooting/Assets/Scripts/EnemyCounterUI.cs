using UnityEngine;
using TMPro;

public class EnemyCounterUI : MonoBehaviour
{
	private	int				killCount;
	private	int				spawnCount;
	private	TextMeshProUGUI	textUI;

	private void Awake()
	{
		textUI = GetComponent<TextMeshProUGUI>();
	}

	private void OnEnable()
	{
		killCount = spawnCount = 0;

		UpdateUI();
	}

	// 적 정보를 UI에 출력
	private void UpdateUI()
	{
		if ( !enabled ) return;

		textUI.text = $"Kill/Alive/Spawn\n{killCount}/{spawnCount-killCount}/{spawnCount}";
	}

	public void OnSpawn()
	{
		spawnCount ++;

		UpdateUI();
	}

	public void OnKill()
	{
		killCount ++;

		UpdateUI();
	}
}

