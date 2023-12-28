﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for CustodianActionCode.  ISO2002 ID# _14eFMTL3EeKU9IrkkToqcw_2034050184.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies custodian activity codes.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ICustodianActionCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_14eFMTL3EeKU9IrkkToqcw_2034050184")]
public partial class CustodianActionCodeDropdownSource : EnumMetadataManager<CustodianActionCode,ICustodianActionCodeDropdownRow,CustodianActionCodeDropdownRow>
{
    public CustodianActionCodeDropdownSource()
        : base( (enumValue, memberInfo) => new CustodianActionCodeDropdownRow(enumValue, memberInfo))
    {
    }
}