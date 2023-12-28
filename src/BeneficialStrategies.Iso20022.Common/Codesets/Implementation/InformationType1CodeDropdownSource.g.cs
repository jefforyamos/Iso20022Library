﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for InformationType1Code.  ISO2002 ID# _aWiUCNp-Ed-ak6NoX_4Aeg_1720047653.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the coded type of additional information provided.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IInformationType1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_aWiUCNp-Ed-ak6NoX_4Aeg_1720047653")]
public partial class InformationType1CodeDropdownSource : EnumMetadataManager<InformationType1Code,IInformationType1CodeDropdownRow,InformationType1CodeDropdownRow>
{
    public InformationType1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new InformationType1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}