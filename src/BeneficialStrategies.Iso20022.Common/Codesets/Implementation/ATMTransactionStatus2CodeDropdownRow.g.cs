﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ATMTransactionStatus2Code.  ISO2002 ID# _6bELsIqSEeSRT5rEzcAHEw.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Status of the amount presented to the customer in the last bundle.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ATMTransactionStatus2CodeDropdownSource"/>.
/// Implements <seealso cref="IATMTransactionStatus2CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_6bELsIqSEeSRT5rEzcAHEw")]
public partial class ATMTransactionStatus2CodeDropdownRow : EnumMetadataItem<ATMTransactionStatus2Code>, IATMTransactionStatus2CodeDropdownRow
{
    /// <summary>
    /// Status of the amount presented to the customer in the last bundle.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ATMTransactionStatus2CodeDropdownRow(ATMTransactionStatus2Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
