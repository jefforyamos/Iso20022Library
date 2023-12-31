﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ExternalUnableToApplyMissingData1Code.  ISO2002 ID# _p-vHsN4jEeqt1ZcLzWyWFw.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason of an unable to apply due to missing data, as published in an external unable to apply missing data code set.
/// External code sets can be downloaded from www.iso20022.org.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IExternalUnableToApplyMissingData1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_p-vHsN4jEeqt1ZcLzWyWFw")]
public partial class ExternalUnableToApplyMissingData1CodeDropdownSource : EnumMetadataManager<ExternalUnableToApplyMissingData1Code,IExternalUnableToApplyMissingData1CodeDropdownRow,ExternalUnableToApplyMissingData1CodeDropdownRow>
{
    public ExternalUnableToApplyMissingData1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ExternalUnableToApplyMissingData1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
