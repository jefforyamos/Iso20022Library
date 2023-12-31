﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for TransactionGroupStatus3Code.  ISO2002 ID# _YrjY6Np-Ed-ak6NoX_4Aeg_-1876118210.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the status of a group of payment instructions.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="TransactionGroupStatus3CodeDropdownSource"/>.
/// Implements <seealso cref="ITransactionGroupStatus3CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_YrjY6Np-Ed-ak6NoX_4Aeg_-1876118210")]
public partial class TransactionGroupStatus3CodeDropdownRow : EnumMetadataItem<TransactionGroupStatus3Code>, ITransactionGroupStatus3CodeDropdownRow
{
    /// <summary>
    /// Specifies the status of a group of payment instructions.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public TransactionGroupStatus3CodeDropdownRow(TransactionGroupStatus3Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
