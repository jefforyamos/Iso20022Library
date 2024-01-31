﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for OptionAvailabilityStatusCode.  ISO2002 ID# _aPYjINp-Ed-ak6NoX_4Aeg_2038667803.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of the option availability.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IOptionAvailabilityStatusCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_aPYjINp-Ed-ak6NoX_4Aeg_2038667803")]
public partial class OptionAvailabilityStatusCodeDropdownSource : EnumMetadataManager<OptionAvailabilityStatusCode,IOptionAvailabilityStatusCodeDropdownRow,OptionAvailabilityStatusCodeDropdownRow>
{
    public OptionAvailabilityStatusCodeDropdownSource()
        : base( (enumValue, memberInfo) => new OptionAvailabilityStatusCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
