﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CommunicationMethod3Code.  ISO2002 ID# _r1Pt8Bg2EeKnW4lR85q-0A.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Communication method used for the transmission of documents.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_r1Pt8Bg2EeKnW4lR85q-0A")]
[Description(@"Communication method used for the transmission of documents.")]
[DerivedFrom(typeof(CommunicationMethodCode))]
public enum CommunicationMethod3Code
{
    /// <summary>
    /// Transmission by e-mail.
    /// Encoded/decoded by serializers as "EMAL".
    /// </summary>
    [EnumMember(Value = "EMAL")]
    [IsoId("_tRC9kRg2EeKnW4lR85q-0A")]
    [Description(@"Transmission by e-mail.")]
    Email = CommunicationMethodCode.Email, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transmission by fax.
    /// Encoded/decoded by serializers as "FAXI".
    /// </summary>
    [EnumMember(Value = "FAXI")]
    [IsoId("_tf8VMRg2EeKnW4lR85q-0A")]
    [Description(@"Transmission by fax.")]
    Fax = CommunicationMethodCode.Fax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transmission by postal service.
    /// Encoded/decoded by serializers as "POST".
    /// </summary>
    [EnumMember(Value = "POST")]
    [IsoId("_uOSo8Rg2EeKnW4lR85q-0A")]
    [Description(@"Transmission by postal service.")]
    PostalService = CommunicationMethodCode.PostalService, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transmission by telephone.
    /// Encoded/decoded by serializers as "PHON".
    /// </summary>
    [EnumMember(Value = "PHON")]
    [IsoId("_uWC2wRg2EeKnW4lR85q-0A")]
    [Description(@"Transmission by telephone.")]
    Phone = CommunicationMethodCode.Phone, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transmission by file transfer.
    /// Encoded/decoded by serializers as "FILE".
    /// </summary>
    [EnumMember(Value = "FILE")]
    [IsoId("_xrSUQRg2EeKnW4lR85q-0A")]
    [Description(@"Transmission by file transfer.")]
    File = CommunicationMethodCode.File, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transmission on line, for example, in a web portal.
    /// Encoded/decoded by serializers as "ONLI".
    /// </summary>
    [EnumMember(Value = "ONLI")]
    [IsoId("_NfzJcUp-EeKw5sECfP82rg")]
    [Description(@"Transmission on line, for example, in a web portal.")]
    Online = CommunicationMethodCode.Online, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CommunicationMethod3CodeMetadataExtensions
{
    private static readonly CommunicationMethod3CodeDropdownSource _dropdownSource = new CommunicationMethod3CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICommunicationMethod3CodeDropdownRow GetMetadata(this CommunicationMethod3Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


