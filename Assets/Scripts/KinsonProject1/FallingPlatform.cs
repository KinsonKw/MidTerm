using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingPlatform : MonoBehaviour
{
    [SerializeField] private float fallDelay = 1f;

    public Rigidbody rigidbody = null;

    private Vector3 startPosition;

    // Start is called before the first frame update
    void Start()
    {
        startPosition = rigidbody.transform.position;
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider collider)
    {

        if (collider.gameObject.tag == "Player")
        {
            StartCoroutine(PlatformFallDelay());
        }
    }
    private IEnumerator PlatformFallDelay()
    {
        yield return new WaitForSeconds(fallDelay);
        rigidbody.useGravity = true;
        Destroy(gameObject, 10);
    }

    public void resetPlaform()
    {
        rigidbody.useGravity = false;
        rigidbody.velocity = Vector3.zero;
        rigidbody.transform.position = startPosition;

        Debug.LogError("Reset");
    }


}
