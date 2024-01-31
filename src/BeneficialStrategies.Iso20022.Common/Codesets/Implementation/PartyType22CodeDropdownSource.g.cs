﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for PartyType22Code.  ISO2002 ID# _KWN-kE9KEeeg87n1YQSQ_A.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Recipient of the additional information.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IPartyType22CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_KWN-kE9KEeeg87n1YQSQ_A")]
public partial class PartyType22CodeDropdownSource : EnumMetadataManager<PartyType22Code,IPartyType22CodeDropdownRow,PartyType22CodeDropdownRow>
{
    public PartyType22CodeDropdownSource()
        : base( (enumValue, memberInfo) => new PartyType22CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
