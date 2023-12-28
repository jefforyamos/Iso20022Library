﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for SettlementStatus3Code.  ISO2002 ID# _GbRzsAF1EeutW5-TpeYJhA.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the status of the settlement of a trade in a central matching and settlement system.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ISettlementStatus3CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_GbRzsAF1EeutW5-TpeYJhA")]
public partial class SettlementStatus3CodeDropdownSource : EnumMetadataManager<SettlementStatus3Code,ISettlementStatus3CodeDropdownRow,SettlementStatus3CodeDropdownRow>
{
    public SettlementStatus3CodeDropdownSource()
        : base( (enumValue, memberInfo) => new SettlementStatus3CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
