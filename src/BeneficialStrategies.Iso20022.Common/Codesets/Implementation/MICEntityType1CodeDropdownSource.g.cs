﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for MICEntityType1Code.  ISO2002 ID# _t5NoYC6mEeiLE6ldFr13hQ.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of entity which has been assigned a MIC code.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IMICEntityType1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_t5NoYC6mEeiLE6ldFr13hQ")]
public partial class MICEntityType1CodeDropdownSource : EnumMetadataManager<MICEntityType1Code,IMICEntityType1CodeDropdownRow,MICEntityType1CodeDropdownRow>
{
    public MICEntityType1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new MICEntityType1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
