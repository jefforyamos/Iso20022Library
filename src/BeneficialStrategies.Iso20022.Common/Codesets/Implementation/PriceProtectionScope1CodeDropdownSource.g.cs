﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for PriceProtectionScope1Code.  ISO2002 ID# _aIreNtp-Ed-ak6NoX_4Aeg_-529859319.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Defines the type of price protection the customer requires on their order.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IPriceProtectionScope1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_aIreNtp-Ed-ak6NoX_4Aeg_-529859319")]
public partial class PriceProtectionScope1CodeDropdownSource : EnumMetadataManager<PriceProtectionScope1Code,IPriceProtectionScope1CodeDropdownRow,PriceProtectionScope1CodeDropdownRow>
{
    public PriceProtectionScope1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new PriceProtectionScope1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
