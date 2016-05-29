/*!
 * \class   GameObjectManager
 *
 * \brief   全局游戏对象管理器
 *
 */

public sealed class GameObjectManager
{
    /*! \brief   单例 */
    public static readonly GameObjectManager Instance = new GameObjectManager();

    /*! \brief   地图 */
    private GameMap _gameMap;
    /*! \brief   角色 */
    private Character _character;

    /*!
     * \property    public GameMap gameMap
     *
     * \brief   获取地图
     *
     */

    public GameMap gameMap
    {
        get { return this._gameMap; }
    }

    /*!
     * \property    public Character character
     *
     * \brief   获取角色
     *
     */

    public Character character
    {
        get { return this._character; }
    }

    /*!
     * \fn  private GameObjectManager()
     *
     * \brief   构造函数
     *
     */

    private GameObjectManager()
    {
        this._gameMap = new GameMap();
        this._character = new Character();
    }
}