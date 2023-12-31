﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for VerificationEntity2Code.  ISO2002 ID# _b-gbQSbTEeyhZIgCcGlTyA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of verification entity.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_b-gbQSbTEeyhZIgCcGlTyA")]
[Description(@"Type of verification entity.")]
[DerivedFrom(typeof(VerificationEntityCode))]
public enum VerificationEntity2Code
{
    /// <summary>
    /// Acceptor (for example signature verification by the attendant).
    /// Encoded/decoded by serializers as "Acceptor".
    /// </summary>
    [EnumMember(Value = "MERC")]
    [IsoId("_cFaUgSbTEeyhZIgCcGlTyA")]
    [Description(@"Acceptor (for example signature verification by the attendant).")]
    Acceptor,
    
    /// <summary>
    /// Acquirer of the transaction.
    /// Encoded/decoded by serializers as "Acquirer".
    /// </summary>
    [EnumMember(Value = "ACQR")]
    [IsoId("_cFaUgybTEeyhZIgCcGlTyA")]
    [Description(@"Acquirer of the transaction.")]
    Acquirer,
    
    /// <summary>
    /// Entity providing card payment processing services acting as an intermediary between (or on behalf of) an acquirer and an issuer.
    /// Encoded/decoded by serializers as "Agent".
    /// </summary>
    [EnumMember(Value = "AGNT")]
    [IsoId("_cFaUhSbTEeyhZIgCcGlTyA")]
    [Description(@"Entity providing card payment processing services acting as an intermediary between (or on behalf of) an acquirer and an issuer.")]
    Agent,
    
    /// <summary>
    /// Card issuer.
    /// Encoded/decoded by serializers as "Issuer".
    /// </summary>
    [EnumMember(Value = "ISSR")]
    [IsoId("_cFaUhybTEeyhZIgCcGlTyA")]
    [Description(@"Card issuer.")]
    Issuer,
    
    /// <summary>
    /// Other type of authentication entity defined at national level.
    /// Encoded/decoded by serializers as "OtherNational".
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_cFaUiSbTEeyhZIgCcGlTyA")]
    [Description(@"Other type of authentication entity defined at national level.")]
    OtherNational,
    
    /// <summary>
    /// Other type of authentication entity defined at private level.
    /// Encoded/decoded by serializers as "OtherPrivate".
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_cFaUiybTEeyhZIgCcGlTyA")]
    [Description(@"Other type of authentication entity defined at private level.")]
    OtherPrivate,
    
    /// <summary>
    /// Type of Device to accept payment
    /// Encoded/decoded by serializers as "AcceptanceDevice".
    /// </summary>
    [EnumMember(Value = "CDAD")]
    [IsoId("_ebmv0SbTEeyhZIgCcGlTyA")]
    [Description(@"Type of Device to accept payment")]
    AcceptanceDevice,
    
    /// <summary>
    /// Application in the smart card.
    /// Encoded/decoded by serializers as "CardApplication".
    /// </summary>
    [EnumMember(Value = "ICCA")]
    [IsoId("_emCeMSbTEeyhZIgCcGlTyA")]
    [Description(@"Application in the smart card.")]
    CardApplication,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class VerificationEntity2CodeMetadataExtensions
{
    private static readonly VerificationEntity2CodeDropdownSource _dropdownSource = new VerificationEntity2CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IVerificationEntity2CodeDropdownRow GetMetadata(this VerificationEntity2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


