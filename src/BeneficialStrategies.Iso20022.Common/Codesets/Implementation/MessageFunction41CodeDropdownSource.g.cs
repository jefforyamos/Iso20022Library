﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for MessageFunction41Code.  ISO2002 ID# _Vb_nYQ0xEeqUVL7sB4m7NA.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of message supporting a service.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IMessageFunction41CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Vb_nYQ0xEeqUVL7sB4m7NA")]
public partial class MessageFunction41CodeDropdownSource : EnumMetadataManager<MessageFunction41Code,IMessageFunction41CodeDropdownRow,MessageFunction41CodeDropdownRow>
{
    public MessageFunction41CodeDropdownSource()
        : base( (enumValue, memberInfo) => new MessageFunction41CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
