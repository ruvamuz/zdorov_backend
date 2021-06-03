using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lohotron.Model
{
    public class LOH
    {
        public int id { get; set; }
        public string fullname { get; set; }
        public string inn { get; set; }
        public string telephone { get; set; }
        public string vaccinationpoint { get; set; }
    }

    public interface ILohManager
    {
        List<LOH> Get();
        void Create(LOH loh);
    }
}
