using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine.UI;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int bulletSpeed;
    Transform _ComponentTransform;
    void Awake()
    {
        _ComponentTransform = GetComponent<Transform>();
    }
    void Update()
    {
        _ComponentTransform.position = new Vector2(_ComponentTransform.position.x, _ComponentTransform.position.y + bulletSpeed * Time.deltaTime);
        if (_ComponentTransform.position.y > 5.5)
        {
            Destroy(this.gameObject);
        }
    }

}
