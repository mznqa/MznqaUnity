using UnityEngine;

/*!
 * \class   Character
 *
 * \brief   角色
 *
 */

public class Character
{
    /*!
     * \fn  public delegate void EventHandler();
     *
     * \brief   委托声明
     *
     */

    public delegate void EventHandler();

    /*! \brief   委托实例，角色位置变更 */

    public event EventHandler characterPositionChanged;

    /*! \brief   角色所在的位置 */
    private Mznqa.Position _position;

    /*!
     * \property    public Mznqa.Position position
     *
     * \brief   获取或设置角色的位置
     *
     */

    public Mznqa.Position position
    {
        get { return this._position; }
        set { if (GameObjectManager.Instance.gameMap.isPassable(value)) this._position = value; }
    }

    /*!
     * \fn  public Character()
     *
     * \brief   构造函数
     *
     */

    public Character()
    {
        GameObject.Find("InputController").GetComponent<InputController>()
            .moveCharacter += updatePosition;

        this._position = Mznqa.Position.Origin;
    }

    /*!
     * \fn  public void updatePosition(Mznqa.Position delta)
     *
     * \brief   更新坐标
     *
     * \param   delta   指定坐标增减量
     */

    public void updatePosition(Mznqa.Position delta)
    {
        var pos = this._position + delta;
        if (GameObjectManager.Instance.gameMap.isPassable(pos))
        {
            this._position = pos;
            characterPositionChanged();
        }
    }

    /*!
     * \fn  public void updatePositionXY(int deltaX, int deltaY)
     *
     * \brief   更新坐标值
     *
     * \param   deltaX  指定横坐标增减量
     * \param   deltaY  指定纵坐标增减量
     */

    public void updatePositionXY(int deltaX, int deltaY)
    {
        var pos = this._position + new Mznqa.Position(deltaX, deltaY);
        if (GameObjectManager.Instance.gameMap.isPassable(pos))
        {
            this._position = pos;
            characterPositionChanged();
        }
    }

    /*!
     * \fn  public void updatePositionX(int deltaX)
     *
     * \brief   更新横坐标
     *
     * \param   deltaX  指定横坐标增减量
     */

    public void updatePositionX(int deltaX)
    {
        var pos = this._position + new Mznqa.Position(deltaX, 0);
        if (GameObjectManager.Instance.gameMap.isPassable(pos))
        {
            this._position = pos;
            characterPositionChanged();
        }
    }

    /*!
     * \fn  public void updatePositionY(int deltaY)
     *
     * \brief   更新纵坐标
     *
     * \param   deltaY  指定纵坐标增减量
     */

    public void updatePositionY(int deltaY)
    {
        var pos = this._position + new Mznqa.Position(0, deltaY);
        if (GameObjectManager.Instance.gameMap.isPassable(pos))
        {
            this._position = pos;
            characterPositionChanged();
        }
    }
}