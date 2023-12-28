﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for SettlingCapacityCode.  ISO2002 ID# _ZOkmYdp-Ed-ak6NoX_4Aeg_-1171911201.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the role of the party in the settlement of the transaction.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ISettlingCapacityCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZOkmYdp-Ed-ak6NoX_4Aeg_-1171911201")]
public partial class SettlingCapacityCodeDropdownSource : EnumMetadataManager<SettlingCapacityCode,ISettlingCapacityCodeDropdownRow,SettlingCapacityCodeDropdownRow>
{
    public SettlingCapacityCodeDropdownSource()
        : base( (enumValue, memberInfo) => new SettlingCapacityCodeDropdownRow(enumValue, memberInfo))
    {
    }
}