﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for MessageClassCode.  ISO2002 ID# _yUpw0Bs_EeqrvK3udMUsNQ.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identifies a class of messages with the same high level function.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IMessageClassCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_yUpw0Bs_EeqrvK3udMUsNQ")]
public partial class MessageClassCodeDropdownSource : EnumMetadataManager<MessageClassCode,IMessageClassCodeDropdownRow,MessageClassCodeDropdownRow>
{
    public MessageClassCodeDropdownSource()
        : base( (enumValue, memberInfo) => new MessageClassCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
