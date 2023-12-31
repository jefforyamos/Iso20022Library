﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for MessageFunction10Code.  ISO2002 ID# _PCEoYY0PEeWRYffwL7E13A.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Identifies the message function within a card payment exchange.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="MessageFunction10CodeDropdownSource"/>.
/// Implements <seealso cref="IMessageFunction10CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_PCEoYY0PEeWRYffwL7E13A")]
public partial class MessageFunction10CodeDropdownRow : EnumMetadataItem<MessageFunction10Code>, IMessageFunction10CodeDropdownRow
{
    /// <summary>
    /// Identifies the message function within a card payment exchange.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public MessageFunction10CodeDropdownRow(MessageFunction10Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
