﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for UnitOfMeasure4Code.  ISO2002 ID# _Y3ne9dp-Ed-ak6NoX_4Aeg_735997635.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identifies the unit of measure by means of a code. The code is taken from UN/ECE Recommendation 20.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IUnitOfMeasure4CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Y3ne9dp-Ed-ak6NoX_4Aeg_735997635")]
public partial class UnitOfMeasure4CodeDropdownSource : EnumMetadataManager<UnitOfMeasure4Code,IUnitOfMeasure4CodeDropdownRow,UnitOfMeasure4CodeDropdownRow>
{
    public UnitOfMeasure4CodeDropdownSource()
        : base( (enumValue, memberInfo) => new UnitOfMeasure4CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
