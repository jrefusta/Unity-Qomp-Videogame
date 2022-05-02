using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnitySceneManager = UnityEngine.SceneManagement.SceneManager;

public class BallBehaviourScript : MonoBehaviour
{
    private Vector3 direction;
    private Animator animator;
    private AudioSource source;
    private AudioClip popSound;
    private AudioClip deadSound;
    private AudioClip lateralSound;
    private AudioClip verticalSound;
    private AudioClip keySnakeSound;
    private AudioClip keySound;
    private AudioClip coinSound;
    private AudioClip rockSound;
    private AudioClip leverSound;
    public bool dead = false;
    private float deadTime;
    public bool coin = false;
    private float coinTime;
    public int keysSnake;
    private bool godMode;
    public Material defaultMaterial;
    public Material goldMaterial;

    public float cubeSize = 0.2f;
    public int cubesInRow = 5;

    float cubesPivotDistance;
    Vector3 cubesPivot;

    public float explosionForce = 50f;
    public float explosionRadius = 4f;
    public float explosionUpward = 0.4f;
    public ParticleSystem dust;

    // Start is called before the first frame update
    void Start()
    {
        if (UnitySceneManager.GetActiveScene().name == "Level1") direction = new Vector3(10f, 10f, 0f);
        else direction = new Vector3(0f, 0f, 0f);
        

        animator = GetComponent<Animator>();
        keysSnake = 0;
        deadTime = 0f;
        coinTime = 0f;
        godMode = false;

        cubesPivotDistance = cubeSize * cubesInRow / 2;
        cubesPivot = new Vector3(cubesPivotDistance, cubesPivotDistance, cubesPivotDistance);
    }

