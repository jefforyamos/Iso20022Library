﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for MessageTypeCode.  ISO2002 ID# _aL9bs9p-Ed-ak6NoX_4Aeg_-127004772.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the message type.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="MessageTypeCodeDropdownSource"/>.
/// Implements <seealso cref="IMessageTypeCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_aL9bs9p-Ed-ak6NoX_4Aeg_-127004772")]
public partial class MessageTypeCodeDropdownRow : EnumMetadataItem<MessageTypeCode>, IMessageTypeCodeDropdownRow
{
    /// <summary>
    /// Specifies the message type.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public MessageTypeCodeDropdownRow(MessageTypeCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}