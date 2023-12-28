﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for PartyType1Code.  ISO2002 ID# _ZyB4yNp-Ed-ak6NoX_4Aeg_83898339.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of party involved in the transaction.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IPartyType1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZyB4yNp-Ed-ak6NoX_4Aeg_83898339")]
public partial class PartyType1CodeDropdownSource : EnumMetadataManager<PartyType1Code,IPartyType1CodeDropdownRow,PartyType1CodeDropdownRow>
{
    public PartyType1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new PartyType1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}