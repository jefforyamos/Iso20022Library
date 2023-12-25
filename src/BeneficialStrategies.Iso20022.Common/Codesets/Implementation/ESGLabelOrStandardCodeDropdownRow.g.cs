﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ESGLabelOrStandardCode.  ISO2002 ID# _XR6bsM2vEeuAE-cYsQdwHQ.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the ESG label or standard of a product.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ESGLabelOrStandardCodeDropdownSource"/>.
/// Implements <seealso cref="IESGLabelOrStandardCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_XR6bsM2vEeuAE-cYsQdwHQ")]
public partial class ESGLabelOrStandardCodeDropdownRow : EnumMetadataItem<ESGLabelOrStandardCode>, IESGLabelOrStandardCodeDropdownRow
{
    /// <summary>
    /// Specifies the ESG label or standard of a product.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ESGLabelOrStandardCodeDropdownRow(ESGLabelOrStandardCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
