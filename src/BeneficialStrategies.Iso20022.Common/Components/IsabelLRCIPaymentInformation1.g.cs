﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for IsabelLRCIPaymentInformation1.  ISO2002 ID# _2UOvYM_aEeWjSMe6YTKHlQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies a record holding the LRCI required data related to a payment file.
/// </summary>
public partial record IsabelLRCIPaymentInformation1
     : IIsoXmlSerilizable<IsabelLRCIPaymentInformation1>
{
    #nullable enable
    
    /// <summary>
    /// Arbitrary block of data defined as a fixed-size bit string, the (cryptographic) hash value, which allows the detection of an accidental or intentional change to the visual representation of a particular payment file.
    /// </summary>
    public required IsoMax50Binary ImageHash { get; init; } 
    /// <summary>
    /// Arbitrary block of data defined as a fixed-size bit string, the (cryptographic) hash value, which allows the detection of an accidental or intentional change to a particular payment file.
    /// </summary>
    public required IsoMax50Binary PaymentHash { get; init; } 
    
    #nullable disable
    
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public void Serialize(XmlWriter writer, string xmlNamespace)
    {
        writer.WriteStartElement(null, "ImgHash", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax50Binary(ImageHash)); // data type Max50Binary System.Byte[]
        writer.WriteEndElement();
        writer.WriteStartElement(null, "PmtHash", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax50Binary(PaymentHash)); // data type Max50Binary System.Byte[]
        writer.WriteEndElement();
    }
    public static IsabelLRCIPaymentInformation1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
