using AutoMapper;
using MediatR;
using OnionAPI.Application.DTOs.Mudurluks;
using OnionAPI.Application.UnitOfWork;

namespace OnionAPI.Application.Features.Queries.GetAllMudurluk
{
    internal class GetAllMudurlukQueryHandler : IRequestHandler<GetAllMudurlukQueryRequest, GetAllMudurlukQueryResponse>
    {
        readonly IMapper _mapper;
        readonly IUnitOfWork _unitOfWork;

        public GetAllMudurlukQueryHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task<GetAllMudurlukQueryResponse> Handle(GetAllMudurlukQueryRequest request, CancellationToken cancellationToken)
        {
            var mudurlukler = _mapper.Map<List<MudurlukDTO>>(_unitOfWork.MudurlukReadRepository.GetAllFromCache());
            return new()
            {
                Mudurlukler = mudurlukler
            };
        }
    }
}
