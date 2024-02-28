using UnityEngine;

public class MovementScript : MonoBehaviour
{
    #region Code

    #region SerializeFields
    [SerializeField] private float speed = 6f;
    [SerializeField] private float jumpForce = 7f;
    [SerializeField] private Rigidbody2D RB;
    [SerializeField] private GroundCheck groundCheck;

    #endregion
    #region Fields
    private bool _canJump = true;
    private bool _canJumpTwice = true;
    #endregion

    #region Function
    void Update()
    {
        #region Horizontal Movement
        Vector2 vel = RB.velocity;
        vel.x = Input.GetAxis("Horizontal") * speed;
        RB.velocity = vel;
        #endregion

        #region Jumping logic
        if (Input.GetKeyDown(KeyCode.Space) && groundCheck.Contacts > 0 && _canJump )
        {
            RB.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
            _canJump = false;
        } else if (Input.GetKeyDown(KeyCode.Space) && _canJumpTwice )
        {
            RB.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
            _canJumpTwice = false;
        } else {
            if (groundCheck.Contacts == 1) 
            {
                _canJump = true;
                _canJumpTwice = true;
            }
        }
        #endregion
    }

    #endregion

    #endregion
}