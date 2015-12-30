using UnityEngine;
using System.Collections;

public class Camera2D : MonoBehaviour
{

    public Transform player;            //This is the player

    public Vector2 margin, smoothing;   //margin and smoothing (used for camera movement)

    public BoxCollider2D bounds;        //The viewport
    private Vector3 _min, _max;         //Minimum and maximum pos of the viewport
    public float _minY, _maxY;          //Minimum/maximum y pos of the viewport
    private bool firstMove;             //Start moving camera after blowing for the first time
    public GameObject endPoint;         //This is the point where the camera slowly moves towards
    public float timeTillEndPoint;      //Indicates how long it takes for the camera to reach the endpoint
    private bool correctPos;


    public bool isFollowing { get; set; }

    public void Start()
    {
        isFollowing = true;
        firstMove = true;
        correctPos = false;
    }

    // Camera stays within the level and will not be outside that box
    // Camera will follow the player
    public void Update()
    {
        _min = bounds.bounds.min;
        _max = bounds.bounds.max;
        _minY = _min.y;
        _maxY = _max.y;
        var x = transform.position.x;
        var y = transform.position.y;


        if (isFollowing)
        {
            /*if(Mathf.Abs(x - player.position.x) > margin.x)
				x = Mathf.Lerp(x, player.position.x, smoothing.x * Time.deltaTime);*/

            //Only start moving after the first blow
            if(player.GetComponent<Rigidbody2D>().velocity.y > 0 && firstMove && player.position.y > 10)
            {
                //y = Mathf.Lerp(y, endPoint.transform.position.y, smoothing.y * Time.deltaTime); 
                transform.Translate(Vector2.up * Time.deltaTime);
                firstMove = false;
            }
            //Keep moving
            else if (!firstMove && !correctPos)
            {
                transform.Translate(Vector2.up * Time.deltaTime);
                //y = Mathf.Lerp(y, endPoint.transform.position.y, smoothing.y * Time.deltaTime);
            }

            /*if (player.GetComponent<Rigidbody2D>().velocity.y > 0)
            {
                if ((y - player.position.y) > margin.y)
                    y = Mathf.Lerp(y, player.position.y, smoothing.y * Time.deltaTime);
                    _minY = bounds.bounds.min.y; //minimum y of the level
            }*/
        }

        //var cameraHalfWidth = GetComponent<Camera>().orthographicSize * ((float)Screen.width / Screen.height); // calculate the half width of the main camera screen

        // calculates that the main camera stays in the collisionBox 
        //x = Mathf.Clamp(x, _min.x + cameraHalfWidth, _max.x - cameraHalfWidth);
        //y = Mathf.Clamp(y, _min.y + GetComponent<Camera>().orthographicSize, _max.y - GetComponent<Camera>().orthographicSize);

        //transform.position = new Vector3(x, y, transform.position.z);
    }
}
