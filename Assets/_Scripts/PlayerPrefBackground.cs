using UnityEngine;
using System.Collections;

public class PlayerPrefBackground : MonoBehaviour {

    public Camera mainCamera;

	// Используем это для инициализации     
	void Start () {
        if (PlayerPrefs.HasKey("Vote"))
        {
            switch (PlayerPrefs.GetString("Vote"))
            {
                case "Trump":
                    mainCamera.backgroundColor = Color.red;
                    break;
                case "Clinton":
                    mainCamera.backgroundColor = Color.blue;
                    break;
                default:
                    break;
            }
        }
	}
	
	// Обновляем один раз за кадр
	void Update () {
	
	}
}
