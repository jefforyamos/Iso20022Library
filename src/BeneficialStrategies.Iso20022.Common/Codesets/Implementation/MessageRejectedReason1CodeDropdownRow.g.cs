﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for MessageRejectedReason1Code.  ISO2002 ID# _aL9bsNp-Ed-ak6NoX_4Aeg_1406401816.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason for a message rejected status.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="MessageRejectedReason1CodeDropdownSource"/>.
/// Implements <seealso cref="IMessageRejectedReason1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_aL9bsNp-Ed-ak6NoX_4Aeg_1406401816")]
public partial class MessageRejectedReason1CodeDropdownRow : EnumMetadataItem<MessageRejectedReason1Code>, IMessageRejectedReason1CodeDropdownRow
{
    /// <summary>
    /// Specifies the reason for a message rejected status.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public MessageRejectedReason1CodeDropdownRow(MessageRejectedReason1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
