﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for MessageReason2Code.  ISO2002 ID# _sVbosE0eEeea0Mdu1TOzDQ.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Reason to send the message.
/// ISO 8583:93/2003 bit 25.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IMessageReason2CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_sVbosE0eEeea0Mdu1TOzDQ")]
public partial class MessageReason2CodeDropdownSource : EnumMetadataManager<MessageReason2Code,IMessageReason2CodeDropdownRow,MessageReason2CodeDropdownRow>
{
    public MessageReason2CodeDropdownSource()
        : base( (enumValue, memberInfo) => new MessageReason2CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
