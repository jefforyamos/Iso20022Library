﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for Identification2Code.  ISO2002 ID# _MJNFcAwTEeiHgJ0O2VQ-kg.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Identification of an individual.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IIdentification2CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_MJNFcAwTEeiHgJ0O2VQ-kg")]
public partial class Identification2CodeDropdownSource : EnumMetadataManager<Identification2Code,IIdentification2CodeDropdownRow,Identification2CodeDropdownRow>
{
    public Identification2CodeDropdownSource()
        : base( (enumValue, memberInfo) => new Identification2CodeDropdownRow(enumValue, memberInfo))
    {
    }
}