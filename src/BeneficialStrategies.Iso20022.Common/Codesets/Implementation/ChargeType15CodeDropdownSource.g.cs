﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ChargeType15Code.  ISO2002 ID# _WOC0odp-Ed-ak6NoX_4Aeg_-70268021.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of service for which a charge is asked or paid.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IChargeType15CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_WOC0odp-Ed-ak6NoX_4Aeg_-70268021")]
public partial class ChargeType15CodeDropdownSource : EnumMetadataManager<ChargeType15Code,IChargeType15CodeDropdownRow,ChargeType15CodeDropdownRow>
{
    public ChargeType15CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ChargeType15CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
