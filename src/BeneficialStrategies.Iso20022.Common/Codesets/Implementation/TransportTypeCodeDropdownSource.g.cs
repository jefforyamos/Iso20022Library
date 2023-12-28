﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for TransportTypeCode.  ISO2002 ID# _sf5qh_QDEeihCvvpsmGI2w.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Contains the transportation type code list
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ITransportTypeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_sf5qh_QDEeihCvvpsmGI2w")]
public partial class TransportTypeCodeDropdownSource : EnumMetadataManager<TransportTypeCode,ITransportTypeCodeDropdownRow,TransportTypeCodeDropdownRow>
{
    public TransportTypeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new TransportTypeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}