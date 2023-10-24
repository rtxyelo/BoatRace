using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundBehaviour : MonoBehaviour
{
	private RectTransform _rectTransform;
	public float Speed = 10.0f; // �������� �������� ������


	// Start is called before the first frame update
	void Start()
    {
		// �������� ��������� RectTransform �������� �������
		_rectTransform = GetComponent<RectTransform>();
	}

    // Update is called once per frame
    void Update()
    {
		// �������� ������� ���������� RectTransform
		Vector3 _position = _rectTransform.anchoredPosition;

		// ������� ��������� ����� (��� � ������ �����������) � ���������� ���������
		transform.Translate(Vector3.down * Speed * Time.deltaTime);

		Debug.Log("_position.y" + _position.y);

		// ���� ������ ����� �� ������� ������, ����������� �� ������� � ��������� �������
		if (_position.y <= -4000f) // ����� -10.0f - ��� ��������� ����������, �� ������� ������ ������ ������������
		{
			// ����������� ��������� � ��������� �������
			_rectTransform.anchoredPosition = new Vector3( _position.x, 4000f, _position.z);
		}
	}
}

