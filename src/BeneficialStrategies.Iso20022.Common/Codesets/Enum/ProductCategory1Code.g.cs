﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ProductCategory1Code.  ISO2002 ID# _aLN02Np-Ed-ak6NoX_4Aeg_1399265867.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the category of a product.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aLN02Np-Ed-ak6NoX_4Aeg_1399265867")]
[Description(@"Specifies the category of a product.")]
[DerivedFrom(typeof(ProductCategoryCode))]
public enum ProductCategory1Code
{
    /// <summary>
    /// Classification of goods as developed by the Customs Cooperation council.
    /// Encoded/decoded by serializers as "HarmonizedTariffCodeName".
    /// </summary>
    [EnumMember(Value = "HRTR")]
    [IsoId("_aLXl0Np-Ed-ak6NoX_4Aeg_1456527208")]
    [Description(@"Classification of goods as developed by the Customs Cooperation council.")]
    HarmonizedTariffCodeName,
    
    /// <summary>
    /// Product identifier used by the retail industry.
    /// Encoded/decoded by serializers as "QuotaCategory".
    /// </summary>
    [EnumMember(Value = "QOTA")]
    [IsoId("_aLXl0dp-Ed-ak6NoX_4Aeg_1456527268")]
    [Description(@"Product identifier used by the retail industry.")]
    QuotaCategory,
    
    /// <summary>
    /// Product Group Code.
    /// Encoded/decoded by serializers as "ProductGroup".
    /// </summary>
    [EnumMember(Value = "PRGP")]
    [IsoId("_aLXl0tp-Ed-ak6NoX_4Aeg_1456527285")]
    [Description(@"Product Group Code.")]
    ProductGroup,
    
    /// <summary>
    /// Line of business code.
    /// Encoded/decoded by serializers as "LineOfBusiness".
    /// </summary>
    [EnumMember(Value = "LOBU")]
    [IsoId("_aLXl09p-Ed-ak6NoX_4Aeg_1456527286")]
    [Description(@"Line of business code.")]
    LineOfBusiness,
    
    /// <summary>
    /// Code for gender.
    /// Encoded/decoded by serializers as "Gender".
    /// </summary>
    [EnumMember(Value = "GNDR")]
    [IsoId("_aLXl1Np-Ed-ak6NoX_4Aeg_1456527520")]
    [Description(@"Code for gender.")]
    Gender,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ProductCategory1CodeMetadataExtensions
{
    private static readonly ProductCategory1CodeDropdownSource _dropdownSource = new ProductCategory1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IProductCategory1CodeDropdownRow GetMetadata(this ProductCategory1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


