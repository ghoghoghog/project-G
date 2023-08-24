using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class camera_mode_changer : MonoBehaviour
{

    public camera_mode mode = 0;

    [HideInInspector]
    public bool use_min_max;
    [HideInInspector]
    public float min_m;
    [HideInInspector]
    public float max_m;
    [HideInInspector]
    public float m;
    [HideInInspector]
    public Vector2 pos;

    [SerializeField]
    private float size = 5;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name != "player")
        {
            return;
        }
        switch (mode)
        {
            case camera_mode.x_rail:
                if (!use_min_max)
                {
                    Camera.main.GetComponent<camera_follow>().change_mode_to_rail(m, true);

                }
                else
                {
                    Camera.main.GetComponent<camera_follow>().change_mode_to_rail(m, true, min_m, max_m);
                }
                break;
            case camera_mode.y_rail:
                if (!use_min_max)
                {
                    Camera.main.GetComponent<camera_follow>().change_mode_to_rail(m, false);
                }
                else
                {
                    Camera.main.GetComponent<camera_follow>().change_mode_to_rail(m, false, min_m, max_m);
                }
                break;
            case camera_mode.player_follow:
                Camera.main.GetComponent<camera_follow>().change_mode_to_player();
                break;
            case camera_mode.screen_follow:
                Camera.main.GetComponent<camera_follow>().change_mode_to_screen(pos);
                break;
        }
        Camera.main.GetComponent<camera_follow>().set_size(size);

    }
    [ContextMenu("reset")]
    void reset()
    {
        mode = camera_mode.screen_follow;
        use_min_max = false;
        min_m = 0;
        max_m = 0;
        m = 0;
        pos = new Vector2(0, 0);
        size = 18;

    }
}