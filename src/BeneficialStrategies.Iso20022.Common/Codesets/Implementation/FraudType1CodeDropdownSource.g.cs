﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for FraudType1Code.  ISO2002 ID# _4htAMHa-Eeef9c2nwgY9Xw.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Identifies the type of fraud in a card payment environment.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IFraudType1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_4htAMHa-Eeef9c2nwgY9Xw")]
public partial class FraudType1CodeDropdownSource : EnumMetadataManager<FraudType1Code,IFraudType1CodeDropdownRow,FraudType1CodeDropdownRow>
{
    public FraudType1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new FraudType1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
