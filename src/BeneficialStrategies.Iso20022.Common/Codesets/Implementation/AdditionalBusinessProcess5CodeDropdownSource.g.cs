﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for AdditionalBusinessProcess5Code.  ISO2002 ID# _Kr4lAWH-EeWNUe-5HV3A_g.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the additional business process linked to a corporate action event.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IAdditionalBusinessProcess5CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Kr4lAWH-EeWNUe-5HV3A_g")]
public partial class AdditionalBusinessProcess5CodeDropdownSource : EnumMetadataManager<AdditionalBusinessProcess5Code,IAdditionalBusinessProcess5CodeDropdownRow,AdditionalBusinessProcess5CodeDropdownRow>
{
    public AdditionalBusinessProcess5CodeDropdownSource()
        : base( (enumValue, memberInfo) => new AdditionalBusinessProcess5CodeDropdownRow(enumValue, memberInfo))
    {
    }
}