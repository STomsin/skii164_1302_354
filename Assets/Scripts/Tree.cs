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

        UIManager.instance.ShowNotiText($"Hurt -25\nHP: {player.HP}");


        if (player.HP <= 0)
        {
            player.HP = 0;
            UIManager.instance.ShowNotiText($"YOu Dead \n Your hp is: {player.HP}");
            Time.timeScale = 0f;
            UIManager.instance.ShowHideRestartButton(true);
        }

    }

    private void OnCollisionExit(Collision collision)
    {
        rd.material.color = new Color32(118, 104, 97, 255);
    }

}