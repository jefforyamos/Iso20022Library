﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ChargeType8Code.  ISO2002 ID# _a9SK9Np-Ed-ak6NoX_4Aeg_-1551316006.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Identifies charges linked to the conveyance of goods.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IChargeType8CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_a9SK9Np-Ed-ak6NoX_4Aeg_-1551316006")]
public partial class ChargeType8CodeDropdownSource : EnumMetadataManager<ChargeType8Code,IChargeType8CodeDropdownRow,ChargeType8CodeDropdownRow>
{
    public ChargeType8CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ChargeType8CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
