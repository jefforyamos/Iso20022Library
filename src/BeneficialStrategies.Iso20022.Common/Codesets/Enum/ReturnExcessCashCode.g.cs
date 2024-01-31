﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ReturnExcessCashCode.  ISO2002 ID# _F-c7MALdEeutW5-TpeYJhA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates if excess cash collateral in the currency is automatically returned as per the collateral provider’s Excess Cash Margin Instruction (colr.017).
/// </summary>
[DataContract]
[Serializable]
[IsoId("_F-c7MALdEeutW5-TpeYJhA")]
[Description(@"Indicates if excess cash collateral in the currency is automatically returned as per the collateral provider’s Excess Cash Margin Instruction (colr.017).|")]
[Derivations(typeof(ReturnExcessCash1Code))]
public enum ReturnExcessCashCode
{
    /// <summary>
    /// Excess cash in the currency is returned.
    /// Encoded/decoded by serializers as "RTND".
    /// </summary>
    [EnumMember(Value = "RTND")]
    [IsoId("_3vlnwALnEeutW5-TpeYJhA")]
    [Description(@"Excess cash in the currency is returned.")]
    AutomaticallyReturned,
    
    /// <summary>
    /// Automatic return of excess cash has not been requested for the currency. 
    /// Encoded/decoded by serializers as "RTDN".
    /// </summary>
    [EnumMember(Value = "RTDN")]
    [IsoId("_LhNYIALoEeutW5-TpeYJhA")]
    [Description(@"Automatic return of excess cash has not been requested for the currency. ")]
    NoAutomaticReturn,
    
    /// <summary>
    /// Automatic return of cash is temporarily suspended (for example due to a currency holiday).
    /// Encoded/decoded by serializers as "SSPD".
    /// </summary>
    [EnumMember(Value = "SSPD")]
    [IsoId("_b-cmoQLoEeutW5-TpeYJhA")]
    [Description(@"Automatic return of cash is temporarily suspended (for example due to a currency holiday).")]
    Suspended,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ReturnExcessCashCodeMetadataExtensions
{
    private static readonly ReturnExcessCashCodeDropdownSource _dropdownSource = new ReturnExcessCashCodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IReturnExcessCashCodeDropdownRow GetMetadata(this ReturnExcessCashCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


