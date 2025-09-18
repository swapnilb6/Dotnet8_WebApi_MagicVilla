using Magic_Viilla_API.Models;
using Magic_Viilla_API.Models.DTO;

namespace Magic_Viilla_API.Data
{
    public static class VillaStore
    {
        public static List<VillaDto> Villalist = new List<VillaDto>()
        {
            new VillaDto { Id = 1, Name = "Pool Villa" },
            new VillaDto { Id = 2, Name = "Beach Villa"},
            new VillaDto { Id = 3, Name = "Mountain Villa" }
        };  
    }
}
