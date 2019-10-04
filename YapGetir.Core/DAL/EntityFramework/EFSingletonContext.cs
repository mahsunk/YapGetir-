using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YapGetir.Core.DAL.EntityFramework
{
    public class EFSingletonContext<TContext> where TContext:DbContext,new()
    {//Bu class Singleton Pattern görevi için oluşturuldu.
        private static TContext _instance;//bu property sadece bu sınıfttan erişilebilsin diye private işaretlendi.Singleton pattern kuralı gereği static yapıldı.Bu class her çağrıldığınca newlemesin diye statci oluyor.

        public static TContext Instance// EFSingletonContext sınıfının çağrıldığı yerlerden instance almadan kullanılsın diye public static yapıldı.Tüm olay burada oluyor _instance prop. null ise sınıf newlenmemiş demektir. Bu şart sağlanınca if'in içine girip newleyecek. ve _instance prop. return edillecek
        {
            get
            {
                if (_instance==null)
                {
                    _instance = new TContext();
                }
                return _instance;
            }
        }
    }
}
