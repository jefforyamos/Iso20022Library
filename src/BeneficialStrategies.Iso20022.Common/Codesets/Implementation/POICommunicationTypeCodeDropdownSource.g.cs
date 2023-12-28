﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for POICommunicationTypeCode.  ISO2002 ID# _WVvGsAx1EeKa_56Jbsi1RQ.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Low level communication of the hardware or software component toward another component or an external entity.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IPOICommunicationTypeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_WVvGsAx1EeKa_56Jbsi1RQ")]
public partial class POICommunicationTypeCodeDropdownSource : EnumMetadataManager<POICommunicationTypeCode,IPOICommunicationTypeCodeDropdownRow,POICommunicationTypeCodeDropdownRow>
{
    public POICommunicationTypeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new POICommunicationTypeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}