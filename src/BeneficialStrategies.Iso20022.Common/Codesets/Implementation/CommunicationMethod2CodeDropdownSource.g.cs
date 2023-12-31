﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for CommunicationMethod2Code.  ISO2002 ID# _gcdCsA1fEeKGXqvMN6jpiw.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Communication method used for the transmission of documents.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ICommunicationMethod2CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_gcdCsA1fEeKGXqvMN6jpiw")]
public partial class CommunicationMethod2CodeDropdownSource : EnumMetadataManager<CommunicationMethod2Code,ICommunicationMethod2CodeDropdownRow,CommunicationMethod2CodeDropdownRow>
{
    public CommunicationMethod2CodeDropdownSource()
        : base( (enumValue, memberInfo) => new CommunicationMethod2CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
