﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for MessageProtection1Code.  ISO2002 ID# _JUfXEIrgEeSvuOJS0mmL0g.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Mechanism used to protect the message of the ATM protocol.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IMessageProtection1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_JUfXEIrgEeSvuOJS0mmL0g")]
public partial class MessageProtection1CodeDropdownSource : EnumMetadataManager<MessageProtection1Code,IMessageProtection1CodeDropdownRow,MessageProtection1CodeDropdownRow>
{
    public MessageProtection1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new MessageProtection1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
