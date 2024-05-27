using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelApp.Repository
{
    public class Repository
    {
        public void insertDiscussion(Discussion discussion)
        {
            using (var db = new EFContext())
            {
                db.Add(discussion);
                db.SaveChanges();
            }
            return;
        }
        public static List<string> getDiscussions()
        {
            using (var db = new EFContext())
            {
                return db.Discussions.Select(d => $"{d.createdOn.ToString("dddd, dd MMMM yyyy HH:mm")} - {d.user}: {d.message}").ToList();
            }
        }
    }
}
