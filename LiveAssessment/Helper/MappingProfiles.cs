using AutoMapper;
using LiveAssessment.Dto;
using LiveAssessment.Models;

namespace LiveAssessment.Helper
{
    public class MappingProfiles: Profile
    {

        public MappingProfiles()
        {

            CreateMap<Product, ProductDto>();
            CreateMap<ProductDto, Product>();


            CreateMap<Variation, VariationDto>();
            CreateMap<VariationDto, Variation>();

             

        }
    }

}
 
 