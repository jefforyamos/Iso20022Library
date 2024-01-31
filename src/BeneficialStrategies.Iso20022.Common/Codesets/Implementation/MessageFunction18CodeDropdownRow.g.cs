﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for MessageFunction18Code.  ISO2002 ID# _QRBPYFAWEeedyPuM0kK2EQ.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identifies the type of process related to a batch management.
/// ISO 8583 MTI
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="MessageFunction18CodeDropdownSource"/>.
/// Implements <seealso cref="IMessageFunction18CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_QRBPYFAWEeedyPuM0kK2EQ")]
public partial class MessageFunction18CodeDropdownRow : EnumMetadataItem<MessageFunction18Code>, IMessageFunction18CodeDropdownRow
{
    /// <summary>
    /// Identifies the type of process related to a batch management.
    /// ISO 8583 MTI
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public MessageFunction18CodeDropdownRow(MessageFunction18Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
