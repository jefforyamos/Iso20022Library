﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for RejectionReason10Code.  ISO2002 ID# _ZgdAlNp-Ed-ak6NoX_4Aeg_1761795494.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason of a rejection of a standing instruction cancellation request.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IRejectionReason10CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZgdAlNp-Ed-ak6NoX_4Aeg_1761795494")]
public partial class RejectionReason10CodeDropdownSource : EnumMetadataManager<RejectionReason10Code,IRejectionReason10CodeDropdownRow,RejectionReason10CodeDropdownRow>
{
    public RejectionReason10CodeDropdownSource()
        : base( (enumValue, memberInfo) => new RejectionReason10CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
