﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for Referred1Code.  ISO2002 ID# _ZaosdNp-Ed-ak6NoX_4Aeg_-241687818.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates if the investor was referred.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IReferred1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZaosdNp-Ed-ak6NoX_4Aeg_-241687818")]
public partial class Referred1CodeDropdownSource : EnumMetadataManager<Referred1Code,IReferred1CodeDropdownRow,Referred1CodeDropdownRow>
{
    public Referred1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new Referred1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
