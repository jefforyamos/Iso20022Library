﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ConductClassification1Code.  ISO2002 ID# _nP6msBjoEeKxeog5DTmtgg.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the classification of the conduct.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IConductClassification1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_nP6msBjoEeKxeog5DTmtgg")]
public partial class ConductClassification1CodeDropdownSource : EnumMetadataManager<ConductClassification1Code,IConductClassification1CodeDropdownRow,ConductClassification1CodeDropdownRow>
{
    public ConductClassification1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ConductClassification1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
