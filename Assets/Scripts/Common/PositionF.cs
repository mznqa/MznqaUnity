namespace Mznqa
{
    /*!
     * \struct  PositionF
     *
     * \brief   位置
     *
     */

    public struct PositionF
    {
        /*! \brief   原点 */
        public static PositionF Origin = new PositionF(0.0f, 0.0f);

        /*! \brief   横向分量 */
        public float x;
        /*! \brief   纵向分量 */
        public float y;

        /*!
         * \fn  public PositionF(float x = 0.0f, float y = 0.0f)
         *
         * \brief   构造函数
         *
         * \param   x   指定横向分量
         * \param   y   指定纵向分量
         */

        public PositionF(float x = 0.0f, float y = 0.0f)
        {
            this.x = x;
            this.y = y;
        }

        /*!
         * \fn  public PositionF(PositionF PositionF)
         *
         * \brief   拷贝构造函数
         *
         */

        public PositionF(PositionF positionF)
        {
            this.x = positionF.x;
            this.y = positionF.y;
        }

        /*!
         * \fn  public setValue(float x, float y)
         *
         * \brief   设置值
         *
         * \param   x   指定横向分量
         * \param   y   指定纵向分量
         */

        public void setValue(float x, float y)
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
            this.x = 0.0f;
            this.y = 0.0f;
        }

        /*!
         * \fn  public PositionF operator+(PositionF lhs, PositionF rhs)
         *
         * \brief   +运算符
         *
         */

        public static PositionF operator +(PositionF lhs, PositionF rhs)
        {
            return new PositionF(lhs.x + rhs.x, lhs.y + rhs.y);
        }

        /*!
         * \fn  public PositionF operator-(PositionF lhs, PositionF rhs)
         *
         * \brief   -运算符
         *
         */

        public static PositionF operator -(PositionF lhs, PositionF rhs)
        {
            return new PositionF(lhs.x - rhs.x, lhs.y - rhs.y);
        }
    }
}