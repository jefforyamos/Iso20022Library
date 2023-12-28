﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for DocumentTypeCode.  ISO2002 ID# _aghWddp-Ed-ak6NoX_4Aeg_-1963478091.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies a type of financial or commercial document.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="DocumentTypeCodeDropdownSource"/>.
/// Implements <seealso cref="IDocumentTypeCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_aghWddp-Ed-ak6NoX_4Aeg_-1963478091")]
public partial class DocumentTypeCodeDropdownRow : EnumMetadataItem<DocumentTypeCode>, IDocumentTypeCodeDropdownRow
{
    /// <summary>
    /// Specifies a type of financial or commercial document.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public DocumentTypeCodeDropdownRow(DocumentTypeCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}