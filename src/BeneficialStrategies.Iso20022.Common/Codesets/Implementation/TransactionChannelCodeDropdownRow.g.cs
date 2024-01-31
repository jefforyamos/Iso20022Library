﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for TransactionChannelCode.  ISO2002 ID# _TVWQBgEcEeCQm6a_G2yO_w_644173117.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of communication channel.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="TransactionChannelCodeDropdownSource"/>.
/// Implements <seealso cref="ITransactionChannelCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_TVWQBgEcEeCQm6a_G2yO_w_644173117")]
public partial class TransactionChannelCodeDropdownRow : EnumMetadataItem<TransactionChannelCode>, ITransactionChannelCodeDropdownRow
{
    /// <summary>
    /// Specifies the type of communication channel.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public TransactionChannelCodeDropdownRow(TransactionChannelCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
