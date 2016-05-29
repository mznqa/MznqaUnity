namespace Mznqa
{
    /*!
     * \struct  Position
     *
     * \brief   位置
     *
     */

    public struct Position
    {
        /*! \brief   原点 */
        public static Position Origin = new Position(0, 0);

        /*! \brief   横向分量 */
        public int x;
        /*! \brief   纵向分量 */
        public int y;

        /*!
         * \fn  public Position(int x = 0, int y = 0)
         *
         * \brief   构造函数
         *
         * \param   x   指定横向分量
         * \param   y   指定纵向分量
         */

        public Position(int x = 0, int y = 0)
        {
            this.x = x;
            this.y = y;
        }

        /*!
         * \fn  public Position(Position position)
         *
         * \brief   拷贝构造函数
         *
         */

        public Position(Position position)
        {
            this.x = position.x;
            this.y = position.y;
        }

        /*!
         * \fn  public setValue(int x, int y)
         *
         * \brief   设置值
         *
         * \param   x   指定横向分量
         * \param   y   指定纵向分量
         */

        public void setValue(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        /*!
         * \fn  public void setOrigin()
         *
         * \brief   置为原点
         *
         */

        public void setOrigin()
        {
            this.x = 0;
            this.y = 0;
        }

        /*!
         * \fn  public Position operator+(Position lhs, Position rhs)
         *
         * \brief   +运算符
         *
         */

        public static Position operator +(Position lhs, Position rhs)
        {
            return new Position(lhs.x + rhs.x, lhs.y + rhs.y);
        }

        /*!
         * \fn  public Position operator-(Position lhs, Position rhs)
         *
         * \brief   -运算符
         *
         */

        public static Position operator -(Position lhs, Position rhs)
        {
            return new Position(lhs.x - rhs.x, lhs.y - rhs.y);
        }
    }
}