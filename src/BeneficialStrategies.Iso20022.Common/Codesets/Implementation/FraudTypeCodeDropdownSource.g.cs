﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for FraudTypeCode.  ISO2002 ID# _aFPakHa6Eeef9c2nwgY9Xw.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of confirmed fraud.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IFraudTypeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_aFPakHa6Eeef9c2nwgY9Xw")]
public partial class FraudTypeCodeDropdownSource : EnumMetadataManager<FraudTypeCode,IFraudTypeCodeDropdownRow,FraudTypeCodeDropdownRow>
{
    public FraudTypeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new FraudTypeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
