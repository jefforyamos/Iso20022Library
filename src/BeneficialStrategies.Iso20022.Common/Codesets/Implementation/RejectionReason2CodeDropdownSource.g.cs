﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for RejectionReason2Code.  ISO2002 ID# _Zkxf4tp-Ed-ak6NoX_4Aeg_-699938374.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason why the instruction/cancellation request has a rejected status.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IRejectionReason2CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Zkxf4tp-Ed-ak6NoX_4Aeg_-699938374")]
public partial class RejectionReason2CodeDropdownSource : EnumMetadataManager<RejectionReason2Code,IRejectionReason2CodeDropdownRow,RejectionReason2CodeDropdownRow>
{
    public RejectionReason2CodeDropdownSource()
        : base( (enumValue, memberInfo) => new RejectionReason2CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
