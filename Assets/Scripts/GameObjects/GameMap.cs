/*!
 * \class   GameMap
 *
 * \brief   地图对象
 *
 */

public class GameMap
{
    /*! \brief   地图节点集合 */
    private MapNode[,] _mapNodeSet;

    /*! \brief   地图尺寸 */
    public Mznqa.Size _mapSize;

    /*!
     * \property    public MapNode mapNodeSet
     *
     * \brief   获取或设置地图节点集合
     *
     */

    public MapNode[,] mapNodeSet
    {
        get { return this._mapNodeSet; }
    }

    /*!
     * \property    public Mznqa.Size mapSize
     *
     * \brief   获取或设置地图尺寸
     *
     */

    public Mznqa.Size mapSize
    {
        get { return this._mapSize; }
    }

    /*!
     * \fn  public GameMap()
     *
     * \brief   构造函数
     *
     */

    public GameMap()
    {
        this._mapNodeSet = null;
        this._mapSize = Mznqa.Size.Zero;
    }

    /*!
     * \fn  public GameMap(MapNode[,] mapNodeSet)
     *
     * \brief   构造函数
     *
     * \param   mapNodeSet  指定地图节点集合
     */

    public GameMap(MapNode[,] mapNodeSet)
    {
        this._mapNodeSet = (MapNode[,])mapNodeSet.Clone();
        this._mapSize.setValue(
            this._mapNodeSet.GetLength(1),
            this._mapNodeSet.GetLength(0)
            );
    }

    /*!
     * \fn  public void loadMap(MapNode[,] mapNodeSet)
     *
     * \brief   载入地图
     *
     * \param   mapNodeSet  指定地图节点集合
     */

    public void loadMap(MapNode[,] mapNodeSet)
    {
        this._mapNodeSet = (MapNode[,])mapNodeSet.Clone();
        this._mapSize.setValue(
            this._mapNodeSet.GetLength(1),
            this._mapNodeSet.GetLength(0)
            );
    }

    /*!
     * \fn  public void clearMap()
     *
     * \brief   清空地图
     *
     */

    public void clearMap()
    {
        int lengthY = _mapNodeSet.GetLength(0);
        int lengthX = _mapNodeSet.GetLength(1);
        for (int y = 0; y < lengthY; ++y)
            for (int x = 0; x < lengthX; ++x)
            {
                _mapNodeSet[y, x] = null;
            }
        _mapSize.setZero();
    }

    /*!
     * \fn  public bool isPassable(Mznqa.Position position)
     *
     * \brief   判断指定坐标节点是否可通过
     *
     * \param   position    指定地图节点坐标
     *
     */

    public bool isPassable(Mznqa.Position position)
    {
        if (
            0 <= position.x && position.x < this._mapSize.width &&
            0 <= position.y && position.y < this._mapSize.height
            )
            return this._mapNodeSet[position.y, position.x].isPassable();
        return false;
    }
}