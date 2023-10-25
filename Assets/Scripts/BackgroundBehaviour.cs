using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundBehaviour : MonoBehaviour
{
	public RectTransform RectTransform;
	public float Speed = 10.0f; // Скорость движения дороги


	// Start is called before the first frame update
	void Start()
    {
		// Получаем компонент RectTransform текущего объекта
		RectTransform = GetComponent<RectTransform>();
	}

    // Update is called once per frame
    void Update()
    {
		// Получаем позицию компонента RectTransform
		Vector3 _position = RectTransform.anchoredPosition;

		// Двигаем контейнер влево (или в другом направлении) с постоянной скоростью
		transform.Translate(Vector3.down * Speed * Time.deltaTime);

		//Debug.Log("_position.y" + _position.y);

		// Если дорога вышла за пределы экрана, переместите ее обратно в начальную позицию
		if (_position.y <= -4000f) // Здесь -10.0f - это примерное расстояние, на которое дорога должна перемещаться
		{
			// Переместите контейнер в начальную позицию
			RectTransform.anchoredPosition = new Vector3( _position.x, 4000f, _position.z);
		}
	}
}

