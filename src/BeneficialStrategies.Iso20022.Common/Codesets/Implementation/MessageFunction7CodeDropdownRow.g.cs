﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for MessageFunction7Code.  ISO2002 ID# _ha36YInyEeS9F4Qrq_eaVA.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Identifies the type of process related to an ATM message.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="MessageFunction7CodeDropdownSource"/>.
/// Implements <seealso cref="IMessageFunction7CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ha36YInyEeS9F4Qrq_eaVA")]
public partial class MessageFunction7CodeDropdownRow : EnumMetadataItem<MessageFunction7Code>, IMessageFunction7CodeDropdownRow
{
    /// <summary>
    /// Identifies the type of process related to an ATM message.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public MessageFunction7CodeDropdownRow(MessageFunction7Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
