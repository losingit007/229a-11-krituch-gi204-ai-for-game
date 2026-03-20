using UnityEngine;
using UnityEngine.Audio;

public class Laser : MonoBehaviour
{
    [SerializeField] Transform point;

    void Raycast()
    {
        Debug.DrawRay(point.position, transform.forward * 100f, Color.green);
        RaycastHit hit;

        if (Physics.Raycast(point.position, transform.forward, out hit, 100f))
        {
            Debug.DrawRay(point.position, transform.forward * 100f, Color.red);
            Debug.Log("Ray hits: " + hit.collider.name);

            if (hit.collider.tag == "Ship")
            {
                Debug.Log("Hit");
                Rigidbody rigidbody = hit.collider.GetComponent<Rigidbody>();
                if (rigidbody != null)
                {
                    rigidbody.useGravity = true;
                    rigidbody.AddTorque(0, 1 * 50, 0);


                    AudioSource audio;
                    audio = GetComponent<AudioSource>();
                    audio.Play();
                }
            }

        }

    }// Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Raycast();
    }
}
