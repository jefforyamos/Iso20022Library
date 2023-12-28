﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for DTCCPayoutType3Code.  ISO2002 ID# _UEfTgKFpEeSpipW1FBSFVg.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies DTCC (The Depository Trust and Clearing Corporation) defined payout types.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IDTCCPayoutType3CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_UEfTgKFpEeSpipW1FBSFVg")]
public partial class DTCCPayoutType3CodeDropdownSource : EnumMetadataManager<DTCCPayoutType3Code,IDTCCPayoutType3CodeDropdownRow,DTCCPayoutType3CodeDropdownRow>
{
    public DTCCPayoutType3CodeDropdownSource()
        : base( (enumValue, memberInfo) => new DTCCPayoutType3CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
