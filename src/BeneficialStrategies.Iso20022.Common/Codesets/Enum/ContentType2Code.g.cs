﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ContentType2Code.  ISO2002 ID# _gQ7oMWizEeS87LmvcA55sg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identification of the type of a Cryptographic Message Syntax (CMS) data structure.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_gQ7oMWizEeS87LmvcA55sg")]
[Description(@"Identification of the type of a Cryptographic Message Syntax (CMS) data structure.")]
[DerivedFrom(typeof(ContentTypeCode))]
public enum ContentType2Code
{
    /// <summary>
    /// Generic, non cryptographic, or unqualified data content - (ASN.1 Object Identifier: id-data).
    /// Encoded/decoded by serializers as "DATA".
    /// </summary>
    [EnumMember(Value = "DATA")]
    [IsoId("_gd_z0WizEeS87LmvcA55sg")]
    [Description(@"Generic, non cryptographic, or unqualified data content - (ASN.1 Object Identifier: id-data).")]
    PlainData = ContentTypeCode.PlainData, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Digital signature - (ASN.1 Object Identifier: id-signedData).
    /// Encoded/decoded by serializers as "SIGN".
    /// </summary>
    [EnumMember(Value = "SIGN")]
    [IsoId("_gd_z02izEeS87LmvcA55sg")]
    [Description(@"Digital signature - (ASN.1 Object Identifier: id-signedData).")]
    SignedData = ContentTypeCode.SignedData, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Encrypted data, with encryption key - (ASN.1 Object Identifier: id-envelopedData).
    /// Encoded/decoded by serializers as "EVLP".
    /// </summary>
    [EnumMember(Value = "EVLP")]
    [IsoId("_gd_z1WizEeS87LmvcA55sg")]
    [Description(@"Encrypted data, with encryption key - (ASN.1 Object Identifier: id-envelopedData).")]
    EnvelopedData = ContentTypeCode.EnvelopedData, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Message digest - (ASN.1 Object Identifier: id-digestedData).
    /// Encoded/decoded by serializers as "DGST".
    /// </summary>
    [EnumMember(Value = "DGST")]
    [IsoId("_gd_z12izEeS87LmvcA55sg")]
    [Description(@"Message digest - (ASN.1 Object Identifier: id-digestedData).")]
    DigestedData = ContentTypeCode.DigestedData, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// MAC (Message Authentication Code), with encryption key - (ASN.1 Object Identifier: id-ct-authData).
    /// Encoded/decoded by serializers as "AUTH".
    /// </summary>
    [EnumMember(Value = "AUTH")]
    [IsoId("_gd_z22izEeS87LmvcA55sg")]
    [Description(@"MAC (Message Authentication Code), with encryption key - (ASN.1 Object Identifier: id-ct-authData).")]
    AuthenticatedData = ContentTypeCode.AuthenticatedData, // same ordinal as derivation source for type conversions
    
}
