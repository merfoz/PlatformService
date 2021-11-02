using AutoMapper;
using PlatformService.Dtos;
using PlatformService.Models;

namespace PlatformService.Profiles
{
  public class PlatformsProfile:Profile
  {
    public PlatformsProfile()
    {
        //Source(model) => Data(dto)
      CreateMap<Platform,PlatformReadDto>();
      CreateMap<PlatformCreateDto,Platform>();
      
    }
  }
}