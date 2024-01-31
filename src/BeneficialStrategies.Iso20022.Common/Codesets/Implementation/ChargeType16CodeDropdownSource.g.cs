﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ChargeType16Code.  ISO2002 ID# _WOVvldp-Ed-ak6NoX_4Aeg_-479752789.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of service for which a charge is asked or paid.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IChargeType16CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_WOVvldp-Ed-ak6NoX_4Aeg_-479752789")]
public partial class ChargeType16CodeDropdownSource : EnumMetadataManager<ChargeType16Code,IChargeType16CodeDropdownRow,ChargeType16CodeDropdownRow>
{
    public ChargeType16CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ChargeType16CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
