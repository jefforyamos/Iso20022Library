﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ESGCategoryGermanStructuredSecuritiesMarket1Code.  ISO2002 ID# _tIOpsNAKEeuSBa1PsnseFg.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the category of structured securities product.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IESGCategoryGermanStructuredSecuritiesMarket1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_tIOpsNAKEeuSBa1PsnseFg")]
public partial class ESGCategoryGermanStructuredSecuritiesMarket1CodeDropdownSource : EnumMetadataManager<ESGCategoryGermanStructuredSecuritiesMarket1Code,IESGCategoryGermanStructuredSecuritiesMarket1CodeDropdownRow,ESGCategoryGermanStructuredSecuritiesMarket1CodeDropdownRow>
{
    public ESGCategoryGermanStructuredSecuritiesMarket1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ESGCategoryGermanStructuredSecuritiesMarket1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
