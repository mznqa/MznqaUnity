using UnityEngine;

/*!
 * \class   MapController
 *
 * \brief   地图控制器
 *
 */

public class MapController
{
    /*!
     * \fn  public void loadMap()
     *
     * \brief   载入地图
     *
     */

    public void loadMap()
    {
        GameObjectManager.Instance.gameMap.loadMap(
            DataController.loadMissionMap()
            );
    }

    /*!
     * \fn  public static Vector3 mapPostion2ScreenPosition(Mznqa.Position mapPosition)
     *
     * \brief   地图坐标转屏幕坐标
     *
     * \param   mapPosition 指定地图坐标
     *
     */

    public static Vector3 mapPostion2ScreenPosition(Mznqa.Position mapPosition)
    {
        return new Vector3(
            mapPosition.x * SizeDefine.MapTileSizePixel,
            0.0f - mapPosition.y * SizeDefine.MapTileSizePixel,
            0.0f
            );
    }
}