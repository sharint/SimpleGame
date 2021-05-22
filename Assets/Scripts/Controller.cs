using UnityEngine;
using UnityEngine.UI;

public class Controller : MonoBehaviour
{
    public GameObject sphere;
    public Text text;

    public float speed = 100;
    public float gameDuration = 15;

    private SphereController sphController;

    private void Start()
    {
        sphController = sphere.GetComponent<SphereController>();
    }

    private void Update()
    {
        text.text = Time.time.ToString();

        if(Time.time >= gameDuration)
        {
            text.text = "Ты выиграл";
            Application.Quit();
        }

        if (sphController.isLeave)
        {
            text.text = "Ты проиграл";
            Application.Quit();
        }
    }

    public void Pump()
    {
        var rb = sphere.GetComponent<Rigidbody>();
        rb.AddForce(Vector3.up* speed);
    }
}
