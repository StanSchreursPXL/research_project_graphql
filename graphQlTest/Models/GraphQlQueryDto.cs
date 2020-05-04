using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace graphQlServer.Models
{
    public class GraphQlQueryDto
    {
        public string Query { get; set; }
        public string Variables { get; set; }
    }
}
