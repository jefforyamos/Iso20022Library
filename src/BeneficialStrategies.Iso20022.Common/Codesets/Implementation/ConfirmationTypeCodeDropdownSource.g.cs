﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ConfirmationTypeCode.  ISO2002 ID# _VqbxQdp-Ed-ak6NoX_4Aeg_-1345554396.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies whether a message is an intention to execute a transfer instruction or an actual confirmation of the execution of the transfer.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IConfirmationTypeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_VqbxQdp-Ed-ak6NoX_4Aeg_-1345554396")]
public partial class ConfirmationTypeCodeDropdownSource : EnumMetadataManager<ConfirmationTypeCode,IConfirmationTypeCodeDropdownRow,ConfirmationTypeCodeDropdownRow>
{
    public ConfirmationTypeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new ConfirmationTypeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}