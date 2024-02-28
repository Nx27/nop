using UnityEngine;

#region Code
public class MovementScript : MonoBehaviour
{
    #region SerializeFields
    [SerializeField] private float speed = 6f;
    [SerializeField] private float jumpForce = 7f;
    [SerializeField] private Rigidbody2D RB;
    [SerializeField] private GroundCheck groundCheck;

    #endregion
    #region Fields
    private bool _canJump = true;
    private bool _canJumpTwice = true;
    public DashState dashState;
    public float dashTimer;
    public float maxDash = 1f;
    private float maxDashSpeed = 10f;

    public Vector2 savedVelocity;

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

        #region Dashing logic
        switch (dashState)
        {
            case DashState.Ready:
                var isDashKeyDown = Input.GetKeyDown(KeyCode.LeftShift);
                if (isDashKeyDown)
                {
                    savedVelocity = RB.velocity;
                    RB.AddForce(new Vector2(RB.velocity.x * maxDashSpeed, RB.velocity.y));
                    dashState = DashState.Dashing;
                }
                break;
            case DashState.Dashing:
                dashTimer += Time.deltaTime * maxDashSpeed;
                if (dashTimer >= maxDash)
                {
                    dashTimer = maxDash;
                    RB.velocity = savedVelocity;
                    dashState = DashState.Cooldown;
                }
                break;
            case DashState.Cooldown:
                dashTimer -= Time.deltaTime;
                if (dashTimer <= 0)
                {
                    dashTimer = 0;
                    dashState = DashState.Ready;
                }
                break;
        }
        #endregion
    }
    #endregion
}
#endregion
#region ENUM DashState
public enum DashState
{
    Ready,
    Dashing,
    Cooldown
}
#endregion