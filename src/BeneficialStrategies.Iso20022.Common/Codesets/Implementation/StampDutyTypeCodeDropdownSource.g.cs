﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for StampDutyTypeCode.  ISO2002 ID# _ZPdXN9p-Ed-ak6NoX_4Aeg_930727871.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies if the stamp duty is applicable.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IStampDutyTypeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZPdXN9p-Ed-ak6NoX_4Aeg_930727871")]
public partial class StampDutyTypeCodeDropdownSource : EnumMetadataManager<StampDutyTypeCode,IStampDutyTypeCodeDropdownRow,StampDutyTypeCodeDropdownRow>
{
    public StampDutyTypeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new StampDutyTypeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}