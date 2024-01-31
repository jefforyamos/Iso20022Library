﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for DTCCPayoutTypeCode.  ISO2002 ID# _1o-QojL3EeKU9IrkkToqcw_-806320900.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies DTCC (The Depository Trust and Clearing Corporation) defined payout types.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IDTCCPayoutTypeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_1o-QojL3EeKU9IrkkToqcw_-806320900")]
public partial class DTCCPayoutTypeCodeDropdownSource : EnumMetadataManager<DTCCPayoutTypeCode,IDTCCPayoutTypeCodeDropdownRow,DTCCPayoutTypeCodeDropdownRow>
{
    public DTCCPayoutTypeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new DTCCPayoutTypeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
