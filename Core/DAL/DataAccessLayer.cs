using Core.Model;

namespace Core.DAL
{
    public class DataAccessLayer
    {
        public static void Add(Pair pair)
        {
            using (var context = new Core.DAL.Context())
            {
                context.Pairs.Add(pair);
                context.SaveChanges();
            }
        }
    }
}
