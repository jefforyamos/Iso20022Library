﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for TransactionChannel1Code.  ISO2002 ID# _TUAMOQEcEeCQm6a_G2yO_w_2033954837.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Identifies the type of the communication channels used by the cardholder to the acceptor system.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="TransactionChannel1CodeDropdownSource"/>.
/// Implements <seealso cref="ITransactionChannel1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_TUAMOQEcEeCQm6a_G2yO_w_2033954837")]
public partial class TransactionChannel1CodeDropdownRow : EnumMetadataItem<TransactionChannel1Code>, ITransactionChannel1CodeDropdownRow
{
    /// <summary>
    /// Identifies the type of the communication channels used by the cardholder to the acceptor system.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public TransactionChannel1CodeDropdownRow(TransactionChannel1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}