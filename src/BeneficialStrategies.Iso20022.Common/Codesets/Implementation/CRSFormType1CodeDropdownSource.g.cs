﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for CRSFormType1Code.  ISO2002 ID# _TYFa4ENwEeaS-NnwLNvMPg.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of Common Reporting Standard (CRS) form.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ICRSFormType1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_TYFa4ENwEeaS-NnwLNvMPg")]
public partial class CRSFormType1CodeDropdownSource : EnumMetadataManager<CRSFormType1Code,ICRSFormType1CodeDropdownRow,CRSFormType1CodeDropdownRow>
{
    public CRSFormType1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new CRSFormType1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}