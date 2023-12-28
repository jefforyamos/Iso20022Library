﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for CustodianRecordCompletenessTypeCode.  ISO2002 ID# _11fptTL3EeKU9IrkkToqcw_1241268024.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the state of details of the composite record on the system. Applicable to custodian service only.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ICustodianRecordCompletenessTypeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_11fptTL3EeKU9IrkkToqcw_1241268024")]
public partial class CustodianRecordCompletenessTypeCodeDropdownSource : EnumMetadataManager<CustodianRecordCompletenessTypeCode,ICustodianRecordCompletenessTypeCodeDropdownRow,CustodianRecordCompletenessTypeCodeDropdownRow>
{
    public CustodianRecordCompletenessTypeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new CustodianRecordCompletenessTypeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}