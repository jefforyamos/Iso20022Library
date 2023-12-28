﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ChargeType12Code.  ISO2002 ID# _a8ruBtp-Ed-ak6NoX_4Aeg_-1448425004.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of service for which a charge is asked or paid.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IChargeType12CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_a8ruBtp-Ed-ak6NoX_4Aeg_-1448425004")]
public partial class ChargeType12CodeDropdownSource : EnumMetadataManager<ChargeType12Code,IChargeType12CodeDropdownRow,ChargeType12CodeDropdownRow>
{
    public ChargeType12CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ChargeType12CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
