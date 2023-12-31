﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for JourneyType1Code.  ISO2002 ID# _6bmakF1jEeeu75xdwwAXQw.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of journey related to a car rental reservation.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IJourneyType1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_6bmakF1jEeeu75xdwwAXQw")]
public partial class JourneyType1CodeDropdownSource : EnumMetadataManager<JourneyType1Code,IJourneyType1CodeDropdownRow,JourneyType1CodeDropdownRow>
{
    public JourneyType1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new JourneyType1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
