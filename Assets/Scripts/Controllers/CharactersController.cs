using UnityEngine;

/*!
 * \class   CharactersController
 *
 * \brief   角色控制器
 *
 */

public class CharactersController : MonoBehaviour
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
            .moveCharacter += move;
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
     * \fn  public void move(Mznqa.Position delta)
     *
     * \brief   移动角色
     *
     * \param   delta   指定坐标增减量
     */

    public void move(Mznqa.Position delta)
    {
        transform.position = MapController.mapPostion2ScreenPosition(
            GameObjectManager.Instance.character.position
            );
    }
}