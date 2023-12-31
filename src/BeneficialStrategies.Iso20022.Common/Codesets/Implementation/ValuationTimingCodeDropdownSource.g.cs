﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ValuationTimingCode.  ISO2002 ID# _Y8_HINp-Ed-ak6NoX_4Aeg_1401456451.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies how the price valuation timing is done based on the timeline defined in the prospectus.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IValuationTimingCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Y8_HINp-Ed-ak6NoX_4Aeg_1401456451")]
public partial class ValuationTimingCodeDropdownSource : EnumMetadataManager<ValuationTimingCode,IValuationTimingCodeDropdownRow,ValuationTimingCodeDropdownRow>
{
    public ValuationTimingCodeDropdownSource()
        : base( (enumValue, memberInfo) => new ValuationTimingCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
