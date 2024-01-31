﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for MessageFunction13Code.  ISO2002 ID# _x8NHsBCIEeeriKqGwDrUEg.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of message supporting a service.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IMessageFunction13CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_x8NHsBCIEeeriKqGwDrUEg")]
public partial class MessageFunction13CodeDropdownSource : EnumMetadataManager<MessageFunction13Code,IMessageFunction13CodeDropdownRow,MessageFunction13CodeDropdownRow>
{
    public MessageFunction13CodeDropdownSource()
        : base( (enumValue, memberInfo) => new MessageFunction13CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
