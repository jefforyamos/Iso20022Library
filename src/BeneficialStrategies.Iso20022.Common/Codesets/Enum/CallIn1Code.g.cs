﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CallIn1Code.  ISO2002 ID# _bXNt6Np-Ed-ak6NoX_4Aeg_-324730819.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of pay-in call report.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bXNt6Np-Ed-ak6NoX_4Aeg_-324730819")]
[Description(@"Specifies the type of pay-in call report.")]
[DerivedFrom(typeof(CallInCode))]
public enum CallIn1Code
{
    /// <summary>
    /// Pay-in call is for account value.
    /// Encoded/decoded by serializers as "CFAV".
    /// </summary>
    [EnumMember(Value = "CFAV")]
    [IsoId("_bXNt6dp-Ed-ak6NoX_4Aeg_556310168")]
    [Description(@"Pay-in call is for account value.")]
    CallForAccountValue = CallInCode.CallForAccountValue, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Pay-in call is for settlement.
    /// Encoded/decoded by serializers as "CFST".
    /// </summary>
    [EnumMember(Value = "CFST")]
    [IsoId("_bXW30Np-Ed-ak6NoX_4Aeg_600636833")]
    [Description(@"Pay-in call is for settlement.")]
    CallForSettlement = CallInCode.CallForSettlement, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Pay-in call is for currency close.
    /// Encoded/decoded by serializers as "CFCC".
    /// </summary>
    [EnumMember(Value = "CFCC")]
    [IsoId("_bXW30dp-Ed-ak6NoX_4Aeg_628342105")]
    [Description(@"Pay-in call is for currency close.")]
    CallForCurrencyClose = CallInCode.CallForCurrencyClose, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CallIn1CodeMetadataExtensions
{
    private static readonly CallIn1CodeDropdownSource _dropdownSource = new CallIn1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICallIn1CodeDropdownRow GetMetadata(this CallIn1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


