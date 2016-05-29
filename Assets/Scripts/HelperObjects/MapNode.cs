/*!
 * \class   MapNode
 *
 * \brief   地图节点
 *
 */

public class MapNode
{
    /*!
     * \enum    NodeType
     *
     * \brief   枚举节点类型
     */

    public enum NodeType
    {
        None,   ///< 空
        Road,   ///< 道路
        Wall,   ///< 墙壁
        Fence   ///< 任务图围栏
    }

    /*! \brief   节点所在的位置 */
    private Mznqa.Position _position;
    /*! \brief   节点的类型 */
    private NodeType _nodeType;

    /*!
     * \property    public Mznqa.Position position
     *
     * \brief   获取或设置节点的位置
     *
     */

    public Mznqa.Position position
    {
        get { return this._position; }
    }

    /*!
     * \property    public NodeType nodeType
     *
     * \brief   获取或设置节点的类型
     *
     */

    public NodeType nodeType
    {
        get { return this._nodeType; }
    }

    /*!
     * \fn  public MapNode( Mznqa.Position position, NodeType nodeType )
     *
     * \brief   构造函数
     *
     * \param   position    指定节点的位置
     * \param   nodeType    指定节点的类型
     */

    public MapNode(
        Mznqa.Position position,
        NodeType nodeType
        )
    {
        this._position = position;
        this._nodeType = nodeType;
    }

    /*!
     * \fn  public bool isPassable()
     *
     * \brief   判断节点是否可通过
     *
     */

    public bool isPassable()
    {
        return (
            this._nodeType == NodeType.Road
            );
    }
}