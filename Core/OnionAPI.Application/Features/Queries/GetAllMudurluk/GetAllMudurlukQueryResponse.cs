using OnionAPI.Application.DTOs.Mudurluks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionAPI.Application.Features.Queries.GetAllMudurluk
{
    public class GetAllMudurlukQueryResponse
    {
        public List<MudurlukDTO> Mudurlukler { get; set; }
    }
}
