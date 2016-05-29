using UnityEngine;

/*!
 * \class   GameController
 *
 * \brief   游戏全局控制器
 *
 */

public class GameController : MonoBehaviour
{
    /*! \brief   预制件-瓦片地图-道路 */
    public GameObject prefabMapTileRoad;
    /*! \brief   预制件-瓦片地图-墙壁 */
    public GameObject prefabMapTileWall;
    /*! \brief   预制件-瓦片地图-围栏 */
    public GameObject prefabMapTileFence;
    /*! \brief   预制件-角色 */
    public GameObject prefabCharacter;

    /*! \brief   地图控制器 */
    private MapController _mapController;

    /*!
     * \fn  private void Start()
     *
     * \brief   Start 方法
     *
     */

    private void Start()
    {
        // TODO 以下为测试用
        _mapController = new MapController();
        _mapController.loadMap();
        for (int y = 0; y < GameObjectManager.Instance.gameMap.mapSize.height; ++y)
            for (int x = 0; x < GameObjectManager.Instance.gameMap.mapSize.width; ++x)
            {
                if (GameObjectManager.Instance.gameMap.mapNodeSet[y, x].nodeType == MapNode.NodeType.Road)
                    Instantiate(
                        prefabMapTileRoad,
                        MapController.mapPostion2ScreenPosition(GameObjectManager.Instance.gameMap.mapNodeSet[y, x].position),
                        Quaternion.identity
                    );
                else if (GameObjectManager.Instance.gameMap.mapNodeSet[y, x].nodeType == MapNode.NodeType.Wall)
                    Instantiate(
                        prefabMapTileWall,
                        MapController.mapPostion2ScreenPosition(GameObjectManager.Instance.gameMap.mapNodeSet[y, x].position),
                        Quaternion.identity
                    );
                else if (GameObjectManager.Instance.gameMap.mapNodeSet[y, x].nodeType == MapNode.NodeType.Fence)
                    Instantiate(
                        prefabMapTileFence,
                        MapController.mapPostion2ScreenPosition(GameObjectManager.Instance.gameMap.mapNodeSet[y, x].position),
                        Quaternion.identity
                    );
            }

        GameObjectManager.Instance.character.position = new Mznqa.Position(10, 10);
        Instantiate(
                        prefabCharacter,
                        MapController.mapPostion2ScreenPosition(GameObjectManager.Instance.character.position),
                        Quaternion.identity
                    );
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
}