using AutoMapper;
using PlatformService.Dtos;
using PlatformService.Models;

namespace PlatformService.Profiles
{
    public class PlatformsProfile : Profile
    {
        public PlatformsProfile()
        {
            // Source -> Target (Model To Dto)
            CreateMap<Platform, PlatformReadDto>();
            // CreateMap<Platform, PlatformCreateDto>();

            // Target -> Source(Dto To Model)
            // CreateMap<PlatformReadDto, Platform>();
            CreateMap<PlatformCreateDto, Platform>();
        }
    }
}
