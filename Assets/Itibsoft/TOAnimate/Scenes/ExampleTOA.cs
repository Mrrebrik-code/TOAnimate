using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Itibsoft.TOAnimate;

public class ExampleTOA : MonoBehaviour
{
	[SerializeField] private Image _image;
	private bool _isFadering = false;
	public void Update()
	{
		if (Input.GetKeyDown(KeyCode.Space) && _isFadering == false)
		{
			_isFadering = true;
			_image.TOAFade(_image.color.a == 1 ? 0 : 1, 1f, () => 
			{ 
				Debug.Log("Animation TOAFade to image complet!");
				_isFadering = false;
			});
		}
	}
}
