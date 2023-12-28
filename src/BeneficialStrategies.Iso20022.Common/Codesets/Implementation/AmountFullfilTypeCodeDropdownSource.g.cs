﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for AmountFullfilTypeCode.  ISO2002 ID# _bo8XEdp-Ed-ak6NoX_4Aeg_-793137810.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies if the redemption is partly or fully.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IAmountFullfilTypeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_bo8XEdp-Ed-ak6NoX_4Aeg_-793137810")]
public partial class AmountFullfilTypeCodeDropdownSource : EnumMetadataManager<AmountFullfilTypeCode,IAmountFullfilTypeCodeDropdownRow,AmountFullfilTypeCodeDropdownRow>
{
    public AmountFullfilTypeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new AmountFullfilTypeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}