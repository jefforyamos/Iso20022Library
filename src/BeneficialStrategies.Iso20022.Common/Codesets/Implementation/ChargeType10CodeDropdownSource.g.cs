﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ChargeType10Code.  ISO2002 ID# _a8YzFNp-Ed-ak6NoX_4Aeg_1180340724.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of service for which a charge is asked or paid.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IChargeType10CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_a8YzFNp-Ed-ak6NoX_4Aeg_1180340724")]
public partial class ChargeType10CodeDropdownSource : EnumMetadataManager<ChargeType10Code,IChargeType10CodeDropdownRow,ChargeType10CodeDropdownRow>
{
    public ChargeType10CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ChargeType10CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
