using UnityEngine;

public class Tree : MonoBehaviour
{
    private MeshRenderer rd;

    void Start()
    {
        rd = GetComponent<MeshRenderer>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (rd != null) rd.material.color = Color.red;

        Player player = collision.gameObject.GetComponentInParent<Player>();

        if (player == null)
            return;

        player.HP -= 25;
        UIManager.instance.ShowNotiText($"Hurt -25\nHP: {player.HP}");

        if (player.HP <= 0)
        {
            player.HP = 0;
            UIManager.instance.ShowNotiText($"You Dead \n Your hp is: {player.HP}");
            Time.timeScale = 0f;
            UIManager.instance.ShowHideRestartButton(true);
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (rd != null) rd.material.color = new Color32(118, 104, 97, 255);
    }
}