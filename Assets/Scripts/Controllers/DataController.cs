/*!
 * \class   DataController
 *
 * \brief   本地数据控制器
 *
 */

public static class DataController
{
    /*!
     * \fn  public static MapNode loadMissionMap()
     *
     * \brief   载入任务图
     *
     */

    public static MapNode[,] loadMissionMap()
    {
        // TODO 以下为测试用，待重写
        var mapNodeSet = new MapNode[48, 64];

        int originX = 0;
        int originY = 0;

        for (int y = 0; y < 48; ++y)
            for (int x = 0; x < 64; ++x)
            {
                if (
                    (x == 1 && y == 0) ||
                    (x == 4 && y == 0) ||
                    (x == 7 && y == 0) ||
                    (x == 10 && y == 0) ||
                    (x == 0 && y == 1) ||
                    (x == 1 && y == 1) ||
                    (x == 2 && y == 1) ||
                    (x == 3 && y == 1) ||
                    (x == 4 && y == 1) ||
                    (x == 5 && y == 1) ||
                    (x == 6 && y == 1) ||
                    (x == 7 && y == 1) ||
                    (x == 8 && y == 1) ||
                    (x == 9 && y == 1) ||
                    (x == 10 && y == 1) ||
                    (x == 11 && y == 1) ||
                    (x == 1 && y == 2) ||
                    (x == 10 && y == 2) ||
                    (x == 1 && y == 3) ||
                    (x == 8 && y == 3) ||
                    (x == 10 && y == 3) ||
                    (x == 0 && y == 4) ||
                    (x == 1 && y == 4) ||
                    (x == 3 && y == 4) ||
                    (x == 4 && y == 4) ||
                    (x == 5 && y == 4) ||
                    (x == 6 && y == 4) ||
                    (x == 7 && y == 4) ||
                    (x == 8 && y == 4) ||
                    (x == 10 && y == 4) ||
                    (x == 11 && y == 4) ||
                    (x == 1 && y == 5) ||
                    (x == 6 && y == 5) ||
                    (x == 10 && y == 5) ||
                    (x == 1 && y == 6) ||
                    (x == 6 && y == 6) ||
                    (x == 7 && y == 6) ||
                    (x == 8 && y == 6) ||
                    (x == 10 && y == 6) ||
                    (x == 0 && y == 7) ||
                    (x == 1 && y == 7) ||
                    (x == 6 && y == 7) ||
                    (x == 10 && y == 7) ||
                    (x == 11 && y == 7) ||
                    (x == 1 && y == 8) ||
                    (x == 6 && y == 8) ||
                    (x == 10 && y == 8) ||
                    (x == 1 && y == 9) ||
                    (x == 6 && y == 9) ||
                    (x == 10 && y == 9) ||
                    (x == 0 && y == 10) ||
                    (x == 1 && y == 10) ||
                    (x == 2 && y == 10) ||
                    (x == 3 && y == 10) ||
                    (x == 4 && y == 10) ||
                    (x == 5 && y == 10) ||
                    (x == 6 && y == 10) ||
                    (x == 7 && y == 10) ||
                    (x == 8 && y == 10) ||
                    (x == 9 && y == 10) ||
                    (x == 10 && y == 10) ||
                    (x == 11 && y == 10) ||
                    (x == 1 && y == 11) ||
                    (x == 4 && y == 11) ||
                    (x == 7 && y == 11) ||
                    (x == 10 && y == 11)
                )
                    mapNodeSet[originY + y, originX + x] = new MapNode(new Mznqa.Position(x, y), MapNode.NodeType.Road);
                else if (
                    (x == 2 && y == 2) ||
                    (x == 3 && y == 2) ||
                    (x == 4 && y == 2) ||
                    (x == 5 && y == 2) ||
                    (x == 6 && y == 2) ||
                    (x == 7 && y == 2) ||
                    (x == 8 && y == 2) ||
                    (x == 9 && y == 2) ||
                    (x == 2 && y == 3) ||
                    (x == 9 && y == 3) ||
                    (x == 2 && y == 4) ||
                    (x == 9 && y == 4) ||
                    (x == 2 && y == 5) ||
                    (x == 9 && y == 5) ||
                    (x == 2 && y == 6) ||
                    (x == 9 && y == 6) ||
                    (x == 2 && y == 7) ||
                    (x == 9 && y == 7) ||
                    (x == 2 && y == 8) ||
                    (x == 9 && y == 8) ||
                    (x == 2 && y == 9) ||
                    (x == 3 && y == 9) ||
                    (x == 4 && y == 9) ||
                    (x == 5 && y == 9) ||
                    (x == 7 && y == 9) ||
                    (x == 8 && y == 9) ||
                    (x == 9 && y == 9)
                    )
                    mapNodeSet[y, x] = new MapNode(new Mznqa.Position(x, y), MapNode.NodeType.Fence);
                else
                    mapNodeSet[y, x] = new MapNode(new Mznqa.Position(x, y), MapNode.NodeType.Wall);
            }

        return mapNodeSet;
    }
}