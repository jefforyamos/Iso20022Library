﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for OriginatorRoleCode.  ISO2002 ID# _Zw_W9tp-Ed-ak6NoX_4Aeg_141531855.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies in what capacity (role) the originator of a quote is acting.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IOriginatorRoleCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Zw_W9tp-Ed-ak6NoX_4Aeg_141531855")]
public partial class OriginatorRoleCodeDropdownSource : EnumMetadataManager<OriginatorRoleCode,IOriginatorRoleCodeDropdownRow,OriginatorRoleCodeDropdownRow>
{
    public OriginatorRoleCodeDropdownSource()
        : base( (enumValue, memberInfo) => new OriginatorRoleCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
