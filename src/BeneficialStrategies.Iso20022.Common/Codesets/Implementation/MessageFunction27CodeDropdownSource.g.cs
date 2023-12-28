﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for MessageFunction27Code.  ISO2002 ID# _qIPhcFW7EeeiG_nL4vgKnQ.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Information related to the protocol management.
/// ISO 8583 MTI.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IMessageFunction27CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_qIPhcFW7EeeiG_nL4vgKnQ")]
public partial class MessageFunction27CodeDropdownSource : EnumMetadataManager<MessageFunction27Code,IMessageFunction27CodeDropdownRow,MessageFunction27CodeDropdownRow>
{
    public MessageFunction27CodeDropdownSource()
        : base( (enumValue, memberInfo) => new MessageFunction27CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
