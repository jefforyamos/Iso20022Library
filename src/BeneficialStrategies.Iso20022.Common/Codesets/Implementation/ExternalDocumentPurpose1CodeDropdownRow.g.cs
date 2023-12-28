﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ExternalDocumentPurpose1Code.  ISO2002 ID# _TRd1lAEcEeCQm6a_G2yO_w_37780651.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the document purpose as published in an external document purpose code list.
/// External code sets can be downloaded from www.iso20022.org.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ExternalDocumentPurpose1CodeDropdownSource"/>.
/// Implements <seealso cref="IExternalDocumentPurpose1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_TRd1lAEcEeCQm6a_G2yO_w_37780651")]
public partial class ExternalDocumentPurpose1CodeDropdownRow : EnumMetadataItem<ExternalDocumentPurpose1Code>, IExternalDocumentPurpose1CodeDropdownRow
{
    /// <summary>
    /// Specifies the document purpose as published in an external document purpose code list.
    /// External code sets can be downloaded from www.iso20022.org.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ExternalDocumentPurpose1CodeDropdownRow(ExternalDocumentPurpose1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}