﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ErrorHandlingCode.  ISO2002 ID# _ah3aSNp-Ed-ak6NoX_4Aeg_2042159796.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Error codes generated when the response to a query exceeds the maximum size or the data is not available.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IErrorHandlingCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ah3aSNp-Ed-ak6NoX_4Aeg_2042159796")]
public partial class ErrorHandlingCodeDropdownSource : EnumMetadataManager<ErrorHandlingCode,IErrorHandlingCodeDropdownRow,ErrorHandlingCodeDropdownRow>
{
    public ErrorHandlingCodeDropdownSource()
        : base( (enumValue, memberInfo) => new ErrorHandlingCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
