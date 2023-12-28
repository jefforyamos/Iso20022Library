﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ExternalDocumentPurposeCode.  ISO2002 ID# _Aeu_oJGDEeeBGrZP1w0opg.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the document purpose as published in an external document purpose code list.
/// External code sets can be downloaded from www.iso20022.org.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ExternalDocumentPurposeCodeDropdownSource"/>.
/// Implements <seealso cref="IExternalDocumentPurposeCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Aeu_oJGDEeeBGrZP1w0opg")]
public partial class ExternalDocumentPurposeCodeDropdownRow : EnumMetadataItem<ExternalDocumentPurposeCode>, IExternalDocumentPurposeCodeDropdownRow
{
    /// <summary>
    /// Specifies the document purpose as published in an external document purpose code list.
    /// External code sets can be downloaded from www.iso20022.org.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ExternalDocumentPurposeCodeDropdownRow(ExternalDocumentPurposeCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}