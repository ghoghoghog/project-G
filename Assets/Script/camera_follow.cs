using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;
public enum camera_mode
{
    player_follow,
    screen_follow,
    x_rail,
    y_rail
}
public class camera_follow : MonoBehaviour
{
    private GameObject player;
    private Vector3 TargetPos;
    private float n = 0;

    private float min_n = 0;

    private float max_n = 0;
    [SerializeField]
    private camera_mode mode;
    [SerializeField]
    private float speed = 10f;
    [HideInInspector]
    public bool use_min_max = false;
    // Start is called before the first frame update
    Camera camera_m;
    void Start()
    {
        camera_m = GetComponent<Camera>();
        player = GameObject.Find("player");
        TargetPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        TargetPos.z = transform.position.z;
        transform.position = Vector3.Lerp(transform.position, TargetPos, Time.deltaTime * speed);

        switch (mode)
        {
            case (camera_mode.player_follow):
                TargetPos = player.transform.position;
                break;
            case (camera_mode.screen_follow):
                if (player.transform.position.x < TargetPos.x - 9)
                {
                    TargetPos = TargetPos + new Vector3(-18, 0, 0);
                }

                if (player.transform.position.x > TargetPos.x + 9)
                {
                    TargetPos = TargetPos + new Vector3(18, 0, 0);
                }

                if (player.transform.position.y < TargetPos.y - 5)
                {
                    TargetPos = TargetPos + new Vector3(0, -10, 0);
                }

                if (player.transform.position.y > TargetPos.y + 5)
                {
                    TargetPos = TargetPos + new Vector3(0, 10, 0);
                }
                break;
            case (camera_mode.x_rail):
                TargetPos = new Vector2(player.transform.position.x, n);
                if (use_min_max)
                {
                    TargetPos.x = Mathf.Clamp(TargetPos.x, min_n, max_n);
                }
                break;
            case (camera_mode.y_rail):

                TargetPos = new Vector2(n, player.transform.position.y);
                if (use_min_max)
                {
                    TargetPos.y = Mathf.Clamp(TargetPos.y, min_n, max_n);
                }
                break;
        }

    }

    public void change_mode_to_screen(Vector2 pos)
    {
        mode = camera_mode.screen_follow;
        TargetPos = pos;
    }


    public void change_mode_to_player()
    {
        mode = camera_mode.player_follow;
    }


    public void change_mode_to_rail(float m, bool is_x_rail)
    {
        use_min_max = false;
        if (is_x_rail)
        {
            n = m;
            mode = camera_mode.x_rail;
        }
        else
        {
            n = m;
            mode = camera_mode.y_rail;
        }
    }
    public void change_mode_to_rail(float m, bool is_x_rail, float mi, float ma)
    {
        use_min_max = true;
        min_n = mi;
        max_n = ma;
        if (is_x_rail)
        {
            n = m;
            mode = camera_mode.x_rail;
        }
        else
        {
            n = m;
            mode = camera_mode.y_rail;
        }
    }
    public void set_size(float size)
    {

        camera_m.orthographicSize = size * 5 / 18;
    }
}
