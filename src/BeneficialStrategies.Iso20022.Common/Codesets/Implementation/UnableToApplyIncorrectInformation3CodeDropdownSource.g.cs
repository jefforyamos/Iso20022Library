﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for UnableToApplyIncorrectInformation3Code.  ISO2002 ID# _Y0MXh9p-Ed-ak6NoX_4Aeg_-660282894.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason of an unable to apply due to incorrect information.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IUnableToApplyIncorrectInformation3CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Y0MXh9p-Ed-ak6NoX_4Aeg_-660282894")]
public partial class UnableToApplyIncorrectInformation3CodeDropdownSource : EnumMetadataManager<UnableToApplyIncorrectInformation3Code,IUnableToApplyIncorrectInformation3CodeDropdownRow,UnableToApplyIncorrectInformation3CodeDropdownRow>
{
    public UnableToApplyIncorrectInformation3CodeDropdownSource()
        : base( (enumValue, memberInfo) => new UnableToApplyIncorrectInformation3CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
