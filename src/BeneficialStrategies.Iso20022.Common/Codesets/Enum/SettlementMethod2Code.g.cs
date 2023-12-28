﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for SettlementMethod2Code.  ISO2002 ID# _ZMCPxtp-Ed-ak6NoX_4Aeg_-673388484.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the method used to settle the credit transfer instruction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZMCPxtp-Ed-ak6NoX_4Aeg_-673388484")]
[Description(@"Specifies the method used to settle the credit transfer instruction.")]
[DerivedFrom(typeof(SettlementMethodCode))]
public enum SettlementMethod2Code
{
    /// <summary>
    /// Settlement is done by the agent instructed to execute a payment instruction.
    /// Encoded/decoded by serializers as "InstructedAgent".
    /// </summary>
    [EnumMember(Value = "INDA")]
    [IsoId("_ZMCPx9p-Ed-ak6NoX_4Aeg_-673388466")]
    [Description(@"Settlement is done by the agent instructed to execute a payment instruction.")]
    InstructedAgent,
    
    /// <summary>
    /// Settlement is done by the agent instructing and forwarding the payment to the next party in the payment chain.
    /// Encoded/decoded by serializers as "InstructingAgent".
    /// </summary>
    [EnumMember(Value = "INGA")]
    [IsoId("_ZMCPyNp-Ed-ak6NoX_4Aeg_-673388449")]
    [Description(@"Settlement is done by the agent instructing and forwarding the payment to the next party in the payment chain.")]
    InstructingAgent,
    
    /// <summary>
    /// Settlement is done through a payment clearing system.
    /// Encoded/decoded by serializers as "ClearingSystem".
    /// </summary>
    [EnumMember(Value = "CLRG")]
    [IsoId("_ZMMAwNp-Ed-ak6NoX_4Aeg_-673388407")]
    [Description(@"Settlement is done through a payment clearing system.")]
    ClearingSystem,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class SettlementMethod2CodeMetadataExtensions
{
    private static readonly SettlementMethod2CodeDropdownSource _dropdownSource = new SettlementMethod2CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ISettlementMethod2CodeDropdownRow GetMetadata(this SettlementMethod2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


