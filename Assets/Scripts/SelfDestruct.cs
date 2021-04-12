using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestruct : MonoBehaviour
{
    [SerializeField] float timeUntillDestroy = 3f;

    // Start is called before the first frame update
    private void Start() {
        Destroy(gameObject, timeUntillDestroy);
    }
}
