﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for TransactionGroupStatus2Code.  ISO2002 ID# _YrjY5dp-Ed-ak6NoX_4Aeg_14174870.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the status of a group of payment transactions.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="TransactionGroupStatus2CodeDropdownSource"/>.
/// Implements <seealso cref="ITransactionGroupStatus2CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_YrjY5dp-Ed-ak6NoX_4Aeg_14174870")]
public partial class TransactionGroupStatus2CodeDropdownRow : EnumMetadataItem<TransactionGroupStatus2Code>, ITransactionGroupStatus2CodeDropdownRow
{
    /// <summary>
    /// Specifies the status of a group of payment transactions.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public TransactionGroupStatus2CodeDropdownRow(TransactionGroupStatus2Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
