﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for Verification3Code.  ISO2002 ID# _soVKwCYDEeym0KcvJF9aDQ.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Result of a verification.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IVerification3CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_soVKwCYDEeym0KcvJF9aDQ")]
public partial class Verification3CodeDropdownSource : EnumMetadataManager<Verification3Code,IVerification3CodeDropdownRow,Verification3CodeDropdownRow>
{
    public Verification3CodeDropdownSource()
        : base( (enumValue, memberInfo) => new Verification3CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
