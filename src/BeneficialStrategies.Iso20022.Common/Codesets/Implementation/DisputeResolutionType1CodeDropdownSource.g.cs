﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for DisputeResolutionType1Code.  ISO2002 ID# _YcWfRdp-Ed-ak6NoX_4Aeg_-299139141.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the nature of the disputed collateral amount.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IDisputeResolutionType1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_YcWfRdp-Ed-ak6NoX_4Aeg_-299139141")]
public partial class DisputeResolutionType1CodeDropdownSource : EnumMetadataManager<DisputeResolutionType1Code,IDisputeResolutionType1CodeDropdownRow,DisputeResolutionType1CodeDropdownRow>
{
    public DisputeResolutionType1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new DisputeResolutionType1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
