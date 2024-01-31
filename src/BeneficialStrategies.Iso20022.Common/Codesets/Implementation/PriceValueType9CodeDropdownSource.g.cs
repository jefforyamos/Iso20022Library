﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for PriceValueType9Code.  ISO2002 ID# _qd8KkeEPEd-1Ktb5rVaajw.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a type of price value.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IPriceValueType9CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_qd8KkeEPEd-1Ktb5rVaajw")]
public partial class PriceValueType9CodeDropdownSource : EnumMetadataManager<PriceValueType9Code,IPriceValueType9CodeDropdownRow,PriceValueType9CodeDropdownRow>
{
    public PriceValueType9CodeDropdownSource()
        : base( (enumValue, memberInfo) => new PriceValueType9CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
