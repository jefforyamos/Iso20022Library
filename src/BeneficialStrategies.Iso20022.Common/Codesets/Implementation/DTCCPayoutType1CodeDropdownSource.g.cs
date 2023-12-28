﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for DTCCPayoutType1Code.  ISO2002 ID# _1rD7UzL3EeKU9IrkkToqcw_1294109799.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies DTCC (The Depository Trust and Clearing Corporation) defined payout types.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IDTCCPayoutType1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_1rD7UzL3EeKU9IrkkToqcw_1294109799")]
public partial class DTCCPayoutType1CodeDropdownSource : EnumMetadataManager<DTCCPayoutType1Code,IDTCCPayoutType1CodeDropdownRow,DTCCPayoutType1CodeDropdownRow>
{
    public DTCCPayoutType1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new DTCCPayoutType1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}