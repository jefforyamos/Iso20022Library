﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ConfirmationRequestCode.  ISO2002 ID# _0IqGIAJhEeS2H9l84F_isg.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identifies the type of confirmation message being sent.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IConfirmationRequestCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_0IqGIAJhEeS2H9l84F_isg")]
public partial class ConfirmationRequestCodeDropdownSource : EnumMetadataManager<ConfirmationRequestCode,IConfirmationRequestCodeDropdownRow,ConfirmationRequestCodeDropdownRow>
{
    public ConfirmationRequestCodeDropdownSource()
        : base( (enumValue, memberInfo) => new ConfirmationRequestCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
