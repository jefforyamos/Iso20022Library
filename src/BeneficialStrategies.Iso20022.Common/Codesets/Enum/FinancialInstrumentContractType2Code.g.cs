﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for FinancialInstrumentContractType2Code.  ISO2002 ID# _3gF7gJHrEeabEPkKgPJPcA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the contract type of a derivative.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_3gF7gJHrEeabEPkKgPJPcA")]
[Description(@"Specifies the contract type of a derivative.")]
[DerivedFrom(typeof(FinancialInstrumentContractTypeCode))]
public enum FinancialInstrumentContractType2Code
{
    /// <summary>
    /// Contract of type contracts for difference.
    /// Encoded/decoded by serializers as "ContractForDifference".
    /// </summary>
    [EnumMember(Value = "CFDS")]
    [IsoId("_6FDLkZHrEeabEPkKgPJPcA")]
    [Description(@"Contract of type contracts for difference.")]
    ContractForDifference,
    
    /// <summary>
    /// Contract of type forward rate agreement.
    /// Encoded/decoded by serializers as "ForwardRateAgreement".
    /// </summary>
    [EnumMember(Value = "FRAS")]
    [IsoId("_6mlLUZHrEeabEPkKgPJPcA")]
    [Description(@"Contract of type forward rate agreement.")]
    ForwardRateAgreement,
    
    /// <summary>
    /// Contract of type future.
    /// Encoded/decoded by serializers as "Futures".
    /// </summary>
    [EnumMember(Value = "FUTR")]
    [IsoId("_7jFP0ZHrEeabEPkKgPJPcA")]
    [Description(@"Contract of type future.")]
    Futures,
    
    /// <summary>
    /// Contract of type forward.
    /// 
    /// 
    /// Encoded/decoded by serializers as "Forward".
    /// </summary>
    [EnumMember(Value = "FORW")]
    [IsoId("_8OmSAZHrEeabEPkKgPJPcA")]
    [Description(@"Contract of type forward.  ")]
    Forward,
    
    /// <summary>
    /// Contract of type option.
    /// 
    /// Encoded/decoded by serializers as "Option".
    /// </summary>
    [EnumMember(Value = "OPTN")]
    [IsoId("_8o0v4ZHrEeabEPkKgPJPcA")]
    [Description(@"Contract of type option. ")]
    Option,
    
    /// <summary>
    /// Contract of type spread betting.
    /// 
    /// Encoded/decoded by serializers as "SpreadBetting".
    /// </summary>
    [EnumMember(Value = "SPDB")]
    [IsoId("_9HN8EZHrEeabEPkKgPJPcA")]
    [Description(@"Contract of type spread betting. ")]
    SpreadBetting,
    
    /// <summary>
    /// Contract of type swap.
    /// 
    /// Encoded/decoded by serializers as "Swap".
    /// </summary>
    [EnumMember(Value = "SWAP")]
    [IsoId("_9yJIYZHrEeabEPkKgPJPcA")]
    [Description(@"Contract of type swap. ")]
    Swap,
    
    /// <summary>
    /// Contract of type swaption.
    /// 
    /// Encoded/decoded by serializers as "Swaption".
    /// </summary>
    [EnumMember(Value = "SWPT")]
    [IsoId("_-I73wZHrEeabEPkKgPJPcA")]
    [Description(@"Contract of type swaption. ")]
    Swaption,
    
    /// <summary>
    /// Contract of other financial instrument contract type.
    /// Encoded/decoded by serializers as "Other".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_-oFR4ZHrEeabEPkKgPJPcA")]
    [Description(@"Contract of other financial instrument contract type.")]
    Other,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class FinancialInstrumentContractType2CodeMetadataExtensions
{
    private static readonly FinancialInstrumentContractType2CodeDropdownSource _dropdownSource = new FinancialInstrumentContractType2CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IFinancialInstrumentContractType2CodeDropdownRow GetMetadata(this FinancialInstrumentContractType2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


