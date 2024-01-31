﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for MessageFunction20Code.  ISO2002 ID# _-KhpoFBNEeedyPuM0kK2EQ.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identifies the type of chargeback process related to the message.
/// ISO 8583 MTI
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="MessageFunction20CodeDropdownSource"/>.
/// Implements <seealso cref="IMessageFunction20CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_-KhpoFBNEeedyPuM0kK2EQ")]
public partial class MessageFunction20CodeDropdownRow : EnumMetadataItem<MessageFunction20Code>, IMessageFunction20CodeDropdownRow
{
    /// <summary>
    /// Identifies the type of chargeback process related to the message.
    /// ISO 8583 MTI
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public MessageFunction20CodeDropdownRow(MessageFunction20Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
