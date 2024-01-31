﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for Holding1Code.  ISO2002 ID# _AFmrABKgEeKj15WxqwlXPw.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies how the holding is blocked.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IHolding1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_AFmrABKgEeKj15WxqwlXPw")]
public partial class Holding1CodeDropdownSource : EnumMetadataManager<Holding1Code,IHolding1CodeDropdownRow,Holding1CodeDropdownRow>
{
    public Holding1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new Holding1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
