﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for RegistrationProcessingStatus1Code.  ISO2002 ID# _ZbFYYNp-Ed-ak6NoX_4Aeg_-586829209.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the status of the registration processing.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IRegistrationProcessingStatus1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZbFYYNp-Ed-ak6NoX_4Aeg_-586829209")]
public partial class RegistrationProcessingStatus1CodeDropdownSource : EnumMetadataManager<RegistrationProcessingStatus1Code,IRegistrationProcessingStatus1CodeDropdownRow,RegistrationProcessingStatus1CodeDropdownRow>
{
    public RegistrationProcessingStatus1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new RegistrationProcessingStatus1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}