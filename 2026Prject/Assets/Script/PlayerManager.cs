using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public static PlayerManager instance;

    public float moveSpeed;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    void Start()
    {
        
    }

    void Update()
    {
        PlayerMove();
    }

    void PlayerMove()
    {
        float h = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        float v = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        transform.position += new Vector3(h, v, 0);
    }
}
