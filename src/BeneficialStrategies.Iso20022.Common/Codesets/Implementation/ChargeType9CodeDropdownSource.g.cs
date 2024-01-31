﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ChargeType9Code.  ISO2002 ID# _a9b7-dp-Ed-ak6NoX_4Aeg_-1157330660.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of service for which a charge is asked or paid.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IChargeType9CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_a9b7-dp-Ed-ak6NoX_4Aeg_-1157330660")]
public partial class ChargeType9CodeDropdownSource : EnumMetadataManager<ChargeType9Code,IChargeType9CodeDropdownRow,ChargeType9CodeDropdownRow>
{
    public ChargeType9CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ChargeType9CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
