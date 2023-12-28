﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for AdditionalBusinessProcess6Code.  ISO2002 ID# _YLOfAWH-EeWNUe-5HV3A_g.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the additional business process linked to a corporate action event.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IAdditionalBusinessProcess6CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_YLOfAWH-EeWNUe-5HV3A_g")]
public partial class AdditionalBusinessProcess6CodeDropdownSource : EnumMetadataManager<AdditionalBusinessProcess6Code,IAdditionalBusinessProcess6CodeDropdownRow,AdditionalBusinessProcess6CodeDropdownRow>
{
    public AdditionalBusinessProcess6CodeDropdownSource()
        : base( (enumValue, memberInfo) => new AdditionalBusinessProcess6CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
