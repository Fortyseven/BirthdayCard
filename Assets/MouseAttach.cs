using UnityEngine;

public class MouseAttach : MonoBehaviour
{
    public void Start()
    {
        Cursor.visible = false;
        Update();
    }

    private void Update()
    {
        var new_mouse_pos = Input.mousePosition;

        transform.position = Camera.main.ScreenToWorldPoint( new Vector3( new_mouse_pos.x, new_mouse_pos.y ) );
    }
}
