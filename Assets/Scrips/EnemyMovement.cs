using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class EnemyMovement : MonoBehaviour
{
    int points;
    public GameManager gameManager;
    public GameObject prefabExplotion;

    public float enemyShipSpeed;
    Transform _ComponentTransform;
    // Start is called before the first frame update
    void Awake()
    {
        _ComponentTransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        _ComponentTransform.position = new Vector2(_ComponentTransform.position.x, _ComponentTransform.position.y - 1 * enemyShipSpeed * Time.deltaTime);
        if (_ComponentTransform.position.y <= -6.5)
        {
            Destroy(this.gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            gameManager.UpdateScore(100);
            Instantiate(prefabExplotion, transform.position, transform.rotation);
            Destroy(this.gameObject);
            Destroy(collision.gameObject);
        }
    }
    public void SetGameManager(GameManager GM)
    {
        gameManager = GM;
    }
}
