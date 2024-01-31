﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for NonEquityAssetClass1Code.  ISO2002 ID# _kJOfgIMfEeqqSpeC5JM2Mw.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the asset class of a non-equity financial instrument.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="INonEquityAssetClass1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_kJOfgIMfEeqqSpeC5JM2Mw")]
public partial class NonEquityAssetClass1CodeDropdownSource : EnumMetadataManager<NonEquityAssetClass1Code,INonEquityAssetClass1CodeDropdownRow,NonEquityAssetClass1CodeDropdownRow>
{
    public NonEquityAssetClass1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new NonEquityAssetClass1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
