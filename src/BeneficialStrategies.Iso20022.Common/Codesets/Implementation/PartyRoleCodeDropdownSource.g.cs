﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for PartyRoleCode.  ISO2002 ID# _ZxlM1tp-Ed-ak6NoX_4Aeg_492772100.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the role of the party in the transaction.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IPartyRoleCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZxlM1tp-Ed-ak6NoX_4Aeg_492772100")]
public partial class PartyRoleCodeDropdownSource : EnumMetadataManager<PartyRoleCode,IPartyRoleCodeDropdownRow,PartyRoleCodeDropdownRow>
{
    public PartyRoleCodeDropdownSource()
        : base( (enumValue, memberInfo) => new PartyRoleCodeDropdownRow(enumValue, memberInfo))
    {
    }
}