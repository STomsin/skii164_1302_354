using System.Net;
using Unity.VisualScripting;
using UnityEngine;

public class Tree : MonoBehaviour
{
    private MeshRenderer rd;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rd = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        rd.material.color = Color.red;
        Player player = collision.gameObject.GetComponent<Player>();

        if (player == null)
            return;

        player.HP -= 25;

    }

    private void OnCollisionExit(Collision collision)
    {
        rd.material.color = new Color32(118, 104, 97, 255);
    }

}