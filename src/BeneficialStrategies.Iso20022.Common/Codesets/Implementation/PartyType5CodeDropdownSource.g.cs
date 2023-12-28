﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for PartyType5Code.  ISO2002 ID# _KTB_x31DEeCF8NjrBemJWQ_1808425989.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Identification of the type of entity involved in a maintenance operation.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IPartyType5CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_KTB_x31DEeCF8NjrBemJWQ_1808425989")]
public partial class PartyType5CodeDropdownSource : EnumMetadataManager<PartyType5Code,IPartyType5CodeDropdownRow,PartyType5CodeDropdownRow>
{
    public PartyType5CodeDropdownSource()
        : base( (enumValue, memberInfo) => new PartyType5CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
