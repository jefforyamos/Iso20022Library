﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for TransactionChannel3Code.  ISO2002 ID# _sSD7UWkBEeS7zPBpvm732w.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Identifies the type of the communication channels used by the cardholder to the acceptor system.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="TransactionChannel3CodeDropdownSource"/>.
/// Implements <seealso cref="ITransactionChannel3CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_sSD7UWkBEeS7zPBpvm732w")]
public partial class TransactionChannel3CodeDropdownRow : EnumMetadataItem<TransactionChannel3Code>, ITransactionChannel3CodeDropdownRow
{
    /// <summary>
    /// Identifies the type of the communication channels used by the cardholder to the acceptor system.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public TransactionChannel3CodeDropdownRow(TransactionChannel3Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
