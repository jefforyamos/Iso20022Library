﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for Identification3Code.  ISO2002 ID# _leEoQad3EeuEcqP2FGAFaA.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Identification of an individual.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IIdentification3CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_leEoQad3EeuEcqP2FGAFaA")]
public partial class Identification3CodeDropdownSource : EnumMetadataManager<Identification3Code,IIdentification3CodeDropdownRow,Identification3CodeDropdownRow>
{
    public Identification3CodeDropdownSource()
        : base( (enumValue, memberInfo) => new Identification3CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
