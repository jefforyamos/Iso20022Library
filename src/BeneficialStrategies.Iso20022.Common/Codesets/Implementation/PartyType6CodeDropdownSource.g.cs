﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for PartyType6Code.  ISO2002 ID# _KTLwxX1DEeCF8NjrBemJWQ_-1689950566.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Entity assigning an identification of an entity involved in a maintenance operation.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IPartyType6CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_KTLwxX1DEeCF8NjrBemJWQ_-1689950566")]
public partial class PartyType6CodeDropdownSource : EnumMetadataManager<PartyType6Code,IPartyType6CodeDropdownRow,PartyType6CodeDropdownRow>
{
    public PartyType6CodeDropdownSource()
        : base( (enumValue, memberInfo) => new PartyType6CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
