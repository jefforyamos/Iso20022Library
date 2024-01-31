﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for EmissionAllowanceProductType2Code.  ISO2002 ID# _e3GDEGlHEeaLAKoEUNsD9g.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies an mission allowance type.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IEmissionAllowanceProductType2CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_e3GDEGlHEeaLAKoEUNsD9g")]
public partial class EmissionAllowanceProductType2CodeDropdownSource : EnumMetadataManager<EmissionAllowanceProductType2Code,IEmissionAllowanceProductType2CodeDropdownRow,EmissionAllowanceProductType2CodeDropdownRow>
{
    public EmissionAllowanceProductType2CodeDropdownSource()
        : base( (enumValue, memberInfo) => new EmissionAllowanceProductType2CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
