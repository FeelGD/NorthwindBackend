using System;
using System.Collections.Generic;
using System.Text;


namespace DataAccess.Abstract
{
    public interface IProductDal
    {
        //temel veri erişim operasyonları insert update delete etc.
        //her aşama için yazmak gerekli onun yerine generic repostory patern kullanacağız. 
        //projeye bağlı olmayacağı için core katmanına yazıyoruz
    }
}
