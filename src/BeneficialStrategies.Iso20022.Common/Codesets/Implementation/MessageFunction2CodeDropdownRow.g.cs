﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for MessageFunction2Code.  ISO2002 ID# _TRnmlQEcEeCQm6a_G2yO_w_1237934743.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the function of the message.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="MessageFunction2CodeDropdownSource"/>.
/// Implements <seealso cref="IMessageFunction2CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_TRnmlQEcEeCQm6a_G2yO_w_1237934743")]
public partial class MessageFunction2CodeDropdownRow : EnumMetadataItem<MessageFunction2Code>, IMessageFunction2CodeDropdownRow
{
    /// <summary>
    /// Specifies the function of the message.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public MessageFunction2CodeDropdownRow(MessageFunction2Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