    // Update is called once per frame
    void Update()
    {
        AudioSource[] audioSources = GetComponents<AudioSource>();
        source = audioSources[0];
        popSound = audioSources[0].clip;
        deadSound = audioSources[1].clip;
        lateralSound = audioSources[2].clip;
        verticalSound = audioSources[3].clip;
        keySound = audioSources[4].clip;
        keySnakeSound = audioSources[5].clip;
        coinSound = audioSources[6].clip;
        rockSound = audioSources[7].clip;
        leverSound = audioSources[8].clip;
        string name = UnitySceneManager.GetActiveScene().name;
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
        if ((keysSnake == 3 && name == "Level2") || (keysSnake == 4 && name == "Level4"))
        {
            GameObject tail = new GameObject();
            tail.AddComponent<SphereCollider>();
            tail.GetComponent<SphereCollider>().radius = 0.005f;
            tail.tag = "Tail";
            if (direction.x > 0 && direction.y > 0)
            {
                Vector3 posTail = new Vector3(gameObject.transform.position.x - 1, gameObject.transform.position.y - 1, gameObject.transform.position.z);
                tail.GetComponent<SphereCollider>().center = posTail;
            }
            if (direction.x > 0 && direction.y < 0)
            {
                Vector3 posTail = new Vector3(gameObject.transform.position.x - 1, gameObject.transform.position.y + 1, gameObject.transform.position.z);
                tail.GetComponent<SphereCollider>().center = posTail;
            }
            if (direction.x < 0 && direction.y > 0)
            {
                Vector3 posTail = new Vector3(gameObject.transform.position.x + 1, gameObject.transform.position.y - 1, gameObject.transform.position.z);
                tail.GetComponent<SphereCollider>().center = posTail;
            }
            if (direction.x < 0 && direction.y < 0)
            {
                Vector3 posTail = new Vector3(gameObject.transform.position.x + 1, gameObject.transform.position.y + 1, gameObject.transform.position.z);
                tail.GetComponent<SphereCollider>().center = posTail;
            }
            gameObject.GetComponent<TrailRenderer>().enabled = true;

            
        }
        RaycastHit hit;

        if (Physics.Raycast(transform.position, Vector3.left, out hit, 0.5f))
        {
            if (hit.transform.tag == "map" || (godMode && hit.transform.tag == "enemy"))
            {
                source.PlayOneShot(lateralSound);
                animator.SetBool("leftCollision", true);
                direction.x *= -1;
            }
        }
        else animator.SetBool("leftCollision", false);
        if (Physics.Raycast(transform.position, Vector3.right, out hit, 0.5f))
        {
            if (hit.transform.tag == "map" || (godMode && hit.transform.tag == "enemy"))
            {
                source.PlayOneShot(lateralSound);
                animator.SetBool("rightCollision", true);
                direction.x *= -1;
            }
        }
        else animator.SetBool("rightCollision", false);
        if (Physics.Raycast(transform.position, Vector3.up, out hit, 0.5f))
        {
            if (hit.transform.tag == "map" || (godMode && hit.transform.tag == "enemy"))
            {
                source.PlayOneShot(verticalSound);
                animator.SetBool("upCollision", true);
                direction.y *= -1;
            }
        }
        else animator.SetBool("upCollision", false);
        if (Physics.Raycast(transform.position, Vector3.down, out hit, 0.5f))
        {
            if (hit.transform.tag == "map" || (godMode && hit.transform.tag == "enemy"))
            {
                source.PlayOneShot(verticalSound);
                animator.SetBool("downCollision", true);
                direction.y *= -1;
            }
        }
        else animator.SetBool("downCollision", false);
        if (Input.GetKeyDown(KeyCode.Space) && !(GameObject.Find("Main Camera").GetComponent<CameraBehaviour>().cameraMoving) && !dead)
        {
            source.PlayOneShot(popSound);
            animator.SetBool("space", true);
            direction.y *= -1;
            CreateDust();
            if (direction.x == 0) direction = new Vector3(10f, 10f, 0f);
        }
        else animator.SetBool("space", false);
        if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) UnitySceneManager.LoadScene("Level1");
        if (Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2)) UnitySceneManager.LoadScene("Level2");
        if (Input.GetKeyDown(KeyCode.Keypad3) || Input.GetKeyDown(KeyCode.Alpha3)) UnitySceneManager.LoadScene("Level3");
        if (Input.GetKeyDown(KeyCode.Keypad4) || Input.GetKeyDown(KeyCode.Alpha4)) UnitySceneManager.LoadScene("Level4");
        if (Input.GetKeyDown(KeyCode.Keypad5) || Input.GetKeyDown(KeyCode.Alpha5)) UnitySceneManager.LoadScene("Level5");
        if (Input.GetKeyDown(KeyCode.G) && !godMode)
        {
            godMode = true;
            GetComponent<Renderer>().material = goldMaterial;
        }
        else if (Input.GetKeyDown(KeyCode.G) && godMode)
        {
            godMode = false;
            GetComponent<Renderer>().material = defaultMaterial;
        }
        if (dead)
        {
            deadTime += Time.deltaTime;
            if (deadTime >= 1f)
            {
                //gameObject.transform.position = new Vector3(0f, 0f, 0f);
                //GameObject.Find("Main Camera").GetComponent<CameraBehaviour>().cameraMoving = false;
                dead = false;
                deadTime = 0f;
                UnitySceneManager.LoadScene(UnitySceneManager.GetActiveScene().name);
            }
        }
        else gameObject.transform.Translate(direction * Time.deltaTime);
        if (coin)
        {
            coinTime += Time.deltaTime;
            if (coinTime >= 1f)
            {
                if (name == "Level1") UnitySceneManager.LoadScene("Level2");
                else if (name == "Level2") UnitySceneManager.LoadScene("Level3");
                else if (name == "Level3") UnitySceneManager.LoadScene("Level4");
                else if (name == "Level4") UnitySceneManager.LoadScene("Level5");
                else
                {
                    GameObject.Find("TextYOUWIN").GetComponent<TextBehaviourScript>().active = true;
                    GameObject.Find("TextSPACE").GetComponent<TextBehaviourScript>().active = true;
                    if (Input.GetKeyDown(KeyCode.Space)) UnitySceneManager.LoadScene("Level1");
                }
            }
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if ((collision.gameObject.CompareTag("enemy") || collision.gameObject.CompareTag("Tail")) && !godMode)
        {
            source.PlayOneShot(deadSound);
            Debug.Log("KKKK");
            dead = true;
            explode();
        }
        if (collision.gameObject.CompareTag("KeySnake"))
        {
            ++keysSnake;
            source.PlayOneShot(keySnakeSound);
            source.PlayOneShot(rockSound);
        }

        if (collision.gameObject.CompareTag("Key"))
        {
            source.PlayOneShot(keySound);
            source.PlayOneShot(rockSound);
        }
        if (collision.gameObject.CompareTag("Coin"))
        {
            source.PlayOneShot(coinSound);
            direction = new Vector3(0f, 0f, 0f);
            animator.SetBool("end", true);
            coin = true;
        }
        if (collision.gameObject.CompareTag("Lever"))
        {
            source.PlayOneShot(leverSound);
            source.PlayOneShot(rockSound);
        }
    }

    public void explode()
    {
        //gameObject.SetActive(false);

        for (int x = 0; x < cubesInRow; x++)
        {
            for (int y = 0; y < cubesInRow; y++)
            {
                for (int z = 0; z < cubesInRow; z++)
                {
                    createPiece(x, y, z);
                }
            }
        }

        Vector3 explosionPos = transform.position;
        Collider[] colliders = Physics.OverlapSphere(explosionPos, explosionRadius);
        foreach (Collider hit in colliders)
        {
            Rigidbody rb = hit.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.AddExplosionForce(explosionForce, transform.position, explosionRadius, explosionUpward);
            }
        }
        transform.position = new Vector3(transform.position.x, transform.position.y, 10f);
    }

    void createPiece(int x, int y, int z)
    {

        GameObject piece;
        piece = GameObject.CreatePrimitive(PrimitiveType.Cube);

        piece.transform.position = transform.position + new Vector3(cubeSize * x, cubeSize * y, cubeSize * z) - cubesPivot;
        piece.transform.localScale = new Vector3(cubeSize, cubeSize, cubeSize);

        piece.AddComponent<Rigidbody>();
        piece.GetComponent<Rigidbody>().mass = cubeSize;
        piece.GetComponent<Renderer>().material = GetComponent<Renderer>().material;
    }

    void CreateDust()
    {
        dust.Play();
    }
}
