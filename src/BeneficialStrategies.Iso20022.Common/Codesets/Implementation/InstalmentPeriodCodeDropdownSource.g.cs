﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for InstalmentPeriodCode.  ISO2002 ID# _ji4689uTEei2qvU6FBLZYA.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Instalment period.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IInstalmentPeriodCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ji4689uTEei2qvU6FBLZYA")]
public partial class InstalmentPeriodCodeDropdownSource : EnumMetadataManager<InstalmentPeriodCode,IInstalmentPeriodCodeDropdownRow,InstalmentPeriodCodeDropdownRow>
{
    public InstalmentPeriodCodeDropdownSource()
        : base( (enumValue, memberInfo) => new InstalmentPeriodCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
