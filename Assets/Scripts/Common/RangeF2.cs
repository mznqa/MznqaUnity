namespace Mznqa
{
    /*!
     * \class   RangeF2
     *
     * \brief   范围（二维）
     *
     */

    public class RangeF2
    {
        /*! \brief   横向范围 */
        private Mznqa.RangeF _horizontal;
        /*! \brief   纵向范围 */
        private Mznqa.RangeF _vertical;

        /*!
         * \property    public Mznqa.RangeF horizontal
         *
         * \brief   横向范围
         *
         */

        public Mznqa.RangeF horizontal
        {
            get { return this._horizontal; }
            set { this._horizontal.setValue(value.min, value.max); }
        }

        /*!
         * \property    public Mznqa.RangeF vertical
         *
         * \brief   纵向范围
         *
         */

        public Mznqa.RangeF vertical
        {
            get { return this._vertical; }
            set { this._vertical.setValue(value.min, value.max); }
        }

        /*!
         * \fn  public RangeF2(Mznqa.RangeF horizontal = new Mznqa.RangeF(), Mznqa.RangeF vertical = new Mznqa.RangeF())
         *
         * \brief   构造函数
         *
         * \param   horizontal  指定横向范围
         * \param   vertical    指定纵向范围
         */

        public RangeF2(
            Mznqa.RangeF horizontal = new Mznqa.RangeF(),
            Mznqa.RangeF vertical = new Mznqa.RangeF()
            )
        {
            this._horizontal = new RangeF(0.0f, 0.0f);
            this._vertical = new RangeF(0.0f, 0.0f);
            this._horizontal.setValue(horizontal.min, horizontal.max);
            this._vertical.setValue(vertical.min, vertical.max);
        }

        /*!
         * \fn  public RangeF2(RangeF2 rangeF2)
         *
         * \brief   拷贝构造函数
         *
         */

        public RangeF2(RangeF2 rangeF2)
        {
            this._horizontal = new RangeF(0.0f, 0.0f);
            this._vertical = new RangeF(0.0f, 0.0f);
            this._horizontal.setValue(
                rangeF2.horizontal.min,
                rangeF2.horizontal.max
                );
            this._vertical.setValue(
                rangeF2.vertical.min,
                rangeF2.vertical.max
                );
        }

        /*!
         * \fn  public bool setValue(Mznqa.RangeF horizontal, Mznqa.RangeF vertical)
         *
         * \brief   设置值
         *
         * \param   horizontal  指定横向范围
         * \param   vertical    指定纵向范围
         */

        public bool setValue(Mznqa.RangeF horizontal, Mznqa.RangeF vertical)
        {
            var horizontalTemp = new RangeF();
            var verticalTemp = new RangeF();
            if (
                horizontalTemp.setValue(horizontal.min, horizontal.max) &&
                verticalTemp.setValue(vertical.min, vertical.max)
                )
            {
                this._horizontal = horizontal;
                this._vertical = vertical;
                return true;
            }
            return false;
        }

        /*!
         * \fn  public bool isInclusive(Mznqa.PositionF position)
         *
         * \brief   判断指定点是否在范围内
         *
         * \param   position    指定点
         *
         */

        public bool isInclusive(Mznqa.PositionF position)
        {
            return (
                this._horizontal.isInclusive(position.x) &&
                this._vertical.isInclusive(position.y)
                );
        }

        /*!
         * \fn  public bool expand(int delta)
         *
         * \brief   扩大范围
         *
         * \param   delta   指定增减量
         *
         */

        public bool expand(int delta)
        {
            var horizontalTemp = new RangeF(this._horizontal);
            var verticalTemp = new RangeF(this._vertical);
            if (horizontalTemp.expand(delta) && verticalTemp.expand(delta))
            {
                setValue(horizontalTemp, verticalTemp);
                return true;
            }
            else
                return false;
        }

        /*!
         * \fn  public bool shrink(int delta)
         *
         * \brief   缩小范围
         *
         * \param   delta   指定增减量
         *
         */

        public bool shrink(int delta)
        {
            var horizontalTemp = new RangeF(this._horizontal);
            var verticalTemp = new RangeF(this._vertical);
            if (horizontalTemp.shrink(delta) && verticalTemp.shrink(delta))
            {
                setValue(horizontalTemp, verticalTemp);
                return true;
            }
            else
                return false;
        }
    }
}