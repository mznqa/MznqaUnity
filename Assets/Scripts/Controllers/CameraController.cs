using UnityEngine;

/*!
 * \class   CameraController
 *
 * \brief   相机控制器
 *
 */

public class CameraController : MonoBehaviour
{
    /*!
     * \fn  private void Start()
     *
     * \brief   Start 方法
     *
     */

    private void Start()
    {
        GameObject.Find("InputController").GetComponent<InputController>()
            .moveCamera += move;
    }

    /*!
     * \fn  private void Update()
     *
     * \brief   Update 方法
     *
     */

    private void Update()
    {
    }

    /*!
     * \fn  public void move(Vector3 delta)
     *
     * \brief   移动相机
     *
     * \param   delta   指定移动增减量
     */

    public void move(Vector3 delta)
    {
        transform.position += delta;
    }

    /*!
     * \fn  public void moveTo(Vector3 position)
     *
     * \brief   移动相机到指定位置
     *
     * \param   position    指定目标位置
     */

    public void moveTo(Vector3 position)
    {
        transform.position = position;
    }
}