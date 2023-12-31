﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ChargeType6Code.  ISO2002 ID# _VlqmANp-Ed-ak6NoX_4Aeg_1005907551.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of service for which a charge is asked or paid.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IChargeType6CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_VlqmANp-Ed-ak6NoX_4Aeg_1005907551")]
public partial class ChargeType6CodeDropdownSource : EnumMetadataManager<ChargeType6Code,IChargeType6CodeDropdownRow,ChargeType6CodeDropdownRow>
{
    public ChargeType6CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ChargeType6CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
