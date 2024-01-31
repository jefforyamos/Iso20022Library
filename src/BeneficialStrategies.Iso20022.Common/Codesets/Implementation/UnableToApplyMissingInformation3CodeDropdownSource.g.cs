﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for UnableToApplyMissingInformation3Code.  ISO2002 ID# _hRURLkgsEeaGKYpLDboHPQ.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason of an unable to apply due to missing information.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IUnableToApplyMissingInformation3CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_hRURLkgsEeaGKYpLDboHPQ")]
public partial class UnableToApplyMissingInformation3CodeDropdownSource : EnumMetadataManager<UnableToApplyMissingInformation3Code,IUnableToApplyMissingInformation3CodeDropdownRow,UnableToApplyMissingInformation3CodeDropdownRow>
{
    public UnableToApplyMissingInformation3CodeDropdownSource()
        : base( (enumValue, memberInfo) => new UnableToApplyMissingInformation3CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
