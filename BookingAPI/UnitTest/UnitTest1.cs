using BookingAPI.Controllers;
using BookingAPI.Models.ApartmentModels;
using Microsoft.AspNetCore.Mvc.Testing;
using System.Diagnostics.CodeAnalysis;
using System.Net.Http.Json;

namespace UnitTest
{
    public class UnitTest1 : IClassFixture<WebApplicationFactory<ApartmentsController>>
    {

        private readonly HttpClient _sut;

        public UnitTest1(WebApplicationFactory<ApartmentsController> factory)
        {
            _sut = factory.CreateClient();
        }
    
        [Fact]
        public async void GetAllShouldReturnCollectionOfApartments()
        {
            var apartments = await _sut.GetFromJsonAsync<List<GetApartment>>("apartments");
            Assert.NotNull(apartments);
            Assert.Equal(typeof(List<GetApartment>), apartments.GetType());
            
        }

        [Fact]
        public async void AddApartmentShouldReturnCreate()
        {
            var request = new PostApartment
            {
                Address = "califragilistichespiralitoso",
                Name ="Mary Poppins",
                Sqm = 123.4
            };

            var expetedContent = new Apartment
            {
                Address = "califragilistichespiralitoso",
                Name = "Mary Poppins",
                Sqm = 123.4
            };

            var response = await _sut.PostAsJsonAsync("apartments", request);
            var actualContent = await response.Content.ReadFromJsonAsync<Apartment>();

            Assert.True(response.IsSuccessStatusCode);
            Assert.Equal(expetedContent, actualContent, new ApartmentComparer());
        }
    }

    internal class ApartmentComparer : IEqualityComparer<Apartment?>
    {
        public bool Equals(Apartment? x, Apartment? y)
        {
            if (ReferenceEquals(x, y)) return true;
            if (ReferenceEquals(x, null)) return false;
            if (ReferenceEquals(y, null)) return false;
            if (x.GetType() != y.GetType()) return false;
            return
                x.Address.Equals(y.Address)
                && x.Name.Equals(y.Name)
                && x.Sqm == y.Sqm;
        }

        public int GetHashCode([DisallowNull] Apartment obj)
        {
            throw new NotImplementedException();
        }
    }
}
