﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ATMCommandCode.  ISO2002 ID# _T4nIoIqJEeSRT5rEzcAHEw.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of command performed by an ATM.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IATMCommandCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_T4nIoIqJEeSRT5rEzcAHEw")]
public partial class ATMCommandCodeDropdownSource : EnumMetadataManager<ATMCommandCode,IATMCommandCodeDropdownRow,ATMCommandCodeDropdownRow>
{
    public ATMCommandCodeDropdownSource()
        : base( (enumValue, memberInfo) => new ATMCommandCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
