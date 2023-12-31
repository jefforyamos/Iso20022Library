﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for JourneyTypeCode.  ISO2002 ID# _LnTHAF1jEeeu75xdwwAXQw.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Journey type data in a car rental service.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IJourneyTypeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_LnTHAF1jEeeu75xdwwAXQw")]
public partial class JourneyTypeCodeDropdownSource : EnumMetadataManager<JourneyTypeCode,IJourneyTypeCodeDropdownRow,JourneyTypeCodeDropdownRow>
{
    public JourneyTypeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new JourneyTypeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
