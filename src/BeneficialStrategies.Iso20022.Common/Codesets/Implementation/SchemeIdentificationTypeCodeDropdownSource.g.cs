﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for SchemeIdentificationTypeCode.  ISO2002 ID# _JJT9wLh0Eea3PLWeF1tJsQ.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Domain of an identifier.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ISchemeIdentificationTypeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_JJT9wLh0Eea3PLWeF1tJsQ")]
public partial class SchemeIdentificationTypeCodeDropdownSource : EnumMetadataManager<SchemeIdentificationTypeCode,ISchemeIdentificationTypeCodeDropdownRow,SchemeIdentificationTypeCodeDropdownRow>
{
    public SchemeIdentificationTypeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new SchemeIdentificationTypeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
