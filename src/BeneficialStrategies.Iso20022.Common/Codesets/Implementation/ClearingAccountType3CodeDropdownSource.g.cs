﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ClearingAccountType3Code.  ISO2002 ID# _8eUqAHX-Eee_qcLXasnA4g.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the clearing account type.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IClearingAccountType3CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_8eUqAHX-Eee_qcLXasnA4g")]
public partial class ClearingAccountType3CodeDropdownSource : EnumMetadataManager<ClearingAccountType3Code,IClearingAccountType3CodeDropdownRow,ClearingAccountType3CodeDropdownRow>
{
    public ClearingAccountType3CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ClearingAccountType3CodeDropdownRow(enumValue, memberInfo))
    {
    }
}