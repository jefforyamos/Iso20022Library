﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for RejectionReason14Code.  ISO2002 ID# _Zg5Fddp-Ed-ak6NoX_4Aeg_1895706471.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason of a rejection of a movement cancellation request.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IRejectionReason14CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Zg5Fddp-Ed-ak6NoX_4Aeg_1895706471")]
public partial class RejectionReason14CodeDropdownSource : EnumMetadataManager<RejectionReason14Code,IRejectionReason14CodeDropdownRow,RejectionReason14CodeDropdownRow>
{
    public RejectionReason14CodeDropdownSource()
        : base( (enumValue, memberInfo) => new RejectionReason14CodeDropdownRow(enumValue, memberInfo))
    {
    }
}