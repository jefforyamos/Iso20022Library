﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for PartyNatureType1Code.  ISO2002 ID# _eGrH8B3dEeWTa7N6lo4ufA.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the nature of a counterparty.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IPartyNatureType1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_eGrH8B3dEeWTa7N6lo4ufA")]
public partial class PartyNatureType1CodeDropdownSource : EnumMetadataManager<PartyNatureType1Code,IPartyNatureType1CodeDropdownRow,PartyNatureType1CodeDropdownRow>
{
    public PartyNatureType1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new PartyNatureType1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
