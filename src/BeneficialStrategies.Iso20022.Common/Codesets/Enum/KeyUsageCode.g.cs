﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for KeyUsageCode.  ISO2002 ID# _KSSY6H1DEeCF8NjrBemJWQ_-383369433.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Allowed usages of the key.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_KSSY6H1DEeCF8NjrBemJWQ_-383369433")]
[Description(@"Allowed usages of the key.")]
[Derivations(typeof(KeyUsage1Code))]
// External derivations that should be provided by the proper interface are: 
public enum KeyUsageCode
{
    /// <summary>
    /// Key may encrypt.
    /// Encoded/decoded by serializers as "ENCR".
    /// </summary>
    [EnumMember(Value = "ENCR")]
    [IsoId("_KSSY6X1DEeCF8NjrBemJWQ_-430910960")]
    [Description(@"Key may encrypt.")]
    Encryption,
    
    /// <summary>
    /// Key may decrypt.
    /// Encoded/decoded by serializers as "DCPT".
    /// </summary>
    [EnumMember(Value = "DCPT")]
    [IsoId("_KScJ4H1DEeCF8NjrBemJWQ_744280065")]
    [Description(@"Key may decrypt.")]
    Decryption,
    
    /// <summary>
    /// Key may encrypt data.
    /// Encoded/decoded by serializers as "DENC".
    /// </summary>
    [EnumMember(Value = "DENC")]
    [IsoId("_KScJ4X1DEeCF8NjrBemJWQ_858119131")]
    [Description(@"Key may encrypt data.")]
    DataEncryption,
    
    /// <summary>
    /// Key may decrypt data.
    /// Encoded/decoded by serializers as "DDEC".
    /// </summary>
    [EnumMember(Value = "DDEC")]
    [IsoId("_KScJ4n1DEeCF8NjrBemJWQ_-1427983313")]
    [Description(@"Key may decrypt data.")]
    DataDecryption,
    
    /// <summary>
    /// Key may encrypt information after translation.
    /// Encoded/decoded by serializers as "TRNX".
    /// </summary>
    [EnumMember(Value = "TRNX")]
    [IsoId("_KScJ431DEeCF8NjrBemJWQ_319261856")]
    [Description(@"Key may encrypt information after translation.")]
    TranslateOutput,
    
    /// <summary>
    /// Key may encrypt information before translation.
    /// Encoded/decoded by serializers as "TRNI".
    /// </summary>
    [EnumMember(Value = "TRNI")]
    [IsoId("_KScJ5H1DEeCF8NjrBemJWQ_-252792288")]
    [Description(@"Key may encrypt information before translation.")]
    TranslateInput,
    
    /// <summary>
    /// Key may generate message authentication codes (MAC).
    /// Encoded/decoded by serializers as "MACG".
    /// </summary>
    [EnumMember(Value = "MACG")]
    [IsoId("_KScJ5X1DEeCF8NjrBemJWQ_-1314144247")]
    [Description(@"Key may generate message authentication codes (MAC).")]
    MessageAuthenticationCodeGeneration,
    
    /// <summary>
    /// Key may verify message authentication codes (MAC).
    /// Encoded/decoded by serializers as "MACV".
    /// </summary>
    [EnumMember(Value = "MACV")]
    [IsoId("_KScJ5n1DEeCF8NjrBemJWQ_1563233746")]
    [Description(@"Key may verify message authentication codes (MAC).")]
    MessageAuthenticationCodeVerification,
    
    /// <summary>
    /// Key may generate digital signatures.
    /// Encoded/decoded by serializers as "SIGG".
    /// </summary>
    [EnumMember(Value = "SIGG")]
    [IsoId("_KScJ531DEeCF8NjrBemJWQ_566161393")]
    [Description(@"Key may generate digital signatures.")]
    SignatureGeneration,
    
    /// <summary>
    /// Key may verify digital signatures.
    /// Encoded/decoded by serializers as "SUGV".
    /// </summary>
    [EnumMember(Value = "SUGV")]
    [IsoId("_KScJ6H1DEeCF8NjrBemJWQ_1741352418")]
    [Description(@"Key may verify digital signatures.")]
    SignatureVerification,
    
    /// <summary>
    /// Key may encrypt personal identification numbers (PIN).
    /// Encoded/decoded by serializers as "PINE".
    /// </summary>
    [EnumMember(Value = "PINE")]
    [IsoId("_KScJ6X1DEeCF8NjrBemJWQ_-317071894")]
    [Description(@"Key may encrypt personal identification numbers (PIN).")]
    PINEncryption,
    
    /// <summary>
    /// Key may decrypt personal identification numbers (PIN).
    /// Encoded/decoded by serializers as "PIND".
    /// </summary>
    [EnumMember(Value = "PIND")]
    [IsoId("_KSlT0H1DEeCF8NjrBemJWQ_1677072812")]
    [Description(@"Key may decrypt personal identification numbers (PIN).")]
    PINDecryption,
    
    /// <summary>
    /// Key may verify personal identification numbers (PIN).
    /// Encoded/decoded by serializers as "PINV".
    /// </summary>
    [EnumMember(Value = "PINV")]
    [IsoId("_KSlT0X1DEeCF8NjrBemJWQ_680000459")]
    [Description(@"Key may verify personal identification numbers (PIN).")]
    PINVerification,
    
    /// <summary>
    /// Key may generate keys.
    /// Encoded/decoded by serializers as "KEYG".
    /// </summary>
    [EnumMember(Value = "KEYG")]
    [IsoId("_KSlT0n1DEeCF8NjrBemJWQ_-1136025575")]
    [Description(@"Key may generate keys.")]
    KeyGeneration,
    
    /// <summary>
    /// Key may import keys.
    /// Encoded/decoded by serializers as "KEYI".
    /// </summary>
    [EnumMember(Value = "KEYI")]
    [IsoId("_KSlT031DEeCF8NjrBemJWQ_-138953222")]
    [Description(@"Key may import keys.")]
    KeyImport,
    
    /// <summary>
    /// Key may export keys.
    /// Encoded/decoded by serializers as "KEYX".
    /// </summary>
    [EnumMember(Value = "KEYX")]
    [IsoId("_KSlT1H1DEeCF8NjrBemJWQ_497380528")]
    [Description(@"Key may export keys.")]
    KeyExport,
    
    /// <summary>
    /// Key may derive keys.
    /// Encoded/decoded by serializers as "KEYD".
    /// </summary>
    [EnumMember(Value = "KEYD")]
    [IsoId("_KSlT1X1DEeCF8NjrBemJWQ_1855191484")]
    [Description(@"Key may derive keys.")]
    KeyDerivation,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class KeyUsageCodeMetadataExtensions
{
    private static readonly KeyUsageCodeDropdownSource _dropdownSource = new KeyUsageCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IKeyUsageCodeDropdownRow GetMetadata(this KeyUsageCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


