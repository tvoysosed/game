using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BlueRedFade : MonoBehaviour {

    private Image background;
    private float speed = 1.0f;


    // Используем для инициализации
    void Start () {
        background = gameObject.GetComponent<Image>();
    }
	
	// Обновляем картинку один раз за кадр  
	void Update () {

        float t = (Mathf.Sin(Time.time * speed) + 1) / 2.0f;

        background.color = Color.Lerp(Color.red, Color.blue, t);

    }
}
