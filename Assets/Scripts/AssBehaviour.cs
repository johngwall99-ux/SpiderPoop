using UnityEngine;

public class AssBehaviour : MonoBehaviour
{




    public float screenTop;
    public float screenBottom;
    public float screenLeft;
    public float screenRight;



    public float positionX;

    void Start()
    {
        CalculateScreenBounds();
       
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



    public void RespawnBoulder()
    {
        float randomX = Random.Range(screenLeft, screenRight);

        if (transform.position.y < screenBottom)
        {
            positionX = randomX;
            transform.position = new Vector2(positionX, screenTop);


        }
    }


}
