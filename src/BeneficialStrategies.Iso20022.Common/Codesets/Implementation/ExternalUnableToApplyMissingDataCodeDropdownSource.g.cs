﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ExternalUnableToApplyMissingDataCode.  ISO2002 ID# _p-vHdN4jEeqt1ZcLzWyWFw.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason of an unable to apply due to missing data, as published in an external unable to apply missing data code set.
/// External code sets can be downloaded from www.iso20022.org.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IExternalUnableToApplyMissingDataCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_p-vHdN4jEeqt1ZcLzWyWFw")]
public partial class ExternalUnableToApplyMissingDataCodeDropdownSource : EnumMetadataManager<ExternalUnableToApplyMissingDataCode,IExternalUnableToApplyMissingDataCodeDropdownRow,ExternalUnableToApplyMissingDataCodeDropdownRow>
{
    public ExternalUnableToApplyMissingDataCodeDropdownSource()
        : base( (enumValue, memberInfo) => new ExternalUnableToApplyMissingDataCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
