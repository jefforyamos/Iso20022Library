﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for CustodianRecordCompletenessTypeCode.  ISO2002 ID# _11fptTL3EeKU9IrkkToqcw_1241268024.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the state of details of the composite record on the system. Applicable to custodian service only.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="CustodianRecordCompletenessTypeCodeDropdownSource"/>.
/// Implements <seealso cref="ICustodianRecordCompletenessTypeCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_11fptTL3EeKU9IrkkToqcw_1241268024")]
public partial class CustodianRecordCompletenessTypeCodeDropdownRow : EnumMetadataItem<CustodianRecordCompletenessTypeCode>, ICustodianRecordCompletenessTypeCodeDropdownRow
{
    /// <summary>
    /// Specifies the state of details of the composite record on the system. Applicable to custodian service only.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public CustodianRecordCompletenessTypeCodeDropdownRow(CustodianRecordCompletenessTypeCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
