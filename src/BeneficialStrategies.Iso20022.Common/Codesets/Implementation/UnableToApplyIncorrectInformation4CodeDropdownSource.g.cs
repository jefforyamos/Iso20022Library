﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for UnableToApplyIncorrectInformation4Code.  ISO2002 ID# _hRURCEgsEeaGKYpLDboHPQ.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason of an unable to apply due to incorrect information.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IUnableToApplyIncorrectInformation4CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_hRURCEgsEeaGKYpLDboHPQ")]
public partial class UnableToApplyIncorrectInformation4CodeDropdownSource : EnumMetadataManager<UnableToApplyIncorrectInformation4Code,IUnableToApplyIncorrectInformation4CodeDropdownRow,UnableToApplyIncorrectInformation4CodeDropdownRow>
{
    public UnableToApplyIncorrectInformation4CodeDropdownSource()
        : base( (enumValue, memberInfo) => new UnableToApplyIncorrectInformation4CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
