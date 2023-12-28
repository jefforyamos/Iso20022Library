﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for TransactionType2Code.  ISO2002 ID# _Yuh0Zdp-Ed-ak6NoX_4Aeg_-872010891.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of transaction.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="TransactionType2CodeDropdownSource"/>.
/// Implements <seealso cref="ITransactionType2CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Yuh0Zdp-Ed-ak6NoX_4Aeg_-872010891")]
public partial class TransactionType2CodeDropdownRow : EnumMetadataItem<TransactionType2Code>, ITransactionType2CodeDropdownRow
{
    /// <summary>
    /// Specifies the type of transaction.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public TransactionType2CodeDropdownRow(TransactionType2Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}