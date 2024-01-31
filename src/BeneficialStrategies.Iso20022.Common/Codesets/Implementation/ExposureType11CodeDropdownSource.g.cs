﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ExposureType11Code.  ISO2002 ID# _pPoQtiW2EeyT3chuyX0PgA.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the underlying business area/type of trade causing the collateral movement.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IExposureType11CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_pPoQtiW2EeyT3chuyX0PgA")]
public partial class ExposureType11CodeDropdownSource : EnumMetadataManager<ExposureType11Code,IExposureType11CodeDropdownRow,ExposureType11CodeDropdownRow>
{
    public ExposureType11CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ExposureType11CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
