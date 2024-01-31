﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ErrorHandlingCode.  ISO2002 ID# _ah3aSNp-Ed-ak6NoX_4Aeg_2042159796.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Error codes generated when the response to a query exceeds the maximum size or the data is not available.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ErrorHandlingCodeDropdownSource"/>.
/// Implements <seealso cref="IErrorHandlingCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ah3aSNp-Ed-ak6NoX_4Aeg_2042159796")]
public partial class ErrorHandlingCodeDropdownRow : EnumMetadataItem<ErrorHandlingCode>, IErrorHandlingCodeDropdownRow
{
    /// <summary>
    /// Error codes generated when the response to a query exceeds the maximum size or the data is not available.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ErrorHandlingCodeDropdownRow(ErrorHandlingCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
