using AutoFixture;
using AutoMapper;
using DGII.Api.Controllers;
using DGII.DataAccess.UnitOfWork;
using DGII.Domain.Entities;
using DGII.Domain.EntitiesDto;
using DGII.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DGII.Test
{
    
    public class ContribuyentesControllerTest
    {
        private readonly IFixture _fixture;
        private readonly Mock<IUnitOfWork> _serviceMock;
        private readonly Mock<IMapper> _mapper;
        private readonly ContribuyenteController _controller;

        public ContribuyentesControllerTest()
        {
            _fixture = new Fixture();
            _serviceMock = _fixture.Freeze<Mock<IUnitOfWork>>();
            _mapper = _fixture.Freeze<Mock<IMapper>>();
            _controller = new ContribuyenteController(_serviceMock.Object, _mapper.Object);
        }

        [Fact]
        public void PostContribuyentes()
        {
            //Arrange
            var data = _fixture.Create<Contribuyentes>();
            _serviceMock.Setup(a => a.Contribuyentes.Add(data));

            //Act
            var contribuyenteadd = new ContribuyentesDto
            {
                RncCedula = "40245898654",
                Nombre = "Pedro Sanchez",
                TipoId = 1,
                status = true
            };
            var newcontribuyente = _controller.Post(contribuyenteadd);

            //Assert
            Assert.NotNull(newcontribuyente);
        }

        [Fact]
        public void GetContribuyentes()
        {
            //Arrange
            var data = _fixture.Create<IEnumerable<ContribuyentesDto>>();
            _serviceMock.Setup(a => a.Contribuyentes.GetContribuyentes()).Returns(data);

            //Act
            var contribuyentes = _controller.Get();

            //Assert
            Assert.NotNull(contribuyentes);
        }
    }
}
