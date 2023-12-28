﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for MessageFunction18Code.  ISO2002 ID# _QRBPYFAWEeedyPuM0kK2EQ.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Identifies the type of process related to a batch management.
/// ISO 8583 MTI
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IMessageFunction18CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_QRBPYFAWEeedyPuM0kK2EQ")]
public partial class MessageFunction18CodeDropdownSource : EnumMetadataManager<MessageFunction18Code,IMessageFunction18CodeDropdownRow,MessageFunction18CodeDropdownRow>
{
    public MessageFunction18CodeDropdownSource()
        : base( (enumValue, memberInfo) => new MessageFunction18CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
