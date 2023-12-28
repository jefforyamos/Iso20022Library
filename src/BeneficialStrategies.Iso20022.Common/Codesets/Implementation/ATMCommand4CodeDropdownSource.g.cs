﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ATMCommand4Code.  ISO2002 ID# _pcGN4a2BEeWMg5rOByfExw.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of command to be performed by an ATM.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IATMCommand4CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_pcGN4a2BEeWMg5rOByfExw")]
public partial class ATMCommand4CodeDropdownSource : EnumMetadataManager<ATMCommand4Code,IATMCommand4CodeDropdownRow,ATMCommand4CodeDropdownRow>
{
    public ATMCommand4CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ATMCommand4CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
