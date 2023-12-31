﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ESGLabelOrStandard1Code.  ISO2002 ID# _eSB0MNA7EeuSBa1PsnseFg.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the ESG label or standard of a product.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IESGLabelOrStandard1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_eSB0MNA7EeuSBa1PsnseFg")]
public partial class ESGLabelOrStandard1CodeDropdownSource : EnumMetadataManager<ESGLabelOrStandard1Code,IESGLabelOrStandard1CodeDropdownRow,ESGLabelOrStandard1CodeDropdownRow>
{
    public ESGLabelOrStandard1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ESGLabelOrStandard1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
