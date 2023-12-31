﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for PartyType12Code.  ISO2002 ID# _oci7cIn0EeS9F4Qrq_eaVA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of identified entity.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_oci7cIn0EeS9F4Qrq_eaVA")]
[Description(@"Type of identified entity.")]
[DerivedFrom(typeof(PartyTypeCode))]
public enum PartyType12Code
{
    /// <summary>
    /// Entity acquiring card transactions.
    /// Encoded/decoded by serializers as "Acquirer".
    /// </summary>
    [EnumMember(Value = "ACQR")]
    [IsoId("_rAuvcYn0EeS9F4Qrq_eaVA")]
    [Description(@"Entity acquiring card transactions.")]
    Acquirer,
    
    /// <summary>
    /// Entity managing the ATM.
    /// Encoded/decoded by serializers as "ATMManager".
    /// </summary>
    [EnumMember(Value = "ATMG")]
    [IsoId("_rM8mg4n0EeS9F4Qrq_eaVA")]
    [Description(@"Entity managing the ATM.")]
    ATMManager,
    
    /// <summary>
    /// Entity providing issuing card payment processing services on behalf on an issuer.
    /// Encoded/decoded by serializers as "CardIssuerProcessor".
    /// </summary>
    [EnumMember(Value = "CISP")]
    [IsoId("_r0egk4n0EeS9F4Qrq_eaVA")]
    [Description(@"Entity providing issuing card payment processing services on behalf on an issuer.")]
    CardIssuerProcessor,
    
    /// <summary>
    /// Party to whom the card issuer delegates to authorise card payment transactions.
    /// Encoded/decoded by serializers as "DelegateIssuer".
    /// </summary>
    [EnumMember(Value = "DLIS")]
    [IsoId("_sAb484n0EeS9F4Qrq_eaVA")]
    [Description(@"Party to whom the card issuer delegates to authorise card payment transactions.")]
    DelegateIssuer,
    
    /// <summary>
    /// Entity hosting the ATM.
    /// Encoded/decoded by serializers as "HostingEntity".
    /// </summary>
    [EnumMember(Value = "HSTG")]
    [IsoId("_s-0Mw4n0EeS9F4Qrq_eaVA")]
    [Description(@"Entity hosting the ATM.")]
    HostingEntity,
    
    /// <summary>
    /// Party acting on behalf of other parties to process or forward data to other parties.
    /// Encoded/decoded by serializers as "IntermediaryAgent".
    /// </summary>
    [EnumMember(Value = "ITAG")]
    [IsoId("_tIgUQ4n0EeS9F4Qrq_eaVA")]
    [Description(@"Party acting on behalf of other parties to process or forward data to other parties.")]
    IntermediaryAgent,
    
    /// <summary>
    /// ATM initiating the transaction.
    /// Encoded/decoded by serializers as "OriginatingATM".
    /// </summary>
    [EnumMember(Value = "OATM")]
    [IsoId("_t-Q3k4n0EeS9F4Qrq_eaVA")]
    [Description(@"ATM initiating the transaction.")]
    OriginatingATM,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class PartyType12CodeMetadataExtensions
{
    private static readonly PartyType12CodeDropdownSource _dropdownSource = new PartyType12CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IPartyType12CodeDropdownRow GetMetadata(this PartyType12Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


