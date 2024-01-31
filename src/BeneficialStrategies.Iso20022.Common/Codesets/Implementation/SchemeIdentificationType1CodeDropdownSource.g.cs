﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for SchemeIdentificationType1Code.  ISO2002 ID# _GvWnULh1Eea3PLWeF1tJsQ.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Domain of an identifier.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ISchemeIdentificationType1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_GvWnULh1Eea3PLWeF1tJsQ")]
public partial class SchemeIdentificationType1CodeDropdownSource : EnumMetadataManager<SchemeIdentificationType1Code,ISchemeIdentificationType1CodeDropdownRow,SchemeIdentificationType1CodeDropdownRow>
{
    public SchemeIdentificationType1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new SchemeIdentificationType1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
