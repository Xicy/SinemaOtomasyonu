namespace SinemaOtomasyonu.Models
{
    public class Price
    {
        private float stu_Price;
        private float per_Price;
        private float glass_Price;

        /// <summary>
        /// Sınıfı oluşturan yapıcı method
        /// </summary>
        /// <param name="StudentPrice">Öğrenci Fiyatı</param>
        /// <param name="PersonPrice">Tam Fiyatı</param>
        /// <param name="GlassPrice">3D Gözlük Fiyatı</param>
        public Price(float StudentPrice, float PersonPrice, float GlassPrice)
        {
            stu_Price = StudentPrice;
            per_Price = PersonPrice;
            glass_Price = GlassPrice;
        }

        /// <summary>
        /// Öğrenci fiyatını geri döndürür
        /// </summary>
        /// <param name="_3d">Eğer müşteri gözlük istiyorsa değeri true girin yok boş bırakın</param>
        /// <returns></returns>
        public float getStudentPrice(bool _3d = false)
        {
            if (_3d)
            {
                return stu_Price + glass_Price;
            }
            else
            {
                return stu_Price;
            }
        }

        /// <summary>
        /// Tam fiyatını geri döndürür
        /// </summary>
        /// <param name="_3d">Eğer müşteri gözlük istiyorsa değeri true girin yok boş bırakın</param>
        /// <returns></returns>
        public float getPersonPrice(bool _3d = false)
        {
            if (_3d)
            {
                return per_Price + glass_Price;
            }
            else
            {
                return per_Price;
            }
        }

        /// <summary>
        /// Öğrenci Fiyatını güncelle
        /// </summary>
        /// <param name="price">anlık öğrenci fiyatı</param>
        public void setStudentPrice(float price)
        {
            if (price > 0)
            {
                stu_Price = price;
            }
        }

        /// <summary>
        /// Tam fiyatını güncelle
        /// </summary>
        /// <param name="price">anlık tam fiyatı</param>
        public void setPersonPrice(float price)
        {
            if (price > 0)
                per_Price = price;
        }

        /// <summary>
        /// Gözlük fiyatını güncelle
        /// </summary>
        /// <param name="price">anlık gözlük fiyatı</param>
        public void setGlassPrice(float price)
        {
            if (price > 0)
                glass_Price = price;
        }
    }
}
