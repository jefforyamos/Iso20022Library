﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for UnitOfMeasure2Code.  ISO2002 ID# _Y2SCNtp-Ed-ak6NoX_4Aeg_-339035809.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Identifies the unit of measure by means of a code. The code is taken from UN/ECE Recommendation 20.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IUnitOfMeasure2CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Y2SCNtp-Ed-ak6NoX_4Aeg_-339035809")]
public partial class UnitOfMeasure2CodeDropdownSource : EnumMetadataManager<UnitOfMeasure2Code,IUnitOfMeasure2CodeDropdownRow,UnitOfMeasure2CodeDropdownRow>
{
    public UnitOfMeasure2CodeDropdownSource()
        : base( (enumValue, memberInfo) => new UnitOfMeasure2CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
