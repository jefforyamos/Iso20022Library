﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for MessageStatusCode.  ISO2002 ID# _-yEE8NHAEeaokquJJ-K6uA.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the status of a whole message processing.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IMessageStatusCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_-yEE8NHAEeaokquJJ-K6uA")]
public partial class MessageStatusCodeDropdownSource : EnumMetadataManager<MessageStatusCode,IMessageStatusCodeDropdownRow,MessageStatusCodeDropdownRow>
{
    public MessageStatusCodeDropdownSource()
        : base( (enumValue, memberInfo) => new MessageStatusCodeDropdownRow(enumValue, memberInfo))
    {
    }
}