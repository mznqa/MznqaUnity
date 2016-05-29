namespace Mznqa
{
    /*!
     * \class   Range2
     *
     * \brief   范围（二维）
     *
     */

    public class Range2
    {
        /*! \brief   横向范围 */
        private Mznqa.Range _horizontal;
        /*! \brief   纵向范围 */
        private Mznqa.Range _vertical;

        /*!
         * \property    public Mznqa.Range horizontal
         *
         * \brief   横向范围
         *
         */

        public Mznqa.Range horizontal
        {
            get { return this._horizontal; }
            set { this._horizontal.setValue(value.min, value.max); }
        }

        /*!
         * \property    public Mznqa.Range vertical
         *
         * \brief   纵向范围
         *
         */

        public Mznqa.Range vertical
        {
            get { return this._vertical; }
            set { this._vertical.setValue(value.min, value.max); }
        }

        /*!
         * \fn  public Range2(Mznqa.Range horizontal = new Mznqa.Range(), Mznqa.Range vertical = new Mznqa.Range())
         *
         * \brief   构造函数
         *
         * \param   horizontal  指定横向范围
         * \param   vertical    指定纵向范围
         */

        public Range2(
            Mznqa.Range horizontal = new Mznqa.Range(),
            Mznqa.Range vertical = new Mznqa.Range()
            )
        {
            this._horizontal = new Range(0, 0);
            this._vertical = new Range(0, 0);
            this._horizontal.setValue(horizontal.min, horizontal.max);
            this._vertical.setValue(vertical.min, vertical.max);
        }

        /*!
         * \fn  public Range2(Range2 range2)
         *
         * \brief   拷贝构造函数
         *
         */

        public Range2(Range2 range2)
        {
            this._horizontal = new Range(0, 0);
            this._vertical = new Range(0, 0);
            this._horizontal.setValue(
                range2.horizontal.min,
                range2.horizontal.max
                );
            this._vertical.setValue(
                range2.vertical.min,
                range2.vertical.max
                );
        }

        /*!
         * \fn  public bool setValue(Mznqa.Range horizontal, Mznqa.Range vertical)
         *
         * \brief   设置值
         *
         * \param   horizontal  指定横向范围
         * \param   vertical    指定纵向范围
         */

        public bool setValue(Mznqa.Range horizontal, Mznqa.Range vertical)
        {
            var horizontalTemp = new Range();
            var verticalTemp = new Range();
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
         * \fn  public bool isInclusive(Mznqa.Position position)
         *
         * \brief   判断指定点是否在范围内
         *
         * \param   position    指定点
         *
         */

        public bool isInclusive(Mznqa.Position position)
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
            var horizontalTemp = new Range(this._horizontal);
            var verticalTemp = new Range(this._vertical);
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
            var horizontalTemp = new Range(this._horizontal);
            var verticalTemp = new Range(this._vertical);
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