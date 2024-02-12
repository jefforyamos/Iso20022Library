﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for PartyType21Code.  ISO2002 ID# _vMT78E0uEeea0Mdu1TOzDQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Contains destination party type.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_vMT78E0uEeea0Mdu1TOzDQ")]
[Description(@"Contains destination party type.")]
[DerivedFrom(typeof(PartyTypeCode))]
public enum PartyType21Code
{
    /// <summary>
    /// Card acceptor, party accepting the card and presenting transaction data to the acquirer.
    /// Encoded/decoded by serializers as "ACCP".
    /// </summary>
    [EnumMember(Value = "ACCP")]
    [IsoId("_3Apa8U0uEeea0Mdu1TOzDQ")]
    [Description(@"Card acceptor, party accepting the card and presenting transaction data to the acquirer.")]
    Acceptor = PartyTypeCode.Acceptor, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Holder of a payment card.
    /// Encoded/decoded by serializers as "CRDH".
    /// </summary>
    [EnumMember(Value = "CRDH")]
    [IsoId("_3W3ikk0uEeea0Mdu1TOzDQ")]
    [Description(@"Holder of a payment card.")]
    Cardholder = PartyTypeCode.Cardholder, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other card payment entity type defined at national level
    /// Encoded/decoded by serializers as "OTHN".
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_4jfGsk0uEeea0Mdu1TOzDQ")]
    [Description(@"Other card payment entity type defined at national level")]
    OtherNational = PartyTypeCode.OtherNational, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other card payment entity type defined at private level
    /// Encoded/decoded by serializers as "OTHP".
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_4x3g8k0uEeea0Mdu1TOzDQ")]
    [Description(@"Other card payment entity type defined at private level")]
    OtherPrivate = PartyTypeCode.OtherPrivate, // same ordinal as derivation source for type conversions
    
}
