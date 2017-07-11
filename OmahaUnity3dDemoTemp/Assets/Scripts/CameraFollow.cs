using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private GameObject _player;

	void Start ()
	{
	    _player = GameObject.FindGameObjectWithTag("Player");
        print(_player.ToString());
	}
    
    void LateUpdate()
    {
        transform.position = _player.transform.position;
    }
}
