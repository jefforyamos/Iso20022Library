﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for GracePeriodUnitType1Code.  ISO2002 ID# _tjpgUDEpEemzCpWiCwK4aQ.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Contains the details of the grace period applicable to the instalment.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IGracePeriodUnitType1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_tjpgUDEpEemzCpWiCwK4aQ")]
public partial class GracePeriodUnitType1CodeDropdownSource : EnumMetadataManager<GracePeriodUnitType1Code,IGracePeriodUnitType1CodeDropdownRow,GracePeriodUnitType1CodeDropdownRow>
{
    public GracePeriodUnitType1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new GracePeriodUnitType1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}