﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for PresentationPartyCode.  ISO2002 ID# _v7BzIHycEeGWJuGCfvwOsQ.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the party to receive the presentation.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IPresentationPartyCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_v7BzIHycEeGWJuGCfvwOsQ")]
public partial class PresentationPartyCodeDropdownSource : EnumMetadataManager<PresentationPartyCode,IPresentationPartyCodeDropdownRow,PresentationPartyCodeDropdownRow>
{
    public PresentationPartyCodeDropdownSource()
        : base( (enumValue, memberInfo) => new PresentationPartyCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
