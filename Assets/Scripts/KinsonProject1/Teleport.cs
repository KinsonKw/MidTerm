using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    [SerializeField] private CharacterController _controller = null;
    [SerializeField] private Transform teleportTarget;
    [SerializeField] private GameObject _player;

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            _controller.enabled = false;
            _player.transform.position = teleportTarget.position;
            _controller.enabled = true;

            Debug.LogError("Teleport");
        }
    }
    
}
