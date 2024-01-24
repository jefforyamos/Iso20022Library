﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ClearingObligationType1Code.  ISO2002 ID# _sCzjYA29EeWmAKKPnqYEVQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies whether the reported contract belongs to a class of OTC derivatives that has been declared subject to the clearing obligation and both counterparties to the contract are subject to the clearing obligation under Regulation (EU) No 648/2012, as of the time of execution of the contract.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_sCzjYA29EeWmAKKPnqYEVQ")]
[Description(@"Specifies whether the reported contract belongs to a class of OTC derivatives that has been declared subject to the clearing obligation and both counterparties to the contract are subject to the clearing obligation under Regulation (EU) No 648/2012, as of the time of execution of the contract.")]
[DerivedFrom(typeof(ClearingObligationTypeCode))]
public enum ClearingObligationType1Code
{
    /// <summary>
    /// Reported contract does not belong to a class of OTC derivatives that has been declared subject to the clearing obligation.
    /// Encoded/decoded by serializers as "FLSE".
    /// </summary>
    [EnumMember(Value = "FLSE")]
    [IsoId("_wq36sQ29EeWmAKKPnqYEVQ")]
    [Description(@"Reported contract does not belong to a class of OTC derivatives that has been declared subject to the clearing obligation.")]
    No = ClearingObligationTypeCode.No, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unknown whether reported contract belongs to a class of OTC derivatives that has been declared subject to the clearing obligation.
    /// Encoded/decoded by serializers as "UKWN".
    /// </summary>
    [EnumMember(Value = "UKWN")]
    [IsoId("_wwOUwQ29EeWmAKKPnqYEVQ")]
    [Description(@"Unknown whether reported contract belongs to a class of OTC derivatives that has been declared subject to the clearing obligation.")]
    Unknown = ClearingObligationTypeCode.Unknown, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Reported contract belongs to a class of OTC derivatives that has been declared subject to the clearing obligation.
    /// Encoded/decoded by serializers as "TRUE".
    /// </summary>
    [EnumMember(Value = "TRUE")]
    [IsoId("_w0r-AQ29EeWmAKKPnqYEVQ")]
    [Description(@"Reported contract belongs to a class of OTC derivatives that has been declared subject to the clearing obligation.")]
    Yes = ClearingObligationTypeCode.Yes, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ClearingObligationType1CodeMetadataExtensions
{
    private static readonly ClearingObligationType1CodeDropdownSource _dropdownSource = new ClearingObligationType1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IClearingObligationType1CodeDropdownRow GetMetadata(this ClearingObligationType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


