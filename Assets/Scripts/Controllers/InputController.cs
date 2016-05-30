using UnityEngine;

/*!
 * \class   InputController
 *
 * \brief   输入控制器
 *
 */

public class InputController : MonoBehaviour
{
    /*!
     * \fn  public delegate void EventHandler<T>(T arg);
     *
     * \brief   委托
     *
     */

    public delegate void EventHandler<T>(T arg);

    /*! \brief   委托实例，用于通知相机移动事件*/

    public event EventHandler<Vector3> moveCamera;

    /*! \brief   委托实例，用于通知角色移动事件 */

    public event EventHandler<Mznqa.Position> moveCharacter;

    /*! \brief   摄像机移动移动操作灵敏度 */
    public float cameraMoveSensitivity = 0.1f;

    /*!
     * \fn  private void Start()
     *
     * \brief   Start 方法
     *
     */

    private void Start()
    {
    }

    /*!
     * \fn  private void Update()
     *
     * \brief   Update 方法
     *
     */

    private void Update()
    {
        var horizontalMapControl = Input.GetAxis("Horizontal");
        var verticalMapControl = Input.GetAxis("Vertical");
        if (horizontalMapControl != 0.0f || verticalMapControl != 0.0f)
        {
            if (moveCamera != null)
                moveCamera(new Vector3(horizontalMapControl * cameraMoveSensitivity, verticalMapControl * cameraMoveSensitivity, 0.0f));
        }
        else
        {
            if (Input.GetMouseButton(0))
            {
                horizontalMapControl = -Input.GetAxis("Mouse X");
                verticalMapControl = -Input.GetAxis("Mouse Y");
                if (moveCamera != null)
                    moveCamera(new Vector3(horizontalMapControl * cameraMoveSensitivity, verticalMapControl * cameraMoveSensitivity, 0.0f));
            }
        }
        if (moveCharacter != null)
        {
            if (Input.GetKeyDown("right"))
            {
                moveCharacter(new Mznqa.Position(1, 0));
            }
            if (Input.GetKeyDown("left"))
            {
                moveCharacter(new Mznqa.Position(-1, 0));
            }
            if (Input.GetKeyDown("up"))
            {
                moveCharacter(new Mznqa.Position(0, -1));
            }
            if (Input.GetKeyDown("down"))
            {
                moveCharacter(new Mznqa.Position(0, 1));
            }
        }
    }
}