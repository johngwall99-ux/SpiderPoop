using UnityEngine;

public class BoulderBehaviour : MonoBehaviour
{
    [SerializeField] private float boulderSpeed = 8f;
 
 

    public float screenTop;
    public float screenBottom;
    public float screenLeft;
    public float screenRight;

    private ScoreManager scoreManager;
    private AssBehaviour assBehaviour;
    
    FartHandler fartHandler;

    public float positionX;

    private void Awake()
    {
        fartHandler = GameObject.FindGameObjectWithTag("Audio").GetComponent<FartHandler>();
    }

    void Start()
    {
        CalculateScreenBounds();
        scoreManager = Object.FindAnyObjectByType<ScoreManager>();
        assBehaviour = Object.FindAnyObjectByType <AssBehaviour>();
        fartHandler.PlayRandomFart(fartHandler.fart1);

    }

    private void CalculateScreenBounds()
    {
        Camera mainCamera = Camera.main;

        float camHeight = mainCamera.orthographicSize;
        float camWidth = camHeight * mainCamera.aspect;

        //vertical bounds
        screenTop = mainCamera.transform.position.y + camHeight;
        screenBottom = mainCamera.transform.position.y - camHeight;

        //horizontal bounds
        screenLeft = mainCamera.transform.position.x - camWidth;
        screenRight = mainCamera.transform.position.x + camWidth;
    }

    void Update()
    {
        MoveBoulder();

        RespawnBoulder();
    }

    private void RespawnBoulder()
    {
        float randomX = Random.Range(screenLeft, screenRight);
        int randomFart = Random.Range(1, 5);
        

        


        if (transform.position.y < screenBottom)
        {
            positionX = randomX;
            transform.position = new Vector2(positionX, screenTop);
            assBehaviour.transform.position = new Vector2(positionX, screenTop);
            scoreManager.AddScore();

            switch (randomFart)
            {
                case 1:
                    fartHandler.PlayRandomFart(fartHandler.fart1);
                    break;
                case 2:
                    fartHandler.PlayRandomFart(fartHandler.fart2);
                    break;
                case 3:
                    fartHandler.PlayRandomFart(fartHandler.fart3);
                    break;
                case 4:
                    fartHandler.PlayRandomFart(fartHandler.fart4);
                    break;
                case 5:
                    fartHandler.PlayRandomFart(fartHandler.fart5);
                    break;
                default:
                    break;
            }
        }
    }

    private void MoveBoulder()
    {
        transform.Translate(Vector2.down * (boulderSpeed * Time.deltaTime));
        
    }
}
