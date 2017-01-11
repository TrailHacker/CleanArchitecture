using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanArchitecture.Core.SharedKernel;

namespace CleanArchitecture.Core.Entities
{
    public class Guestbook : BaseEntity
    {
		public string Name { get; set; }
		public IList<GuestbookEntry> Entries { get; } = new List<GuestbookEntry>();
    }
}
