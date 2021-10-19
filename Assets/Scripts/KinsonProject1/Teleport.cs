using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    [SerializeField] private Transform teleportTarget;
    [SerializeField] private GameObject _player;

    public void OnTriggerEnter(Collider other)
    {
        _player.transform.position = teleportTarget.transform.position;
    }
}
