﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ExternalReversalReasonCode.  ISO2002 ID# _UBzAwLf9Eee9KIDjEHK7ZQ.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reversal reason, as published in an external reversal reason code list.
/// External code sets can be downloaded from www.iso20022.org.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IExternalReversalReasonCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_UBzAwLf9Eee9KIDjEHK7ZQ")]
public partial class ExternalReversalReasonCodeDropdownSource : EnumMetadataManager<ExternalReversalReasonCode,IExternalReversalReasonCodeDropdownRow,ExternalReversalReasonCodeDropdownRow>
{
    public ExternalReversalReasonCodeDropdownSource()
        : base( (enumValue, memberInfo) => new ExternalReversalReasonCodeDropdownRow(enumValue, memberInfo))
    {
    }
}