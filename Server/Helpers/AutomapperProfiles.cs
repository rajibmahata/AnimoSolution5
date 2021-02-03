using AutoMapper;
using Model.Shared;

namespace AnimoWeb.Server.Helpers
{
    public class AutomapperProfiles : Profile
    {
        public AutomapperProfiles()
        {
            CreateMap<Projects, Projects>()
                 .ForMember(x => x.Poster, option => option.Ignore())
                 .ForMember(x => x.ProjectImages, option => option.Ignore());



            CreateMap<News, News>()
                 .ForMember(x => x.PosterImage, option => option.Ignore());



        }


    }
}