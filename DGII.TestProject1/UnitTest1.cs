using AutoMapper;
using DGII.Api.Controllers;
using DGII.DataAccess.UnitOfWork;

namespace DGII.TestProject1
{
    public class UnitTest1
    {
        private readonly ContribuyenteController _controller;

        public UnitTest1(UnitOfWork unitOfWork, IMapper mapper)
        {

            _controller = new ContribuyenteController(unitOfWork, mapper);
        }

        [Fact]
        public void Test1()
        {
            var data = _controller.Get();
        }
    }
}