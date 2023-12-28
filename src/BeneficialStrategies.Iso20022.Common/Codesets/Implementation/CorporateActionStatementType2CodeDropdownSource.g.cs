﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for CorporateActionStatementType2Code.  ISO2002 ID# _0mALAbtEEeilsanBGAzy4A.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates whether the statement contains missing instructions only or all instructions.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ICorporateActionStatementType2CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_0mALAbtEEeilsanBGAzy4A")]
public partial class CorporateActionStatementType2CodeDropdownSource : EnumMetadataManager<CorporateActionStatementType2Code,ICorporateActionStatementType2CodeDropdownRow,CorporateActionStatementType2CodeDropdownRow>
{
    public CorporateActionStatementType2CodeDropdownSource()
        : base( (enumValue, memberInfo) => new CorporateActionStatementType2CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
