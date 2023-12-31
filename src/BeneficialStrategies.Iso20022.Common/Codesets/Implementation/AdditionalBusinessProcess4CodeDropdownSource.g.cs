﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for AdditionalBusinessProcess4Code.  ISO2002 ID# _V_8rgQFpEeGXDp73SgCmsg.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the additional business process linked to a corporate action event.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IAdditionalBusinessProcess4CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_V_8rgQFpEeGXDp73SgCmsg")]
public partial class AdditionalBusinessProcess4CodeDropdownSource : EnumMetadataManager<AdditionalBusinessProcess4Code,IAdditionalBusinessProcess4CodeDropdownRow,AdditionalBusinessProcess4CodeDropdownRow>
{
    public AdditionalBusinessProcess4CodeDropdownSource()
        : base( (enumValue, memberInfo) => new AdditionalBusinessProcess4CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
