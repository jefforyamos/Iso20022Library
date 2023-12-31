﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ValidationGroupStatus1Code.  ISO2002 ID# _Y8sMMtp-Ed-ak6NoX_4Aeg_1671956586.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates the status of a single payment transaction or of a group of payment transactions.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IValidationGroupStatus1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Y8sMMtp-Ed-ak6NoX_4Aeg_1671956586")]
public partial class ValidationGroupStatus1CodeDropdownSource : EnumMetadataManager<ValidationGroupStatus1Code,IValidationGroupStatus1CodeDropdownRow,ValidationGroupStatus1CodeDropdownRow>
{
    public ValidationGroupStatus1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ValidationGroupStatus1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
