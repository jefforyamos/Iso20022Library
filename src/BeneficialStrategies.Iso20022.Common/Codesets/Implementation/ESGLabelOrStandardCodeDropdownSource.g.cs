﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ESGLabelOrStandardCode.  ISO2002 ID# _XR6bsM2vEeuAE-cYsQdwHQ.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the ESG label or standard of a product.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IESGLabelOrStandardCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_XR6bsM2vEeuAE-cYsQdwHQ")]
public partial class ESGLabelOrStandardCodeDropdownSource : EnumMetadataManager<ESGLabelOrStandardCode,IESGLabelOrStandardCodeDropdownRow,ESGLabelOrStandardCodeDropdownRow>
{
    public ESGLabelOrStandardCodeDropdownSource()
        : base( (enumValue, memberInfo) => new ESGLabelOrStandardCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
