﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for DTCCPayoutType4Code.  ISO2002 ID# _qa7c8KFcEeSK_vfd3NHBGg.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies DTCC (The Depository Trust and Clearing Corporation) defined payout types.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IDTCCPayoutType4CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_qa7c8KFcEeSK_vfd3NHBGg")]
public partial class DTCCPayoutType4CodeDropdownSource : EnumMetadataManager<DTCCPayoutType4Code,IDTCCPayoutType4CodeDropdownRow,DTCCPayoutType4CodeDropdownRow>
{
    public DTCCPayoutType4CodeDropdownSource()
        : base( (enumValue, memberInfo) => new DTCCPayoutType4CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
