using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    #region Code

    #region Fields
    private int contacts;
    public int Contacts { get => contacts;  }
    #endregion

    #region Function
    private void OnTriggerEnter2D(Collider2D collision)
    {
        contacts++;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        contacts--;
    }

    #endregion

    #endregion
}
