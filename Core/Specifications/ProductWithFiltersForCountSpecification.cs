using Core.Entities;

namespace Core.Specifications
{
    public class ProductWithFiltersForCountSpecification : BaseSpecification<Product>
    {
        public ProductWithFiltersForCountSpecification(ProductSpecParams productParams)       
            : base ( x => 
                (string.IsNullOrEmpty(productParams.Search) || x.Name.ToLower().Contains(productParams.Search))&&
                (!productParams.brandId.HasValue || x.ProductBrandId == productParams.brandId) && 
                (!productParams.typeId.HasValue || x.ProductTypeId == productParams.typeId))
        {
            
        }
    }
}